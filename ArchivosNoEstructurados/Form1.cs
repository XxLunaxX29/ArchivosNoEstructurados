namespace ArchivosNoEstructurados
{
    public partial class Form1 : Form
    {
        private List<string> lineas = new List<string>();
        private string rutaArchivo = "";
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }
        private void ConfigurarGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Linea", "Contenido del archivo");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos LOG|*.log|Archivos SRT|*.srt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = sfd.FileName;
                File.WriteAllText(rutaArchivo, "");
                lineas.Clear();
                dataGridView1.Rows.Clear();
                MessageBox.Show("Archivo creado correctamente");
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos LOG|*.log|Archivos SRT|*.srt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = ofd.FileName;
                lineas = File.ReadAllLines(rutaArchivo).ToList();
                MostrarEnGrid();
            }
        }
        private void MostrarEnGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var linea in lineas)
            {
                dataGridView1.Rows.Add(linea);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                MessageBox.Show("Primero debes abrir o crear un archivo.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEntrada.Text))
            {
                MessageBox.Show("Escribe algo primero");
                return;
            }

            lineas.Add(txtEntrada.Text);
            dataGridView1.Rows.Add(txtEntrada.Text);
            txtEntrada.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                MessageBox.Show("Primero debes abrir un archivo.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataGridView1.CurrentRow == null) return;

            int index = dataGridView1.CurrentRow.Index;
            lineas.RemoveAt(index);
            MostrarEnGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                MessageBox.Show("Primero debes abrir un archivo.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string texto = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Escribe un texto a buscar");
                return;
            }

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.Selected = false;
                string valor = fila.Cells[0].Value.ToString().ToLower();

                if (valor == texto)
                {
                    fila.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = fila.Index;
                    MessageBox.Show("Texto encontrado en la línea " + (fila.Index + 1));
                    return;
                }
            }
            MessageBox.Show("Texto no encontrado");
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivo))
            {
                MessageBox.Show("No hay archivo abierto");
                return;
            }

            File.WriteAllLines(rutaArchivo, lineas);
            MessageBox.Show("Archivo guardado correctamente");
        }

        // MOSTRAR EN TEXTBOX AL SELECCIONAR
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            txtEntrada.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

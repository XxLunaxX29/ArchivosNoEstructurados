namespace ArchivosNoEstructurados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAbrir = new Button();
            btnCrear = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnBuscar = new Button();
            Guardar = new Button();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            txtEntrada = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(534, 19);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(94, 29);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(422, 19);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(648, 59);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(648, 19);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(310, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(534, 59);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(94, 29);
            Guardar.TabIndex = 5;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(620, 298);
            dataGridView1.TabIndex = 6;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(82, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(190, 27);
            txtBuscar.TabIndex = 7;
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(82, 56);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(190, 27);
            txtEntrada.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 9;
            label1.Text = "Buscar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 63);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 10;
            label2.Text = "Datos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEntrada);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(Guardar);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(btnAbrir);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrir;
        private Button btnCrear;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button Guardar;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private TextBox txtEntrada;
        private Label label1;
        private Label label2;
    }
}

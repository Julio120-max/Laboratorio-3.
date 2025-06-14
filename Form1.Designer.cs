namespace Laboratorio_3__switch_case
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
            lblactividades = new Label();
            cbxactividades = new ComboBox();
            btnejercicios = new Button();
            lblalimentacion = new Label();
            cbxalimentacion = new ComboBox();
            btnalimentacion = new Button();
            btnsalir = new Button();
            lblcategorias = new Label();
            SuspendLayout();
            // 
            // lblactividades
            // 
            lblactividades.AutoSize = true;
            lblactividades.Location = new Point(16, 15);
            lblactividades.Name = "lblactividades";
            lblactividades.Size = new Size(143, 15);
            lblactividades.TabIndex = 0;
            lblactividades.Text = "Actividades de Gimnasio :";
            // 
            // cbxactividades
            // 
            cbxactividades.FormattingEnabled = true;
            cbxactividades.Items.AddRange(new object[] { "1-Cardio", "2-Fuerza", "3-Flexibilidad", "4-Funcionalidad", "5-Combate" });
            cbxactividades.Location = new Point(16, 75);
            cbxactividades.Margin = new Padding(3, 2, 3, 2);
            cbxactividades.Name = "cbxactividades";
            cbxactividades.Size = new Size(266, 23);
            cbxactividades.TabIndex = 1;
            // 
            // btnejercicios
            // 
            btnejercicios.Location = new Point(335, 74);
            btnejercicios.Margin = new Padding(3, 2, 3, 2);
            btnejercicios.Name = "btnejercicios";
            btnejercicios.Size = new Size(181, 22);
            btnejercicios.TabIndex = 2;
            btnejercicios.Text = "Ver ejercicios";
            btnejercicios.UseVisualStyleBackColor = true;
            btnejercicios.Click += btnejercicios_Click;
            // 
            // lblalimentacion
            // 
            lblalimentacion.AutoSize = true;
            lblalimentacion.Location = new Point(16, 158);
            lblalimentacion.Name = "lblalimentacion";
            lblalimentacion.Size = new Size(224, 15);
            lblalimentacion.TabIndex = 3;
            lblalimentacion.Text = "Plan de alimentación saludable semanal :";
            // 
            // cbxalimentacion
            // 
            cbxalimentacion.FormattingEnabled = true;
            cbxalimentacion.Items.AddRange(new object[] { "1. Lunes", "2. Martes ", "3. Miercoles", "4. Jueves", "5. Viernes", "6. Sabado ", "7. Domingo" });
            cbxalimentacion.Location = new Point(16, 207);
            cbxalimentacion.Margin = new Padding(3, 2, 3, 2);
            cbxalimentacion.Name = "cbxalimentacion";
            cbxalimentacion.Size = new Size(266, 23);
            cbxalimentacion.TabIndex = 4;
            // 
            // btnalimentacion
            // 
            btnalimentacion.Location = new Point(335, 207);
            btnalimentacion.Margin = new Padding(3, 2, 3, 2);
            btnalimentacion.Name = "btnalimentacion";
            btnalimentacion.Size = new Size(181, 22);
            btnalimentacion.TabIndex = 5;
            btnalimentacion.Text = "Ver plan de alimentación";
            btnalimentacion.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(574, 298);
            btnsalir.Margin = new Padding(3, 2, 3, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(82, 22);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // lblcategorias
            // 
            lblcategorias.AutoSize = true;
            lblcategorias.Location = new Point(103, 50);
            lblcategorias.Name = "lblcategorias";
            lblcategorias.Size = new Size(69, 15);
            lblcategorias.TabIndex = 7;
            lblcategorias.Text = "Categorias :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblcategorias);
            Controls.Add(btnsalir);
            Controls.Add(btnalimentacion);
            Controls.Add(cbxalimentacion);
            Controls.Add(lblalimentacion);
            Controls.Add(btnejercicios);
            Controls.Add(cbxactividades);
            Controls.Add(lblactividades);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Laboratorio 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblactividades;
        private ComboBox cbxactividades;
        private Button btnejercicios;
        private Label lblalimentacion;
        private ComboBox cbxalimentacion;
        private Button btnalimentacion;
        private Button btnsalir;
        private Label lblcategorias;
    }
}

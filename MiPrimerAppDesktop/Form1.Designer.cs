namespace MiPrimerAppDesktop
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
            lblTitulo = new Label();
            lblNombre = new Label();
            txtValorNombre = new TextBox();
            btnSaludar = new Button();
            lblResultado = new Label();
            checkBoxHombre = new CheckBox();
            checkBoxMujer = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Coral;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(293, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(201, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "que onda perro";
            lblTitulo.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(48, 101);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(173, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Ingrese su nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtValorNombre
            // 
            txtValorNombre.Location = new Point(223, 103);
            txtValorNombre.Name = "txtValorNombre";
            txtValorNombre.Size = new Size(183, 23);
            txtValorNombre.TabIndex = 2;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(439, 96);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(118, 35);
            btnSaludar.TabIndex = 3;
            btnSaludar.Text = "SALUDAR";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Coral;
            lblResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(235, 208);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 37);
            lblResultado.TabIndex = 4;
            lblResultado.Click += label2_Click;
            // 
            // checkBoxHombre
            // 
            checkBoxHombre.AutoSize = true;
            checkBoxHombre.Location = new Point(673, 87);
            checkBoxHombre.Name = "checkBoxHombre";
            checkBoxHombre.Size = new Size(81, 19);
            checkBoxHombre.TabIndex = 5;
            checkBoxHombre.Text = "masculino";
            checkBoxHombre.UseVisualStyleBackColor = true;
            checkBoxHombre.CheckedChanged += checkBoxHombre_CheckedChanged;
            // 
            // checkBoxMujer
            // 
            checkBoxMujer.AutoSize = true;
            checkBoxMujer.Location = new Point(673, 112);
            checkBoxMujer.Name = "checkBoxMujer";
            checkBoxMujer.Size = new Size(77, 19);
            checkBoxMujer.TabIndex = 6;
            checkBoxMujer.Text = "femenino";
            checkBoxMujer.UseVisualStyleBackColor = true;
            checkBoxMujer.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(673, 58);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 7;
            label1.Text = "Sexo:";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(checkBoxMujer);
            Controls.Add(checkBoxHombre);
            Controls.Add(lblResultado);
            Controls.Add(btnSaludar);
            Controls.Add(txtValorNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtValorNombre;
        private Button btnSaludar;
        private Label lblResultado;
        private CheckBox checkBoxHombre;
        private CheckBox checkBoxMujer;
        private Label label1;
    }
}
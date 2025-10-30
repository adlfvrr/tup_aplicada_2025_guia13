namespace GeometriaClientRestAPIDesktop
{
    partial class FormPrincipal
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
            btnConsulta = new Button();
            lsbConsultas = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(575, 110);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(180, 59);
            btnConsulta.TabIndex = 0;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // lsbConsultas
            // 
            lsbConsultas.FormattingEnabled = true;
            lsbConsultas.ItemHeight = 15;
            lsbConsultas.Location = new Point(46, 47);
            lsbConsultas.Name = "lsbConsultas";
            lsbConsultas.Size = new Size(481, 364);
            lsbConsultas.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(591, 207);
            button1.Name = "button1";
            button1.Size = new Size(146, 67);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lsbConsultas);
            Controls.Add(btnConsulta);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsulta;
        private ListBox lsbConsultas;
        private Button button1;
    }
}

namespace Atividade_1
{
    partial class FrmChamados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ActiveCaption;
            btnVoltar.Location = new Point(155, 155);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 50);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmChamados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Name = "FrmChamados";
            Text = "FrmChamados";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
    }
}
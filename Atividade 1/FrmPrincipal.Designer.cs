namespace Atividade_1
{
    partial class FrmPrincipal
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
            btnUsuario = new Button();
            btnChamados = new Button();
            btnSair = new Button();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = SystemColors.ActiveCaption;
            btnUsuario.Location = new Point(12, 26);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(112, 50);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuário";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnChamados
            // 
            btnChamados.BackColor = SystemColors.ActiveCaption;
            btnChamados.Location = new Point(12, 95);
            btnChamados.Name = "btnChamados";
            btnChamados.Size = new Size(112, 50);
            btnChamados.TabIndex = 1;
            btnChamados.Text = "Chamados";
            btnChamados.UseVisualStyleBackColor = false;
            btnChamados.Click += btnChamados_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ActiveCaption;
            btnSair.Location = new Point(12, 167);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(112, 50);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 450);
            Controls.Add(btnSair);
            Controls.Add(btnChamados);
            Controls.Add(btnUsuario);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnChamados;
        private Button btnSair;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
    }
}
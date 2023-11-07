namespace BFHJL
{
    partial class Cadastro
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
            this.txtNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSaldoInicial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCadastrar = new DevComponents.DotNetBar.ButtonX();
            this.txtSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.Border.Class = "TextBoxBorder";
            this.txtNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNome.ButtonCustom.Symbol = "";
            this.txtNome.Location = new System.Drawing.Point(13, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.PreventEnterBeep = true;
            this.txtNome.Size = new System.Drawing.Size(252, 30);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Digite o Nome";
            // 
            // txtSaldoInicial
            // 
            // 
            // 
            // 
            this.txtSaldoInicial.Border.Class = "TextBoxBorder";
            this.txtSaldoInicial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSaldoInicial.Location = new System.Drawing.Point(13, 88);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.PreventEnterBeep = true;
            this.txtSaldoInicial.Size = new System.Drawing.Size(252, 30);
            this.txtSaldoInicial.TabIndex = 1;
            this.txtSaldoInicial.Text = "Digite o Saldo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCadastrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnCadastrar.Location = new System.Drawing.Point(294, 62);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(159, 85);
            this.btnCadastrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCadastrar.Symbol = "59390";
            this.btnCadastrar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = " Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.Border.Class = "TextBoxBorder";
            this.txtSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSenha.Location = new System.Drawing.Point(13, 136);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PreventEnterBeep = true;
            this.txtSenha.Size = new System.Drawing.Size(252, 30);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Digite a Senha";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(477, 198);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtNome;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSaldoInicial;
        private DevComponents.DotNetBar.ButtonX btnCadastrar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSenha;

    }
}
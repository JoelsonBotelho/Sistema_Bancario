namespace BFHJL
{
    partial class DepositoSaque
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
            this.txtValor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnDepositar = new DevComponents.DotNetBar.ButtonX();
            this.btnSaque = new DevComponents.DotNetBar.ButtonX();
            this.lblNumConta = new DevComponents.DotNetBar.LabelX();
            this.lblNomes = new DevComponents.DotNetBar.LabelX();
            this.lstListaNumConta = new DevComponents.DotNetBar.ListBoxAdv();
            this.lstListaNomes = new DevComponents.DotNetBar.ListBoxAdv();
            this.lblSaldoBancario = new DevComponents.DotNetBar.LabelX();
            this.lstListaSaldo = new DevComponents.DotNetBar.ListBoxAdv();
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
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.PreventEnterBeep = true;
            this.txtNome.Size = new System.Drawing.Size(427, 30);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Digite o Número da Conta";
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.Border.Class = "TextBoxBorder";
            this.txtValor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtValor.Location = new System.Drawing.Point(12, 58);
            this.txtValor.Name = "txtValor";
            this.txtValor.PreventEnterBeep = true;
            this.txtValor.Size = new System.Drawing.Size(427, 30);
            this.txtValor.TabIndex = 1;
            this.txtValor.Text = "Digite o Valor do Saldo a Depositar ou a Levantar";
            // 
            // btnDepositar
            // 
            this.btnDepositar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDepositar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnDepositar.Location = new System.Drawing.Point(476, 12);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(178, 49);
            this.btnDepositar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDepositar.Symbol = "";
            this.btnDepositar.TabIndex = 5;
            this.btnDepositar.Text = " Depositar";
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaque.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSaque.Location = new System.Drawing.Point(476, 81);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(178, 53);
            this.btnSaque.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaque.Symbol = "";
            this.btnSaque.TabIndex = 6;
            this.btnSaque.Text = " Levantar";
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // lblNumConta
            // 
            // 
            // 
            // 
            this.lblNumConta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNumConta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumConta.Location = new System.Drawing.Point(240, 145);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(222, 49);
            this.lblNumConta.Symbol = "";
            this.lblNumConta.TabIndex = 10;
            this.lblNumConta.Text = "Números De Contas";
            // 
            // lblNomes
            // 
            // 
            // 
            // 
            this.lblNomes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNomes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomes.Location = new System.Drawing.Point(23, 145);
            this.lblNomes.Name = "lblNomes";
            this.lblNomes.Size = new System.Drawing.Size(211, 49);
            this.lblNomes.Symbol = "";
            this.lblNomes.TabIndex = 9;
            this.lblNomes.Text = "Nomes:";
            // 
            // lstListaNumConta
            // 
            this.lstListaNumConta.AutoScroll = true;
            // 
            // 
            // 
            this.lstListaNumConta.BackgroundStyle.Class = "ListBoxAdv";
            this.lstListaNumConta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstListaNumConta.CheckStateMember = null;
            this.lstListaNumConta.ContainerControlProcessDialogKey = true;
            this.lstListaNumConta.DragDropSupport = true;
            this.lstListaNumConta.Location = new System.Drawing.Point(240, 197);
            this.lstListaNumConta.Name = "lstListaNumConta";
            this.lstListaNumConta.Size = new System.Drawing.Size(222, 330);
            this.lstListaNumConta.TabIndex = 8;
            this.lstListaNumConta.Text = "listBoxAdv1";
            // 
            // lstListaNomes
            // 
            this.lstListaNomes.AutoScroll = true;
            // 
            // 
            // 
            this.lstListaNomes.BackgroundStyle.Class = "ListBoxAdv";
            this.lstListaNomes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstListaNomes.CheckStateMember = null;
            this.lstListaNomes.ContainerControlProcessDialogKey = true;
            this.lstListaNomes.DragDropSupport = true;
            this.lstListaNomes.Location = new System.Drawing.Point(12, 197);
            this.lstListaNomes.Name = "lstListaNomes";
            this.lstListaNomes.Size = new System.Drawing.Size(222, 330);
            this.lstListaNomes.TabIndex = 7;
            this.lstListaNomes.Text = "listBoxAdv1";
            // 
            // lblSaldoBancario
            // 
            // 
            // 
            // 
            this.lblSaldoBancario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSaldoBancario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaldoBancario.Location = new System.Drawing.Point(468, 145);
            this.lblSaldoBancario.Name = "lblSaldoBancario";
            this.lblSaldoBancario.Size = new System.Drawing.Size(222, 49);
            this.lblSaldoBancario.Symbol = "";
            this.lblSaldoBancario.TabIndex = 12;
            this.lblSaldoBancario.Text = "Saldo Báncario";
            // 
            // lstListaSaldo
            // 
            this.lstListaSaldo.AutoScroll = true;
            // 
            // 
            // 
            this.lstListaSaldo.BackgroundStyle.Class = "ListBoxAdv";
            this.lstListaSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstListaSaldo.CheckStateMember = null;
            this.lstListaSaldo.ContainerControlProcessDialogKey = true;
            this.lstListaSaldo.DragDropSupport = true;
            this.lstListaSaldo.Location = new System.Drawing.Point(468, 197);
            this.lstListaSaldo.Name = "lstListaSaldo";
            this.lstListaSaldo.Size = new System.Drawing.Size(222, 330);
            this.lstListaSaldo.TabIndex = 11;
            this.lstListaSaldo.Text = "listBoxAdv1";
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.Border.Class = "TextBoxBorder";
            this.txtSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSenha.Location = new System.Drawing.Point(12, 104);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PreventEnterBeep = true;
            this.txtSenha.Size = new System.Drawing.Size(427, 30);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            // 
            // DepositoSaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(699, 530);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSaldoBancario);
            this.Controls.Add(this.lstListaSaldo);
            this.Controls.Add(this.lblNumConta);
            this.Controls.Add(this.lblNomes);
            this.Controls.Add(this.lstListaNumConta);
            this.Controls.Add(this.lstListaNomes);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepositoSaque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposito E Saque";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtNome;
        private DevComponents.DotNetBar.Controls.TextBoxX txtValor;
        private DevComponents.DotNetBar.ButtonX btnDepositar;
        private DevComponents.DotNetBar.ButtonX btnSaque;
        private DevComponents.DotNetBar.LabelX lblNumConta;
        private DevComponents.DotNetBar.LabelX lblNomes;
        private DevComponents.DotNetBar.ListBoxAdv lstListaNumConta;
        private DevComponents.DotNetBar.ListBoxAdv lstListaNomes;
        private DevComponents.DotNetBar.LabelX lblSaldoBancario;
        private DevComponents.DotNetBar.ListBoxAdv lstListaSaldo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSenha;
    }
}
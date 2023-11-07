namespace BFHJL
{
    partial class TransferenciaBancaria
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
            this.txtNomeRetirar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNomePor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTransferir = new DevComponents.DotNetBar.ButtonX();
            this.lstNomeRetirar = new DevComponents.DotNetBar.ListBoxAdv();
            this.lblNomeRetirar = new DevComponents.DotNetBar.LabelX();
            this.lblSaldoBancarioRetirar = new DevComponents.DotNetBar.LabelX();
            this.lstSaldoBancarioRetirar = new DevComponents.DotNetBar.ListBoxAdv();
            this.lblSaldoBancarioPor = new DevComponents.DotNetBar.LabelX();
            this.lblNomePor = new DevComponents.DotNetBar.LabelX();
            this.lstSaldoBancarioPor = new DevComponents.DotNetBar.ListBoxAdv();
            this.lstNomePor = new DevComponents.DotNetBar.ListBoxAdv();
            this.txtSaldoTrans = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // txtNomeRetirar
            // 
            // 
            // 
            // 
            this.txtNomeRetirar.Border.Class = "TextBoxBorder";
            this.txtNomeRetirar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNomeRetirar.Location = new System.Drawing.Point(12, 12);
            this.txtNomeRetirar.Name = "txtNomeRetirar";
            this.txtNomeRetirar.PreventEnterBeep = true;
            this.txtNomeRetirar.Size = new System.Drawing.Size(341, 30);
            this.txtNomeRetirar.TabIndex = 0;
            this.txtNomeRetirar.Text = "Digite Número da Conta à Retirar";
            // 
            // txtNomePor
            // 
            // 
            // 
            // 
            this.txtNomePor.Border.Class = "TextBoxBorder";
            this.txtNomePor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNomePor.Location = new System.Drawing.Point(737, 12);
            this.txtNomePor.Name = "txtNomePor";
            this.txtNomePor.PreventEnterBeep = true;
            this.txtNomePor.Size = new System.Drawing.Size(341, 30);
            this.txtNomePor.TabIndex = 1;
            this.txtNomePor.Text = "Digite o Número da Conta à Colocar";
            // 
            // btnTransferir
            // 
            this.btnTransferir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTransferir.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnTransferir.Location = new System.Drawing.Point(451, 12);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(178, 45);
            this.btnTransferir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTransferir.Symbol = "";
            this.btnTransferir.TabIndex = 4;
            this.btnTransferir.Text = " Transferir";
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // lstNomeRetirar
            // 
            this.lstNomeRetirar.AutoScroll = true;
            // 
            // 
            // 
            this.lstNomeRetirar.BackgroundStyle.Class = "ListBoxAdv";
            this.lstNomeRetirar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstNomeRetirar.ContainerControlProcessDialogKey = true;
            this.lstNomeRetirar.DragDropSupport = true;
            this.lstNomeRetirar.Location = new System.Drawing.Point(12, 171);
            this.lstNomeRetirar.Name = "lstNomeRetirar";
            this.lstNomeRetirar.Size = new System.Drawing.Size(257, 200);
            this.lstNomeRetirar.TabIndex = 3;
            // 
            // lblNomeRetirar
            // 
            // 
            // 
            // 
            this.lblNomeRetirar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNomeRetirar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeRetirar.Location = new System.Drawing.Point(12, 137);
            this.lblNomeRetirar.Name = "lblNomeRetirar";
            this.lblNomeRetirar.Size = new System.Drawing.Size(257, 28);
            this.lblNomeRetirar.Symbol = "";
            this.lblNomeRetirar.TabIndex = 4;
            this.lblNomeRetirar.Text = "Nome";
            // 
            // lblSaldoBancarioRetirar
            // 
            // 
            // 
            // 
            this.lblSaldoBancarioRetirar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSaldoBancarioRetirar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaldoBancarioRetirar.Location = new System.Drawing.Point(281, 137);
            this.lblSaldoBancarioRetirar.Name = "lblSaldoBancarioRetirar";
            this.lblSaldoBancarioRetirar.Size = new System.Drawing.Size(257, 28);
            this.lblSaldoBancarioRetirar.Symbol = "";
            this.lblSaldoBancarioRetirar.TabIndex = 6;
            this.lblSaldoBancarioRetirar.Text = "Saldo Bancário";
            // 
            // lstSaldoBancarioRetirar
            // 
            this.lstSaldoBancarioRetirar.AutoScroll = true;
            // 
            // 
            // 
            this.lstSaldoBancarioRetirar.BackgroundStyle.Class = "ListBoxAdv";
            this.lstSaldoBancarioRetirar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstSaldoBancarioRetirar.CheckStateMember = null;
            this.lstSaldoBancarioRetirar.ContainerControlProcessDialogKey = true;
            this.lstSaldoBancarioRetirar.DragDropSupport = true;
            this.lstSaldoBancarioRetirar.Location = new System.Drawing.Point(281, 171);
            this.lstSaldoBancarioRetirar.Name = "lstSaldoBancarioRetirar";
            this.lstSaldoBancarioRetirar.Size = new System.Drawing.Size(257, 200);
            this.lstSaldoBancarioRetirar.TabIndex = 5;
            // 
            // lblSaldoBancarioPor
            // 
            // 
            // 
            // 
            this.lblSaldoBancarioPor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSaldoBancarioPor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaldoBancarioPor.Location = new System.Drawing.Point(822, 137);
            this.lblSaldoBancarioPor.Name = "lblSaldoBancarioPor";
            this.lblSaldoBancarioPor.Size = new System.Drawing.Size(257, 28);
            this.lblSaldoBancarioPor.Symbol = "";
            this.lblSaldoBancarioPor.TabIndex = 10;
            this.lblSaldoBancarioPor.Text = "Saldo Bancário";
            // 
            // lblNomePor
            // 
            // 
            // 
            // 
            this.lblNomePor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNomePor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomePor.Location = new System.Drawing.Point(553, 137);
            this.lblNomePor.Name = "lblNomePor";
            this.lblNomePor.Size = new System.Drawing.Size(257, 28);
            this.lblNomePor.Symbol = "";
            this.lblNomePor.TabIndex = 8;
            this.lblNomePor.Text = "Nome";
            // 
            // lstSaldoBancarioPor
            // 
            this.lstSaldoBancarioPor.AutoScroll = true;
            // 
            // 
            // 
            this.lstSaldoBancarioPor.BackgroundStyle.Class = "ListBoxAdv";
            this.lstSaldoBancarioPor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstSaldoBancarioPor.ContainerControlProcessDialogKey = true;
            this.lstSaldoBancarioPor.DragDropSupport = true;
            this.lstSaldoBancarioPor.Location = new System.Drawing.Point(822, 171);
            this.lstSaldoBancarioPor.Name = "lstSaldoBancarioPor";
            this.lstSaldoBancarioPor.Size = new System.Drawing.Size(256, 200);
            this.lstSaldoBancarioPor.TabIndex = 9;
            // 
            // lstNomePor
            // 
            this.lstNomePor.AutoScroll = true;
            // 
            // 
            // 
            this.lstNomePor.BackgroundStyle.Class = "ListBoxAdv";
            this.lstNomePor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstNomePor.ContainerControlProcessDialogKey = true;
            this.lstNomePor.DragDropSupport = true;
            this.lstNomePor.Location = new System.Drawing.Point(553, 171);
            this.lstNomePor.Name = "lstNomePor";
            this.lstNomePor.Size = new System.Drawing.Size(257, 200);
            this.lstNomePor.TabIndex = 7;
            // 
            // txtSaldoTrans
            // 
            // 
            // 
            // 
            this.txtSaldoTrans.Border.Class = "TextBoxBorder";
            this.txtSaldoTrans.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSaldoTrans.Location = new System.Drawing.Point(376, 79);
            this.txtSaldoTrans.Name = "txtSaldoTrans";
            this.txtSaldoTrans.PreventEnterBeep = true;
            this.txtSaldoTrans.Size = new System.Drawing.Size(341, 30);
            this.txtSaldoTrans.TabIndex = 3;
            this.txtSaldoTrans.Text = "Digite o Valor do Saldo a Transferir";
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.Border.Class = "TextBoxBorder";
            this.txtSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSenha.Location = new System.Drawing.Point(12, 60);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PreventEnterBeep = true;
            this.txtSenha.Size = new System.Drawing.Size(341, 30);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.Text = "Digite a Senha";
            // 
            // TransferenciaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1090, 383);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtSaldoTrans);
            this.Controls.Add(this.lblSaldoBancarioPor);
            this.Controls.Add(this.lblNomePor);
            this.Controls.Add(this.lstSaldoBancarioPor);
            this.Controls.Add(this.lstNomePor);
            this.Controls.Add(this.lblSaldoBancarioRetirar);
            this.Controls.Add(this.lblNomeRetirar);
            this.Controls.Add(this.lstSaldoBancarioRetirar);
            this.Controls.Add(this.lstNomeRetirar);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.txtNomePor);
            this.Controls.Add(this.txtNomeRetirar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferenciaBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferenciaBancaria";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtNomeRetirar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNomePor;
        private DevComponents.DotNetBar.ButtonX btnTransferir;
        private DevComponents.DotNetBar.ListBoxAdv lstNomeRetirar;
        private DevComponents.DotNetBar.LabelX lblNomeRetirar;
        private DevComponents.DotNetBar.LabelX lblSaldoBancarioRetirar;
        private DevComponents.DotNetBar.ListBoxAdv lstSaldoBancarioRetirar;
        private DevComponents.DotNetBar.LabelX lblSaldoBancarioPor;
        private DevComponents.DotNetBar.LabelX lblNomePor;
        private DevComponents.DotNetBar.ListBoxAdv lstSaldoBancarioPor;
        private DevComponents.DotNetBar.ListBoxAdv lstNomePor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSaldoTrans;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSenha;
    }
}
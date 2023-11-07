namespace BFHJL
{
    partial class ConsultaDeSaldos
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
            this.lblSaldoBancario = new DevComponents.DotNetBar.LabelX();
            this.lstListaSaldo = new DevComponents.DotNetBar.ListBoxAdv();
            this.btnPesquisar = new DevComponents.DotNetBar.ButtonX();
            this.txtPesquisar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSenha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // lblSaldoBancario
            // 
            // 
            // 
            // 
            this.lblSaldoBancario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSaldoBancario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaldoBancario.Location = new System.Drawing.Point(136, 85);
            this.lblSaldoBancario.Name = "lblSaldoBancario";
            this.lblSaldoBancario.Size = new System.Drawing.Size(243, 49);
            this.lblSaldoBancario.Symbol = "";
            this.lblSaldoBancario.TabIndex = 6;
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
            this.lstListaSaldo.Location = new System.Drawing.Point(12, 199);
            this.lstListaSaldo.Name = "lstListaSaldo";
            this.lstListaSaldo.Size = new System.Drawing.Size(422, 268);
            this.lstListaSaldo.TabIndex = 5;
            this.lstListaSaldo.Text = "listBoxAdv1";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPesquisar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnPesquisar.Location = new System.Drawing.Point(107, 140);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(243, 40);
            this.btnPesquisar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPesquisar.Symbol = "";
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            // 
            // 
            // 
            this.txtPesquisar.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtPesquisar.Border.Class = "TextBoxBorder";
            this.txtPesquisar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(12, 12);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PreventEnterBeep = true;
            this.txtPesquisar.Size = new System.Drawing.Size(422, 30);
            this.txtPesquisar.TabIndex = 7;
            this.txtPesquisar.Text = "Digite o Nome ou Número da Conta";
            this.txtPesquisar.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtSenha.Border.Class = "TextBoxBorder";
            this.txtSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(12, 49);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PreventEnterBeep = true;
            this.txtSenha.Size = new System.Drawing.Size(422, 30);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Digite a Senha";
            this.txtSenha.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConsultaDeSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(445, 479);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblSaldoBancario);
            this.Controls.Add(this.lstListaSaldo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaDeSaldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta De Saldos";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblSaldoBancario;
        private DevComponents.DotNetBar.ListBoxAdv lstListaSaldo;
        private DevComponents.DotNetBar.ButtonX btnPesquisar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPesquisar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSenha;

    }
}
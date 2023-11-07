namespace BFHJL
{
    partial class PesquisarClientes
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
            this.txtPesquisar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPesquisar = new DevComponents.DotNetBar.ButtonX();
            this.lstNome = new DevComponents.DotNetBar.ListBoxAdv();
            this.lblNome = new DevComponents.DotNetBar.LabelX();
            this.lblNumConta = new DevComponents.DotNetBar.LabelX();
            this.lstNumConta = new DevComponents.DotNetBar.ListBoxAdv();
            this.SuspendLayout();
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
            this.txtPesquisar.Location = new System.Drawing.Point(13, 13);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PreventEnterBeep = true;
            this.txtPesquisar.Size = new System.Drawing.Size(339, 30);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.Text = "Digite o Nome ou Número da Conta";
            this.txtPesquisar.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPesquisar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnPesquisar.Location = new System.Drawing.Point(376, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(173, 30);
            this.btnPesquisar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPesquisar.Symbol = "";
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lstNome
            // 
            this.lstNome.AutoScroll = true;
            // 
            // 
            // 
            this.lstNome.BackgroundStyle.Class = "ListBoxAdv";
            this.lstNome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstNome.ContainerControlProcessDialogKey = true;
            this.lstNome.DragDropSupport = true;
            this.lstNome.Location = new System.Drawing.Point(12, 99);
            this.lstNome.Name = "lstNome";
            this.lstNome.Size = new System.Drawing.Size(252, 314);
            this.lstNome.TabIndex = 2;
            this.lstNome.Text = "listBoxAdv1";
            // 
            // lblNome
            // 
            // 
            // 
            // 
            this.lblNome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(13, 60);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(251, 33);
            this.lblNome.Symbol = "";
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblNumConta
            // 
            // 
            // 
            // 
            this.lblNumConta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNumConta.ForeColor = System.Drawing.Color.Black;
            this.lblNumConta.Location = new System.Drawing.Point(298, 60);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(251, 33);
            this.lblNumConta.Symbol = "";
            this.lblNumConta.TabIndex = 5;
            this.lblNumConta.Text = "Número Da Conta";
            // 
            // lstNumConta
            // 
            this.lstNumConta.AutoScroll = true;
            // 
            // 
            // 
            this.lstNumConta.BackgroundStyle.Class = "ListBoxAdv";
            this.lstNumConta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstNumConta.ContainerControlProcessDialogKey = true;
            this.lstNumConta.DragDropSupport = true;
            this.lstNumConta.Location = new System.Drawing.Point(297, 99);
            this.lstNumConta.Name = "lstNumConta";
            this.lstNumConta.Size = new System.Drawing.Size(252, 314);
            this.lstNumConta.TabIndex = 4;
            this.lstNumConta.Text = "listBoxAdv2";
            // 
            // PesquisarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(558, 425);
            this.Controls.Add(this.lblNumConta);
            this.Controls.Add(this.lstNumConta);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lstNome);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PesquisarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisarClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtPesquisar;
        private DevComponents.DotNetBar.ButtonX btnPesquisar;
        private DevComponents.DotNetBar.ListBoxAdv lstNome;
        private DevComponents.DotNetBar.LabelX lblNome;
        private DevComponents.DotNetBar.LabelX lblNumConta;
        private DevComponents.DotNetBar.ListBoxAdv lstNumConta;
    }
}
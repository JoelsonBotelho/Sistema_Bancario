namespace BFHJL
{
    partial class ListaClientes
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
            this.lstListaNomes = new DevComponents.DotNetBar.ListBoxAdv();
            this.lstListaNumConta = new DevComponents.DotNetBar.ListBoxAdv();
            this.lblNomes = new DevComponents.DotNetBar.LabelX();
            this.lblNumConta = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // lstListaNomes
            // 
            this.lstListaNomes.AutoScroll = true;
            // 
            // 
            // 
            this.lstListaNomes.BackgroundStyle.Class = "ListBoxAdv";
            this.lstListaNomes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstListaNomes.ContainerControlProcessDialogKey = true;
            this.lstListaNomes.DragDropSupport = true;
            this.lstListaNomes.Location = new System.Drawing.Point(2, 67);
            this.lstListaNomes.Name = "lstListaNomes";
            this.lstListaNomes.Size = new System.Drawing.Size(222, 363);
            this.lstListaNomes.TabIndex = 0;
            this.lstListaNomes.Text = "listBoxAdv1";
            // 
            // lstListaNumConta
            // 
            this.lstListaNumConta.AutoScroll = true;
            // 
            // 
            // 
            this.lstListaNumConta.BackgroundStyle.Class = "ListBoxAdv";
            this.lstListaNumConta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstListaNumConta.ContainerControlProcessDialogKey = true;
            this.lstListaNumConta.DragDropSupport = true;
            this.lstListaNumConta.Location = new System.Drawing.Point(230, 67);
            this.lstListaNumConta.Name = "lstListaNumConta";
            this.lstListaNumConta.Size = new System.Drawing.Size(222, 363);
            this.lstListaNumConta.TabIndex = 1;
            this.lstListaNumConta.Text = "listBoxAdv1";
            // 
            // lblNomes
            // 
            // 
            // 
            // 
            this.lblNomes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNomes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomes.Location = new System.Drawing.Point(13, 12);
            this.lblNomes.Name = "lblNomes";
            this.lblNomes.Size = new System.Drawing.Size(211, 49);
            this.lblNomes.Symbol = "";
            this.lblNomes.TabIndex = 2;
            this.lblNomes.Text = "Nomes:";
            // 
            // lblNumConta
            // 
            // 
            // 
            // 
            this.lblNumConta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNumConta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumConta.Location = new System.Drawing.Point(230, 12);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(222, 49);
            this.lblNumConta.Symbol = "";
            this.lblNumConta.TabIndex = 3;
            this.lblNumConta.Text = "Números De Contas";
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(453, 432);
            this.Controls.Add(this.lblNumConta);
            this.Controls.Add(this.lblNomes);
            this.Controls.Add(this.lstListaNumConta);
            this.Controls.Add(this.lstListaNomes);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Geral de Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ListBoxAdv lstListaNomes;
        private DevComponents.DotNetBar.ListBoxAdv lstListaNumConta;
        private DevComponents.DotNetBar.LabelX lblNomes;
        private DevComponents.DotNetBar.LabelX lblNumConta;
    }
}
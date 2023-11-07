namespace BFHJL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblControle = new DevComponents.DotNetBar.LabelX();
            this.btnCadastro = new DevComponents.DotNetBar.ButtonX();
            this.btnLista = new DevComponents.DotNetBar.ButtonX();
            this.btnPesquisar = new DevComponents.DotNetBar.ButtonX();
            this.btnTransferencia = new DevComponents.DotNetBar.ButtonX();
            this.btnConsulta = new DevComponents.DotNetBar.ButtonX();
            this.btnDeposito = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lblControle
            // 
            // 
            // 
            // 
            this.lblControle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.lblControle, "lblControle");
            this.lblControle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblControle.Name = "lblControle";
            this.lblControle.Symbol = "";
            // 
            // btnCadastro
            // 
            this.btnCadastro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCadastro.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            resources.ApplyResources(this.btnCadastro, "btnCadastro");
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCadastro.Symbol = "59376";
            this.btnCadastro.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnLista
            // 
            this.btnLista.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLista.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            resources.ApplyResources(this.btnLista, "btnLista");
            this.btnLista.Name = "btnLista";
            this.btnLista.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLista.Symbol = "";
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPesquisar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPesquisar.Symbol = "";
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTransferencia.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            resources.ApplyResources(this.btnTransferencia, "btnTransferencia");
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTransferencia.Symbol = "";
            // 
            // btnConsulta
            // 
            this.btnConsulta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConsulta.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            resources.ApplyResources(this.btnConsulta, "btnConsulta");
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConsulta.Symbol = "";
            // 
            // btnDeposito
            // 
            this.btnDeposito.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeposito.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            resources.ApplyResources(this.btnDeposito, "btnDeposito");
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeposito.Symbol = "57539";
            this.btnDeposito.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lblControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblControle;
        private DevComponents.DotNetBar.ButtonX btnCadastro;
        private DevComponents.DotNetBar.ButtonX btnLista;
        private DevComponents.DotNetBar.ButtonX btnPesquisar;
        private DevComponents.DotNetBar.ButtonX btnTransferencia;
        private DevComponents.DotNetBar.ButtonX btnConsulta;
        private DevComponents.DotNetBar.ButtonX btnDeposito;
    }
}


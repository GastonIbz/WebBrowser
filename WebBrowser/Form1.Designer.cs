
namespace WebBrowser
{
    partial class Navegador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegador));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAtras = new System.Windows.Forms.ToolStripButton();
            this.btnAdelante = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.txturl = new System.Windows.Forms.ToolStripTextBox();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.cmbFavoritos = new System.Windows.Forms.ToolStripComboBox();
            this.btnFavorito = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtras,
            this.btnAdelante,
            this.btnActualizar,
            this.btnStop,
            this.btnHome,
            this.txturl,
            this.btnGo,
            this.cmbFavoritos,
            this.btnFavorito});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAtras
            // 
            this.btnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(23, 22);
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdelante.Image = ((System.Drawing.Image)(resources.GetObject("btnAdelante.Image")));
            this.btnAdelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(23, 22);
            this.btnAdelante.Text = "Adelante";
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "Detener";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(23, 22);
            this.btnHome.Text = "Inicio";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txturl
            // 
            this.txturl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(480, 25);
            this.txturl.Click += new System.EventHandler(this.txturl_Click);
            // 
            // btnGo
            // 
            this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(23, 22);
            this.btnGo.Text = "toolStripButton1";
            this.btnGo.ToolTipText = "Ir";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cmbFavoritos
            // 
            this.cmbFavoritos.Name = "cmbFavoritos";
            this.cmbFavoritos.Size = new System.Drawing.Size(121, 25);
            this.cmbFavoritos.SelectedIndexChanged += new System.EventHandler(this.cmbFavoritos_SelectedIndexChanged);
            // 
            // btnFavorito
            // 
            this.btnFavorito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFavorito.Image = ((System.Drawing.Image)(resources.GetObject("btnFavorito.Image")));
            this.btnFavorito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavorito.Name = "btnFavorito";
            this.btnFavorito.Size = new System.Drawing.Size(23, 22);
            this.btnFavorito.Text = "Favoritos";
            this.btnFavorito.ToolTipText = "Favoritos";
            this.btnFavorito.Click += new System.EventHandler(this.btnFavorito_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(784, 425);
            this.webBrowser1.TabIndex = 1;
            // 
            // Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Navegador";
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.Navegador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAtras;
        private System.Windows.Forms.ToolStripButton btnAdelante;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripTextBox txturl;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripComboBox cmbFavoritos;
        private System.Windows.Forms.ToolStripButton btnFavorito;
    }
}


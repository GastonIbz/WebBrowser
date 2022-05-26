using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Navegador : Form
    {
        List<string> Favoritos = new List<string>();
        public Navegador()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void txturl_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txturl.Text);
        }

        private void btnFavorito_Click(object sender, EventArgs e)
        {
            Favoritos.Add(webBrowser1.Url.ToString());
            actualizarcmb();
        }
        private void actualizarcmb()
        {
            foreach(string direccion in Favoritos)
            {
                cmbFavoritos.Items.Add(direccion);

            }
        }

        private void cmbFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cmbFavoritos.SelectedItem.ToString());
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}

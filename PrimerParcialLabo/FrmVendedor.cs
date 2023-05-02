using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Biblioteca;
namespace PrimerParcialLabo
{
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            SubMenuVisibility();

        }

        private void SubMenuVisibility()
        {
            if (panelSubmenuVenta.Visible == true)
            {
                panelSubmenuVenta.Visible = false;
            }
            if (panelSubMenuModif.Visible == true)
            {
                panelSubMenuModif.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubmenuVenta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuModif);
        }

        private void picBEscape_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picbMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

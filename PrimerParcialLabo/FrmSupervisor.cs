﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLabo
{
    public partial class FrmSupervisor : Form
    {
        public FrmSupervisor()
        {
            InitializeComponent();
        }

        private void FrmSupervisor_Load(object sender, EventArgs e)
        {
            SubMenuVisibility();
        }
        private void SubMenuVisibility()
        {
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

        private void btnModificaciones_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuModif);
        }

        private void pictureBEscape_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSair_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            formCadastroCliente cliente = new formCadastroCliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            RightPanel.Controls.Clear();
            RightPanel.Controls.Add(cliente);
            cliente.Show();

            panelActive.Top = btnClientes.Top;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            RightPanel.Controls.Clear();
            panelActive.Top = btnInicio.Top;

        }

    }
}

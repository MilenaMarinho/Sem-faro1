using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMÁFARO
{
    public partial class Form1 : Form
    {
        private Semaforo semaf;
        public Form1()
        {
            InitializeComponent();
            this.semaf = new Semaforo();
            atualizaInterface();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.semaf.setVermelho(int.Parse(txtRua.Text));
            atualizaInterface();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.semaf.setAmarelo(int.Parse(txtRua.Text));
            atualizaInterface();

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.semaf.setVerde(int.Parse(txtRua.Text));
            atualizaInterface();
        }

        private void atualizaInterface()
        {

            lblRua1.Text = this.semaf.getEstado(1).ToString();
            lblRua2.Text = this.semaf.getEstado(2).ToString();

            picRua1.Image =
                (this.semaf.getEstado(1) == 1) ? Properties.Resources.GREEN :
                (this.semaf.getEstado(2) == 2) ? Properties.Resources.YELLOW :
                Properties.Resources.RED;

            picRua2.Image =
                (this.semaf.getEstado(1) == 1) ? Properties.Resources.GREEN :
                (this.semaf.getEstado(2) == 2) ? Properties.Resources.YELLOW :
                Properties.Resources.RED;

            lblEstado.Text = this.semaf.getEstado().ToString();
        }

        private void picRua2_Click(object sender, EventArgs e)
        {

        }

        private void picRua1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visuale_rpg
{
    public partial class Form1 : Form
    {
        int _indice;
        protected int indice { get { return _indice; } set { _indice = value > 2 ? 0 : (value < 0 ? 2 : value); } }
        List<string> immagini = new List<string>();
        public Form1()
        {
            InitializeComponent();
            immagini.Add("Veigar.png");
            immagini.Add("Aatrox.png");
            immagini.Add("Soraka.png");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnRightArrow_Click(object sender, EventArgs e)
        {
            indice++;
            pbPersonaggio.Image =  Image.FromFile(immagini[indice]);
        }

        private void btnLeftArrow_Click(object sender, EventArgs e)
        {
            indice--;
            pbPersonaggio.Image = Image.FromFile(immagini[indice]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (indice)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

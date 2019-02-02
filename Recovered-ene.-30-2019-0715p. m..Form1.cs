using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG2
{
    public partial class Form1 : Form
    {
        string ruta = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = OpenFileDialog.FileName;
                lblRuta.Text = ruta;

            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL == 'C:/Users/Elena/Desktop\8C\graficacion\PG_1\Daft Punk - Instant Crush (Video) ft. Julian Casab(360P)';
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
    }
}

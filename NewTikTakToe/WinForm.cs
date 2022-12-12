using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTikTakToe
{
    public partial class WinForm : Form
    {
        public string winMarker;
        public WinForm(string marker)
        {
            winMarker = marker;
            InitializeComponent();
            if (marker == "O")
            {
                this.BackgroundImage = new Bitmap(@"C:\Users\aikat\OneDrive\Рабочий стол\NewTikTakToe\image (3).png");
            }
            else
            {
                this.BackgroundImage = new Bitmap(@"C:\Users\aikat\OneDrive\Рабочий стол\NewTikTakToe\image (4).png");
            }
            if (marker == "")
            {
                this.BackgroundImage = new Bitmap(@"C:\Users\aikat\OneDrive\Рабочий стол\NewTikTakToe\image (8).png");
            }    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerForm playerForm = new PlayerForm();
            playerForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WinForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void WinForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class MasterForm : Form
    {
        
        public MasterForm()
        {
            InitializeComponent();
            this.Size = new Size(820, 500);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerForm playerForm = new PlayerForm();
            playerForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {

        }
    }
}

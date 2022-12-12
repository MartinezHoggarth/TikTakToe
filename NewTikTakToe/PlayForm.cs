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
    public partial class PlayForm : Form
    {
        public string marker;
        List<Button> buttons = new List<Button>();
        public string winmarker;

        public PlayForm(string marker)
        {
            winmarker = marker;
            InitializeComponent();
            Width = 800;
            Height = 640;
            ButtonMaker();
            label2.Text = marker;
        }
        
        
        
        void ButtonMaker()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons.Add(new Button { Size = new Size(200, 200), Location = new Point(i * 200, j * 200), TabStop = false, Font = new Font("Broadway", 120) });
                    buttons[buttons.Count - 1].Click += ButtonClick;
                    Controls.Add(buttons[buttons.Count - 1]);
                }

            }

        }
        
        bool CheckWin()
        {
            for (int i = 0; i < 9; i += 3)
            {
                if (buttons[i].Text == buttons[i + 1].Text && buttons[i].Text == buttons[i + 2].Text && buttons[i].Text != "")
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i].Text == buttons[i + 3].Text && buttons[i].Text == buttons[i + 6].Text && buttons[i].Text != "")
                {
                    return true;
                }
            }
            if (buttons[0].Text == buttons[4].Text && buttons[4].Text == buttons[8].Text && buttons[0].Text != "")
            {
                return true;
            }
            if (buttons[2].Text == buttons[4].Text && buttons[4].Text == buttons[6].Text && buttons[2].Text != "")
            {
                return true;
            }
            return false;
            
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            var temp = 0;
            var toButton = sender as Button;
            toButton.Text = marker;
            toButton.Click -= ButtonClick;
            if (CheckWin())
            {
                WinForm winForm = new WinForm(marker);
                winForm.Show();
                this.Close();
                foreach (Button item in buttons)
                {
                    item.Click -= ButtonClick;
                }

            }
            for (int i = 0; i < 8; i++)
            {
                
               if(buttons[i].Text != "")
               {
                  temp++;
               }

            }
            if (temp == 8)
            {
                marker = "";
                WinForm win = new WinForm(marker);
                win.ShowDialog();
                this.Close();
                
            }
            
            marker = marker == "X" ? "O" : "X";
            label2.Text = marker;
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

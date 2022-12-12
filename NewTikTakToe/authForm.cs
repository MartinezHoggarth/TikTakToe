using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NewTikTakToe
{
    public partial class authForm : Form
    {
        public SqlConnection sqlConnection { get; set; }
        private static string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dataBase1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<string[]> users = new List<string[]>();
        string query = "SELECT * FROM users";
        public authForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
            updateData();
        }
        public void updateData()
        {
            users.Clear();
            comboBox1.Items.Clear();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                users.Add(new string[3]);
                users[users.Count - 1][0] = sqlDataReader[0].ToString();
                users[users.Count - 1][1] = sqlDataReader[1].ToString();
                users[users.Count - 1][2] = sqlDataReader[2].ToString();
            }
            sqlDataReader.Close();
            for (int i = 0; i < users.Count; i++)
            {
                comboBox1.Items.Add(users[i][1].ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int ind = comboBox1.SelectedIndex;
            if (textBox2.Text == users[ind][2].ToString())
            {
                MasterForm form = new MasterForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пароль неверный!");
            }
        }

        private void authForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            regForm form = new regForm(this);
            if (form.ShowDialog() == DialogResult.OK)
            {
                updateData();
            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

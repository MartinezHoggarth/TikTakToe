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
    public partial class regForm : Form
    {
        public SqlConnection sqlConnection { get; set; }

        string query = "INSERT INTO [users] (login,password) VALUES (@login,@password)";
        public regForm(authForm form)
        {
            InitializeComponent();
            sqlConnection = form.sqlConnection;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.Add("login", textBox1.Text);
            cmd.Parameters.Add("password", textBox2.Text);
            cmd.ExecuteNonQuery();
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void regForm_Load(object sender, EventArgs e)
        {

        }
    }
}

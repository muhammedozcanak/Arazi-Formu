using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AraziTakip
{
    public partial class giris : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public giris()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\AraziDB.mdb";
        }
        double i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 0.4;
            if (i==0.4)
            {
                pictureBox1.Image = ımageList1.Images[1];
            }
            if (i==0.8)
            {
                anasayfa anasayfa = new anasayfa();
                anasayfa.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            OleDbCommand command = new OleDbCommand("Select *from admin where user=@u and pass=@p", connection);
            command.Parameters.AddWithValue("@u", User.Text);
            command.Parameters.AddWithValue("@p", Pass.Text);
            OleDbDataReader DR = command.ExecuteReader();
            if (DR.Read())
            {
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Close();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Image = ımageList1.Images[0];
            Pass.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Pass.PasswordChar = '\0';
            }
            else
            {
                Pass.PasswordChar = '*';
            }
        }
    }
}


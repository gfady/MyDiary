using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Diary
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRegistrarion();
        }

        private void registration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserRegistrarion();
            }
        }
        private void UserRegistrarion()
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (login.Length == 0 || password.Length==0)
            {
                MessageBox.Show("Не все данные введены", "Ошибка");
            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO [users] (login, password) VALUES  (N'{login}','{password}')", connection);
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Регистрация прошла успешно!");
                        textBox1.Clear();
                        textBox2.Clear();
                        Form1 form1 = new Form1();
                        form1.Show();
                        Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }
    }
}

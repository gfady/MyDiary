using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Diary
{
    public partial class Autorization : Form
    {
        public static int count = 0;// счетчик для фиксирования количества попыток

        public Autorization()
        {
            InitializeComponent();
        }

        private void Autorization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Close();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                UserAuthorization();
            }
        }

        private void UserAuthorization ()
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            if (login.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Не все данные введены!", "Ошибка");

            }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT count(*) FROM [users] WHERE login = '" + login + "' AND password = '" + password + "' ", connection);

                int i = Convert.ToInt32(command.ExecuteScalar());
                if (i == 1)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    Close();
                }
                else
                {
                    while (i == 0)
                    {
                        MessageBox.Show("Неверный логин и пароль!", "Ошибка");
                        count++;
                        break;
                    }

                }
                // у пользователя есть определенное количество попыток ввода логина и пароля
                switch (count)
                {
                    case 2:
                        {
                            MessageBox.Show("Вы ввели неверный логин или пароль 2 раза. У вас осталась одна попытка.", "Предупреждение");
                            break;
                        }
                    case 3:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            } 

        }
        private void button1_Click(object sender, EventArgs e)
        {
            UserAuthorization();
        }

    }
    

}


using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


// TODO: Linq, 
namespace Diary
{
    public partial class Form1 : Form
    {
        SqlConnection connection = null;
        
        public Form1()
        {
            KeyPreview = true;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string date = monthCalendar1.SelectionRange.Start.ToString();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString);
            using (connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Note FROM Notes WHERE Data= '{date}'", connection);
               
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    richTextBox1.Text = reader1[0].ToString();
                }
            }

            using (connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString))
            {
                connection.Open();
                SqlCommand cmd2 = new SqlCommand($"SELECT Notice FROM Notes WHERE Data= '{date}'", connection);
                SqlDataReader reader2;
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    richTextBox2.Text = reader2[0].ToString();
                }
            }

            if (richTextBox1.Text ==null)
            {
                richTextBox1.Text = "На сегодняшний день записей нет";
            }
            if (richTextBox2.Text == null)
            {
                richTextBox2.Text = "На сегодняшний день заметок нет";
            }
        }

        private void Сохранить_Click(object sender, EventArgs e)
        {      
            
            if (richTextBox1.TextLength == 0)
            {
                MessageBox.Show("Вы не ввели никакой записи на этот день", "Ошибка");
            }
            else
            {
                string date = monthCalendar1.SelectionRange.Start.ToString();
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString);
                connection.Open();
                SqlCommand command1_insert = new SqlCommand($"UPDATE Notes SET Note= N'{richTextBox1.Text}', Notice= N'{richTextBox2.Text}'  WHERE Data= '{date}'", connection);

                try
                {
                    if (command1_insert.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись успешно изменена");
                    }
                    else if (command1_insert.ExecuteNonQuery()==0)
                    {
                        connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString);
                        connection.Open();
                        SqlCommand command2_insert = new SqlCommand($"INSERT INTO Notes VALUES ('{date}', N'{richTextBox1.Text}', N'{richTextBox2.Text}')", connection);

                        if(command2_insert.ExecuteNonQuery()==1)
                        {
                            MessageBox.Show("Запись успешно сохранена");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();

            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;

            string date = monthCalendar1.SelectionRange.Start.ToString();

            using (connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString))
            {

                connection.Open();
                SqlCommand command1 = new SqlCommand($"SELECT Note FROM Notes WHERE Data= '{date}'", connection);

                SqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    richTextBox1.Text = reader1[0].ToString();
                }
            }

            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString);
            using (connection)
            {
                connection.Open();
                SqlCommand command2 = new SqlCommand($"SELECT Notice FROM Notes WHERE Data= '{date}'", connection);

                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    richTextBox2.Text = reader2[0].ToString();
                }
            }

            if (richTextBox1.Text.Length == 0)
            {
                richTextBox1.Text = "На этот день пока записей нет";
            }
            if (richTextBox2.Text.Length == 0)
            {
                richTextBox2.Text = "На этот день пока заметок нет";
            }

        }

        private void Очистить_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            string date= monthCalendar1.SelectionRange.Start.ToString();

            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString);
            connection.Open();
            SqlCommand command_delete = new SqlCommand($"DELETE FROM Notes WHERE Data= '{date}'", connection);
            
            try
            {
                if (command_delete.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно удалены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        private void Поиск_Click(object sender, EventArgs e)
        {

            if (richTextBox3.Text != "")
            {
                richTextBox1.Clear();                         
                
                
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["_users"].ConnectionString))
                {
                    string s = richTextBox3.Text.ToLower();
                    connection.Open();
                    SqlCommand command = new SqlCommand($"SELECT * FROM Notes WHERE Note=N'{s}' OR Notice=N'{s}' OR Data=N'{s}'", connection);

                    SqlDataReader reader1 = command.ExecuteReader(); 
                    if (reader1.HasRows)
                    {
                        MessageBox.Show("OK");
                        while (reader1.Read())
                        {
                            object date = reader1.GetValue(0);
                            object note = reader1.GetValue(1);
                            object notice = reader1.GetValue(2);

                            StringBuilder string1 = new StringBuilder("Дата: "+date.ToString()+"\n");
                            string1.AppendLine("Запись: "+note.ToString());
                            string1.AppendLine("Заметка: "+notice.ToString()+ "\n");
                            string string2 = string1.ToString();

                            richTextBox1.Text = string2;
                        }
                    }
                    reader1.Close();

                }
                if (richTextBox1.Text == "")
                {
                    richTextBox1.Text = "По вашему запросу ничего не найдено";
                }
                richTextBox3.Clear();
            }
            else
            {
                MessageBox.Show("Введите поисковый запрос");
            }          

        }
        
        private void справка_Click(object sender, EventArgs e)
        {
            Hide();
            rules rules = new rules();
            rules.Show();
        }
        private void настройки_Click(object sender, EventArgs e)
        {
            settings setting = new settings();
            setting.Show();
            Hide();
        }

        private void изменить_запись_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
        }

        private void Изменить_заметки_Click(object sender, EventArgs e)
        {
            richTextBox2.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

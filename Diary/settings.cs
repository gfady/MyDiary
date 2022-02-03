using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Enabled = true;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // русский
            if (radioButton1.Checked)
            {
                form1.label1.Text = "Сохранить";
                form1.label2.Text = "Отменитть";
                form1.label3.Text = "Изменить записи";
                form1.label4.Text = "Изменить заметки";
                form1.label5.Text = "Очистить";
                form1.label6.Text = "Заметки";
                form1.label7.Text = "Календарь";

                form1.label8.Text = "Записи на этот день";
                form1.Show();
                this.Hide();

            }
            // английский
            if (radioButton2.Checked)
            {
                form1.label1.Text = "Save";
                form1.label2.Text = "Cancel";
                form1.label3.Text = "Change recordings";
                form1.label4.Text = "Change notes";
                form1.label5.Text = "Clear";
                form1.label6.Text = "Notes";
                form1.label7.Text = "Calendar";

                form1.label8.Text = "Recordings for this day";
                form1.Show();
                this.Hide();

            }

            // темная
            if (radioButton3.Checked)
            {
                form1.BackColor = Color.DarkSlateBlue;
                form1.about.BackColor= Color.DarkSlateBlue;
                form1.settings.BackColor = Color.DarkSlateBlue;
                form1.label1.ForeColor = Color.White;
                form1.label2.ForeColor = Color.White;
                form1.label3.ForeColor = Color.White;
                form1.label4.ForeColor = Color.White;
                form1.label5.ForeColor = Color.White;
                form1.label6.ForeColor = Color.White;
                form1.label7.ForeColor = Color.White;
                form1.label8.ForeColor = Color.White;
                form1.Show();
                this.Hide();
            }

            // светлая
            if (radioButton4.Checked)
            {
                form1.BackColor = Color.Thistle;
                form1.about.BackColor = Color.Thistle;
                form1.settings.BackColor = Color.Thistle;
                form1.label1.ForeColor = Color.Black;
                form1.label2.ForeColor = Color.Black;
                form1.label3.ForeColor = Color.Black;
                form1.label4.ForeColor = Color.Black;
                form1.label5.ForeColor = Color.Black;
                form1.label6.ForeColor = Color.Black;
                form1.label7.ForeColor = Color.Black;
                form1.label8.ForeColor = Color.Black;
                form1.Show();
                this.Hide();
            }



            

            if (radioButton1.Checked && radioButton3.Checked)
            {
                form1.BackColor = Color.DarkSlateBlue;
                form1.about.BackColor = Color.DarkSlateBlue;
                form1.settings.BackColor = Color.DarkSlateBlue;
                form1.label1.ForeColor = Color.White;
                form1.label2.ForeColor = Color.White;
                form1.label3.ForeColor = Color.White;
                form1.label4.ForeColor = Color.White;
                form1.label5.ForeColor = Color.White;
                form1.label6.ForeColor = Color.White;
                form1.label7.ForeColor = Color.White;
                form1.label8.ForeColor = Color.White;

                form1.label1.Text = "Сохранить";
                form1.label2.Text = "Отменить";
                form1.label3.Text = "Изменить записи";
                form1.label4.Text = "Изменить заметки";
                form1.label5.Text = "Очистить";
                form1.label6.Text = "Заметки";
                form1.label7.Text = "Календарь";

                form1.label8.Text = "Записи на этот день";
                form1.Show();
                this.Hide();
            }

            if (radioButton1.Checked && radioButton4.Checked)
            {

                form1.BackColor = Color.Thistle;
                form1.about.BackColor = Color.Thistle;
                form1.settings.BackColor = Color.Thistle;
                form1.label1.ForeColor = Color.Black;
                form1.label2.ForeColor = Color.Black;
                form1.label3.ForeColor = Color.Black;
                form1.label4.ForeColor = Color.Black;
                form1.label5.ForeColor = Color.Black;
                form1.label6.ForeColor = Color.Black;
                form1.label7.ForeColor = Color.Black;
                form1.label8.ForeColor = Color.Black;


                form1.label1.Text = "Сохранить";
                form1.label2.Text = "Отменить";
                form1.label3.Text = "Изменить записи";
                form1.label4.Text = "Изменить заметки";
                form1.label5.Text = "Очистить";
                form1.label6.Text = "Заметки";
                form1.label7.Text = "Календарь";

                form1.label8.Text = "Записи на этот день";
                form1.Show();
                this.Hide();
            }

            if (radioButton2.Checked && radioButton4.Checked)
            {

                form1.BackColor = Color.Thistle;
                form1.about.BackColor = Color.Thistle;
                form1.settings.BackColor = Color.Thistle;
                form1.label1.ForeColor = Color.Black;
                form1.label2.ForeColor = Color.Black;
                form1.label3.ForeColor = Color.Black;
                form1.label4.ForeColor = Color.Black;
                form1.label5.ForeColor = Color.Black;
                form1.label6.ForeColor = Color.Black;
                form1.label7.ForeColor = Color.Black;
                form1.label8.ForeColor = Color.Black;


                form1.label1.Text = "Save";
                form1.label2.Text = "Cancel";
                form1.label3.Text = "Change recordings";
                form1.label4.Text = "Change notes";
                form1.label5.Text = "Clear";
                form1.label6.Text = "Notes";
                form1.label7.Text = "Calendar";

                form1.label8.Text = "Recordings for this day";
                form1.Show();
                this.Hide();

            }

            if (radioButton2.Checked && radioButton3.Checked)
            {
                form1.BackColor = Color.DarkSlateBlue;
                form1.about.BackColor = Color.DarkSlateBlue;
                form1.settings.BackColor = Color.DarkSlateBlue;
                form1.label1.ForeColor = Color.White;
                form1.label2.ForeColor = Color.White;
                form1.label3.ForeColor = Color.White;
                form1.label4.ForeColor = Color.White;
                form1.label5.ForeColor = Color.White;
                form1.label6.ForeColor = Color.White;
                form1.label7.ForeColor = Color.White;
                form1.label8.ForeColor = Color.White;


                form1.label1.Text = "Save";
                form1.label2.Text = "Cancel";
                form1.label3.Text = "Change recordings";
                form1.label4.Text = "Change notes";
                form1.label5.Text = "Clear";
                form1.label6.Text = "Notes";
                form1.label7.Text = "Calendar";

                form1.label8.Text = "Recordings for this day";
                form1.Show();
                this.Hide();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

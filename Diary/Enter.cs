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
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            reg.Show();
            Hide();

        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
                Close();

            if (e.KeyCode == Keys.Enter)
                MessageBox.Show("Выберите действие");

        }

        private void Enter_Load(object sender, EventArgs e)
        {

        }
    }
}

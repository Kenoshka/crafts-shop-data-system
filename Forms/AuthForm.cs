using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursovik.Tools;
using Kursovik.Classes;

namespace Kursovik.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginText.Text == "" || passText.Text == "")
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                User user = UserDBHelper.AuthCheck(loginText.Text, passText.Text);
                if (user != null)
                {
                    Main main = new Main(this, user);
                    main.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Данные неверны.");
                }
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
        }
    }
}

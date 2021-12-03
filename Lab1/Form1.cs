using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Input_Click(object sender, EventArgs e)
        {


            if (Login.Text == "Vlad" && Password.Text == "1234")
            {
                Login.BackColor = Color.Green;
                Password.BackColor = Color.Green;
                MessageBox.Show("Привіт Влад");
            }
            else
            {
                Login.BackColor = Color.Red;
                Password.BackColor = Color.Red;
                MessageBox.Show("Невірний логін або пароль!");
            }
        }
    }
}

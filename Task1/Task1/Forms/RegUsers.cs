using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Classes;

namespace Task1
{
    public partial class RegUsers : Form
    {
        private ConcertSystem _concertSystem;

        public RegUsers()
        {
            _concertSystem = new ConcertSystem();
            InitializeComponent();
        }

        private void BttnReg_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string login = textBox2.Text;
            string password = textBox3.Text;

            User newUser = new User() { Name = name, Login = login, Password = password };

            try
            {
                _concertSystem.AddUser(newUser);
                MessageBox.Show("Успешная регистрация", "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

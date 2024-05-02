using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Classes;

namespace Task1.Forms
{
    public partial class Auth : Form
    {
        private ConcertSystem concertSystem;
        private Thread th;
        private User currentUser;

        public Auth()
        {
            InitializeComponent();
            concertSystem = new ConcertSystem();
        }

        private void AuthCloseToA()
        {
            this.Close();
            th = new Thread(AdminOpen);

            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void AdminOpen()
        {
            Application.Run(new Admin());
        }

        private void AuthCloseToP()
        {
            this.Close();
            th = new Thread(AddSongOpen);

            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void AddSongOpen()
        {
            Application.Run(new AddSong(currentUser));
        }

        private void BttnEnter_Click(object sender, EventArgs e)
        {
            currentUser = concertSystem.GetUser(textBox1.Text, textBox2.Text);

            if (currentUser == null)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
                return;
            }

            if (currentUser.Name == "Admin")
            {
                MessageBox.Show("Вы авторизовались как администратор.", "Результат");
                AuthCloseToA();
            }
            else
            {
                MessageBox.Show("Вы авторизовались как пользователь", "Результат");
                AuthCloseToP();
            }
        }

        private void BttnReg_Click(object sender, EventArgs e)
        {
            Form regUs = new RegUsers();
            regUs.Show();
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

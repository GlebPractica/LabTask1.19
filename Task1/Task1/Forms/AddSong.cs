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

namespace Task1.Forms
{
    public partial class AddSong : Form
    {
        private ConcertSystem _concertSystem;
        private User _user;

        public AddSong(User user)
        {
            InitializeComponent();
            _concertSystem = new ConcertSystem();

            _user = user;
        }

        private void BttnEnter_Click(object sender, EventArgs e)
        {
            if (!_concertSystem.IsUserVote(_user))
            {
                try
                {
                    ChkTextBoxs(textBox1, textBox2);

                    Vote vote = new Vote() { UserID = _user.UserID, Song = textBox1.Text, Singer = textBox2.Text };

                    _concertSystem.AddSongVote(vote);

                    MessageBox.Show("Успешно", "Результат");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Вы уже голосовали.", "Ошибка");
            }
        }

        private void ChkTextBoxs(TextBox textBox1, TextBox textBox2)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                throw new Exception("Пустая строкка в \"Название песни\"");

            if (string.IsNullOrWhiteSpace(textBox2.Text))
                throw new Exception("Пустая строка в \"Автор\"");
        }

        private void BttnCheckResults_Click(object sender, EventArgs e)
        {
            Form results = new OutputResults(_concertSystem.GetTopSongs());
            results.Show();
        }
    }
}

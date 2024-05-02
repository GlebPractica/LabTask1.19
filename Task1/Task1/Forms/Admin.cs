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
    public partial class Admin : Form
    {
        private ConcertSystem _concertSystem;

        public Admin()
        {
            InitializeComponent();
            _concertSystem = new ConcertSystem();
        }

        private void BttnEnter_Click(object sender, EventArgs e)
        {


            ConcertSettings concertSet = new ConcertSettings() { Name = textBox1.Text, TicketPrice = int.Parse(numericUpDown1.Value.ToString()), Venue = textBox2.Text, MaxSongs = int.Parse(numericUpDown2.Value.ToString()) };

            try
            {
                _concertSystem.AddConcert(concertSet);
                MessageBox.Show("Успешно добавлено", "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnCheckResults_Click(object sender, EventArgs e)
        {
            Form results = new OutputResults(_concertSystem.GetTopSongs());
            results.Show();
        }
    }
}

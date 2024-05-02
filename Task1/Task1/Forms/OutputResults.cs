using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1.Forms
{
    public partial class OutputResults : Form
    {
        public OutputResults(List<string> topSongs)
        {
            InitializeComponent();
            FillListBox(topSongs);
        }

        private void FillListBox(List<string> songs)
        {
            if (songs.Count > 0 && songs != null)
            {
                listBox1.DataSource = songs;
            }
            else
            {
                MessageBox.Show("Похоже никто не голосовал", "Результат");
            }
        }
    }
}

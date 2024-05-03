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
    public partial class Reflection : Form
    {
        private Reflector reflector;

        public Reflection()
        {
            InitializeComponent();
            reflector = new Reflector();

            openFileDialog1.Filter = "TXT File (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.Filter = "TXT File (*.txt)|*.txt|All Files (*.*)|*.*";
        }

        public void TestMethod(string M)
        {
            MessageBox.Show($"Hello {M}");
        }

        private void BttnSaveMemCl_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                string filePath = saveFileDialog1.FileName;

                reflector.SaveMembersConcertSystemToFile(textBox1.Text, filePath);

                MessageBox.Show($"Успешно сохранено по пути: {filePath}", "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnPubMeth_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                List<string> methods = reflector.ExtrPublicMethods(textBox1.Text);

                foreach (string method in methods)
                {
                    listBox1.Items.Add(method);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnFieldsAndProp_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                List<string> fieProp = reflector.GetFieldsAndProps(textBox1.Text);

                foreach (string fie in fieProp)
                {
                    listBox1.Items.Add(fie);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnInterfaces_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                List<string> inter = reflector.GetInterfaces(textBox1.Text);

                foreach (string interf in inter)
                {
                    listBox1.Items.Add(interf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnMethWithPar_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                Type selectedType = comboBox1.SelectedItem as Type;

                List<string> methWP = reflector.GetMethodsWithParam(textBox1.Text, selectedType);

                foreach (string item in methWP)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnExeMeth_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                string filePath = openFileDialog1.FileName;

                reflector.ExecMethodFromFile(textBox1.Text, textBox2.Text, filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void Reflection_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add(typeof(int));
            comboBox1.Items.Add(typeof(string));
            comboBox1.Items.Add(typeof(double));

            comboBox1.SelectedIndex = 0;
        }
    }
}

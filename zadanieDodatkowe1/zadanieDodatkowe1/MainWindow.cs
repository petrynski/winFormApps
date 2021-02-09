using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanieDodatkowe1
{
    public partial class MainWindow : Form
    {
        public void twojStary(object sender, EventArgs e)
        {

        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(keyWordInput.Text))
                keyWordList.Items.Add(keyWordInput.Text.Trim());
            keyWordInput.ResetText();
        }

        private void keyWordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == (char)Keys.Return)
            {
                button1_Click(sender, e);
                e.Handled = true;
            }
        }

        private void customTestBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                bool thereIsForbiddenWord = false;
                string[] wordList = textBox1.Text.Split(' ');
                foreach (ListViewItem keyWord in keyWordList.Items)
                    keyWord.BackColor = Color.Snow;

                foreach (string word in wordList)
                {
                    foreach (ListViewItem keyWord in keyWordList.Items)
                    {
                        if (word.Equals(keyWord.Text.ToString()))
                        {
                            keyWord.BackColor = Color.Red;
                            thereIsForbiddenWord = true;
                        }
                    }
                }
                if (thereIsForbiddenWord)
                    MessageBox.Show("Words used in text are forbidden!", "Warning!");
            }
        }

    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace NDPHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void fontDialog1_Apply(object sender, EventArgs e)
        {
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox txtBox1 = this.ActiveControl as TextBox;
            if (richTextBox1.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, richTextBox1.SelectedText);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            openFileDialog1.Title = "Open File";
            openFileDialog1.InitialDirectory = @"C:\";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                // Open the selected file using the default application
                Process.Start(filePath);
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();

           Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.InitialDirectory = @"C:\";

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                MessageBox.Show("File saved successfully!");
            }
        }

       

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Yazı tepi değiştirmek.
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Text rengi değiştirmek.
            ColorDialog colorDialog1 = new ColorDialog();
            
            if (colorDialog1.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void groundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color; // Background rengi değiştirmek.
                richTextBox1.BackColor = colorDialog1.Color; // Rich Text Box background rengi değiştirmek.
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox txtBox1 = this.ActiveControl as TextBox;
            if(richTextBox1.SelectedText !=string.Empty)
                Clipboard.SetData(DataFormats.Text,richTextBox1.SelectedText);
            richTextBox1.SelectedText = string.Empty;
        }

        private void paseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TextBox txtBox1 = this.ActiveControl as TextBox;
            if (richTextBox1.SelectedText != string.Empty)// Rich Text Box boş olmama şartı.
                Clipboard.SetData(DataFormats.Text, richTextBox1.SelectedText);//Click yaptığımız texti kopyalamak.
            richTextBox1.SelectedText = string.Empty; 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            TextBox txtBox1 = this.ActiveControl as TextBox;
            if (richTextBox1.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, richTextBox1.SelectedText); // Click yaptığımız texti yapıştırmak.
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void gitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Maryahijaz/NDPHomework1");

        }
    }
    
}


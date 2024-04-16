using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtistHelper
{
    public partial class Form1 : Form
    {
        private struct ImageFile
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_OpenFolder_Click(object sender, EventArgs e)
        {

        }
        private void button_ShowPictureClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openFileDialog1.FileName);
                // Add string URL = pictureBox1.Load()

        }

        private void button_ClearPictureClick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button_SetBackgroundColorClick(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void button_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_Stretch(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

    }
}

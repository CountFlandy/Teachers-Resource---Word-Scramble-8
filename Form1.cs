using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadisonWordScramble_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnScramble_Click(object sender, EventArgs e)
        {
            string Word1 = txtBoxInput1.Text;
            string Word2 = txtBoxInput2.Text;
            string Word3 = txtBoxInput3.Text;
            string Word4 = txtBoxInput4.Text;
            string Word5 = txtBoxInput5.Text;
            string Word6 = txtBoxInput6.Text;
            string Word7 = txtBoxInput7.Text;
            string Word8 = txtBoxInput8.Text;

            Random rand = new Random();
            var output = new string(Word1.OrderBy(x => rand.Next()).ToArray());
            var output2 = new string(Word2.OrderBy(x => rand.Next()).ToArray());
            var output3 = new string(Word3.OrderBy(x => rand.Next()).ToArray());
            var output4 = new string(Word4.OrderBy(x => rand.Next()).ToArray());
            var output5 = new string(Word5.OrderBy(x => rand.Next()).ToArray());
            var output6 = new string(Word6.OrderBy(x => rand.Next()).ToArray());
            var output7 = new string(Word7.OrderBy(x => rand.Next()).ToArray());
            var output8 = new string(Word8.OrderBy(x => rand.Next()).ToArray());

            txtBoxOutput1.Text = output;
            txtBoxOutput2.Text = output2;
            txtBoxOutput3.Text = output3;
            txtBoxOutput4.Text = output4;
            txtBoxOutput5.Text = output5;
            txtBoxOutput6.Text = output6;
            txtBoxOutput7.Text = output7;
            txtBoxOutput8.Text = output8;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtBoxInput1.Visible = false;
            txtBoxInput2.Visible = false;
            txtBoxInput3.Visible = false;
            txtBoxInput4.Visible = false;
            txtBoxInput5.Visible = false;
            txtBoxInput6.Visible = false;
            txtBoxInput7.Visible = false;
            txtBoxInput8.Visible = false;
        }

        private void btnUnhide_Click(object sender, EventArgs e)
        {
            txtBoxInput1.Visible = true;
            txtBoxInput2.Visible = true;
            txtBoxInput3.Visible = true;
            txtBoxInput4.Visible = true;
            txtBoxInput5.Visible = true;
            txtBoxInput6.Visible = true;
            txtBoxInput7.Visible = true;
            txtBoxInput8.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e) //Used code from https://www.youtube.com/watch?v=cFvo48Ix_Xc for printer code
        {
            txtBoxInput1.Visible = false;
            txtBoxInput2.Visible = false;
            txtBoxInput3.Visible = false;
            txtBoxInput4.Visible = false;
            txtBoxInput5.Visible = false;
            txtBoxInput6.Visible = false;
            txtBoxInput7.Visible = false;
            txtBoxInput8.Visible = false;
            btnPrint.Visible = false;
            btnScramble.Visible = false;
            btnPrintMaster.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            btnPrint.Visible = true;
            btnScramble.Visible = true;
            btnPrintMaster.Visible = true;
            txtBoxInput1.Visible = true;
            txtBoxInput2.Visible = true;
            txtBoxInput3.Visible = true;
            txtBoxInput4.Visible = true;
            txtBoxInput5.Visible = true;
            txtBoxInput6.Visible = true;
            txtBoxInput7.Visible = true;
            txtBoxInput8.Visible = true;
        }

        Bitmap bmp;


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e) //Teacher
        {
            btnPrint.Visible = false;
            btnScramble.Visible = false;
            btnPrintMaster.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            btnPrint.Visible = true;
            btnScramble.Visible = true;
            btnPrintMaster.Visible = true;
        }
    }
}

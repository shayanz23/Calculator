

using System.IO;
using System.Windows.Forms;


using System;
using System.Drawing;
/// <summary>
/// Lab 1 Calculator Application 
/// Author: Shayan Zahedanaraki
/// Date: January 11, 2023; Revision: -
/// Source: Code based on the Intro to Windows Forms (WinForms) in .NET 6 tutorial at: https://www.youtube.com/watch?v=0zLZQesgV5o&t=4100s
/// EXternal Libraries: https://matheval.org/
/// </summary>


namespace Calculator
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// Mainform.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            try
            {
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/img.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                MessageBox.Show("Please put an image here: " + Directory.GetCurrentDirectory() + ", with the name img.jpg", "No image found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Click method for all buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Text == "=")
            {
                try
                {
                    CalculatorLogic calculator = new CalculatorLogic(mainTextBox.Text.ToString());
                    mainTextBox.Text = calculator.Parse();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Incorect format.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (b.Text == "C")
            {
                mainTextBox.Clear();
                memoryTxtBx.Text = "";
            }
            else if (b.Text == "CE")
            {
                mainTextBox.Clear();
            }
            else if (((Button)sender).Text == "<-")
            {
                if (mainTextBox.Text.Length != 0)
                {
                    mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
                }
            }
            else if (b.Text == "1/x")
            {
                mainTextBox.Text += "1/";
            }
            else if (b.Text == "x^2")
            {
                mainTextBox.Text += "^2";
            }
            else if (b.Text == "MC")
            {
                memoryTxtBx.Text = "";
            }
            else if (b.Text == "MR")
            {
                mainTextBox.Text += memoryTxtBx.Text;
            }
            else if (b.Text == "M+")
            {
                memoryTxtBx.Text = mainTextBox.Text;
            }
            else
            {
                mainTextBox.Text += b.Text;
            }
            if (b.Text != "=")
            {
                mainTextBox.SelectionStart = mainTextBox.TextLength;
                mainTextBox.ScrollToCaret();
            }
            else
            {
                mainTextBox.SelectionStart = 0;
                mainTextBox.ScrollToCaret();
            }
        }

        /// <summary>
        /// About screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator\nVersion: 2.1\nBy: Shayan Zahedanaraki");
        }

        /// <summary>
        /// Exit top toolbar button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Keydown method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                button_0.PerformClick();
            }
            else if (e.KeyCode == Keys.D1)
            {
                button_1.PerformClick();
            }
            else if (e.KeyCode == Keys.D2)
            {
                button_2.PerformClick();
            }
            else if (e.KeyCode == Keys.D3)
            {
                button_3.PerformClick();
            }
            else if (e.KeyCode == Keys.D4)
            {
                button_4.PerformClick();
            }
            else if (e.KeyCode == Keys.D5)
            {
                button_5.PerformClick();
            }
            else if (e.Shift && e.KeyCode == Keys.D6)
            {
                button_power.PerformClick();
            }
            else if (e.KeyCode == Keys.D6)
            {
                button_6.PerformClick();
            }
            else if (e.KeyCode == Keys.D7)
            {
                button_7.PerformClick();
            }
            else if (e.Shift && e.KeyCode == Keys.D8)
            {
                button_multiplication.PerformClick();
            }
            else if (e.KeyCode == Keys.D8)
            {
                button_8.PerformClick();
            }
            else if (e.KeyCode == Keys.D9)
            {
                button_9.PerformClick();
            }
            else if (e.Shift && e.KeyCode == Keys.Oemplus)
            {
                button_addition.PerformClick();
            }
            else if (e.KeyCode == Keys.Oemplus)
            {
                button_answer.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                button_back.PerformClick();
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                button_subtraction.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                button_division.PerformClick();
            }
            else if (e.KeyCode == Keys.OemPeriod)
            {
                button_dot.PerformClick();
            }
        }
    }
}
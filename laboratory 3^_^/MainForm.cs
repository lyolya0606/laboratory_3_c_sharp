using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratory_3 {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            GreetingWorker();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            About about = new About(true);
            about.SavingChoice();
            about.ShowDialog();
        }

        private void AskingForClosing(object sender, FormClosingEventArgs e) { 
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit", buttons);
            e.Cancel = result != DialogResult.Yes;

        }

        private void CheckingData() {
            double leftBorder = 0;
            double rightBorder = 0;
            double step = 0;
            //bool isEmptyData = false;

            //if (textBoxForCoefficient.Text == "" || textBoxForLeftBorder.Text == "" ||
            //    textBoxForRightBorder.Text == "" || textBoxForStep.Text == "") {
            //    isEmptyData = true;
            //}

            //if (isEmptyData) {
            //    MessageBox.Show("There are empty fields", "Warning!");
            //}

            try {
                double.Parse(textBoxForCoefficient.Text);
                leftBorder = double.Parse(textBoxForLeftBorder.Text);
                rightBorder = double.Parse(textBoxForRightBorder.Text);
                step = double.Parse(textBoxForStep.Text);
            } catch (FormatException) {
                MessageBox.Show("You entered bad data", "Warning!");
            }

            Check check = new Check();
            if (!check.CheckInterval(leftBorder, rightBorder)) {
                MessageBox.Show("Incorrect interval", "Warning!");
            }

            if (!check.CheckStep(step)) {
                MessageBox.Show("The step must be greater than zero", "Warning!");
            }
        }

        private void ButtonForDrawingClick(object sender, EventArgs e) {
            CheckingData();

        }


        private void TxtToolStripMenuItemClick(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                using (var sr = new StreamWriter(saveFileDialog.FileName)) {
                    sr.WriteLine(textBoxForCoefficient.Text);
                    sr.WriteLine(textBoxForLeftBorder.Text);
                    sr.WriteLine(textBoxForRightBorder.Text);
                    sr.WriteLine(textBoxForStep.Text);
                }
                MessageBox.Show("File was saved!", "Saving!");
            } else {
                MessageBox.Show("File was not saved!", "Warning!");
            }
        }

        private void chart1_Click(object sender, EventArgs e) {

        }
    }
}

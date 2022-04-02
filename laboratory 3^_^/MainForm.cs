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
            double leftBorder = 0;
            double rightBorder = 0;
            double step = 0;
            bool stop = true;

            try {
                double.Parse(textBoxForCoefficient.Text);
                leftBorder = double.Parse(textBoxForLeftBorder.Text);
                rightBorder = double.Parse(textBoxForRightBorder.Text);
                step = double.Parse(textBoxForStep.Text);
            }
            catch (FormatException) {
                stop = false;
            }

            Check check = new Check();
            if (!check.CheckInterval(leftBorder, rightBorder)) {
                stop = false;
            }

            if (!check.CheckStep(step)) {
                stop = false;
            }
            if (stop == false) {
                txtToolStripMenuItem.Enabled = false;
                excelToolStripMenuItem.Enabled = false;
            }
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

        private bool CheckingData() {
            double leftBorder;
            double rightBorder;
            double step;
            bool stop = true;

            try {
                double.Parse(textBoxForCoefficient.Text);
                leftBorder = double.Parse(textBoxForLeftBorder.Text);
                rightBorder = double.Parse(textBoxForRightBorder.Text);
                step = double.Parse(textBoxForStep.Text);
            } catch (FormatException) {
                MessageBox.Show("You entered bad data", "Warning!");
                stop = false;
                return stop;
            }

            Check check = new Check();
            if (!check.CheckInterval(leftBorder, rightBorder)) {
                MessageBox.Show("Incorrect interval", "Warning!");
                stop = false;
                return stop;
            }

            if (!check.CheckStep(step)) {
                MessageBox.Show("The step must be greater than zero", "Warning!");
                stop = false;
                return stop;
            }
            return stop;
        }

        private void ButtonForDrawingClick(object sender, EventArgs e) {
            if (!CheckingData()) return;
            double coefficient = double.Parse(textBoxForCoefficient.Text);
            double leftBorder = double.Parse(textBoxForLeftBorder.Text);
            double rightBorder = double.Parse(textBoxForRightBorder.Text);
            double step = double.Parse(textBoxForStep.Text);
            WitchOfAgnesi witchOfAgnesi = new WitchOfAgnesi(coefficient, leftBorder,
                rightBorder, step);
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();

            for (double x = leftBorder; x < rightBorder; x += step) {
                chart.Series[0].Points.AddXY(x, witchOfAgnesi.CountingFunction(x));
            }

            if (witchOfAgnesi.IsSpecialSituation()) {
                chart.Series[1].Points.AddXY(0.0, 0.0);
            }
        }


        private void TxtToolStripMenuItemClick(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog() {
                InitialDirectory = @"C:\Users\lyolya\source\repos\laboratory 3^_^\laboratory 3^_^\bin\Debug"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                using (var sr = new StreamWriter(saveFileDialog.FileName)) {
                    sr.WriteLine(textBoxForCoefficient.Text);
                    sr.WriteLine(textBoxForLeftBorder.Text);
                    sr.WriteLine(textBoxForRightBorder.Text);
                    sr.WriteLine(textBoxForStep.Text);
                }
                MessageBox.Show("File was successfully saved!", "Saving!");
            }
            else {
                MessageBox.Show("File was not saved!", "Warning!");
            }
            
        }

        private void ИuttonForDeletingClick(object sender, EventArgs e) {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
        }
    }
}

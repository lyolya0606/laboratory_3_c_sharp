using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace laboratory_3 {
    public partial class MainForm : Form {
        private const int PARAMETERS = 4;
        WitchOfAgnesi witchOfAgnesi;
        public MainForm() {
            InitializeComponent();
            GreetingWorker();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void FileToolStripMenuItemClick(object sender, EventArgs e) {
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
                inputToolStripMenuItem.Enabled = false;
                saveDataToExcelToolStripMenuItem.Enabled = false;
            }

            if (dataGridView1.DataSource == null) {
                saveDataToExcelToolStripMenuItem.Enabled = false;
                outputToolStripMenuItem.Enabled = false;
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
            witchOfAgnesi = new WitchOfAgnesi(coefficient, leftBorder, rightBorder, step);
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();

            foreach (var pair in witchOfAgnesi.GetPairs()) {
                chart.Series[0].Points.AddXY(pair.Key, pair.Value);
            }
            ShowTable();
            inputToolStripMenuItem.Enabled = true;
        }


        private void IntputToolStripMenuItemClick(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog() {
                InitialDirectory = @"C:\Users\lyolya\source\repos\laboratory 3^_^\laboratory 3^_^\bin\Debug"
            };
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                if (saveFileDialog.FileName == @"C:\Users\lyolya\source\repos\laboratory 3^_^\laboratory 3^_^\bin\Debug\CheckBox.txt") {
                    MessageBox.Show("This file cannot be opened!", "Warning!");
                    return;
                }

                using (var sr = new StreamWriter(saveFileDialog.FileName)) {
                    sr.WriteLine(textBoxForCoefficient.Text);
                    sr.WriteLine(textBoxForLeftBorder.Text);
                    sr.WriteLine(textBoxForRightBorder.Text);
                    sr.WriteLine(textBoxForStep.Text);
                }
                MessageBox.Show("File was successfully saved!", "Saving!");
            } else {
                MessageBox.Show("File was not saved!", "Warning!");
            }
            
        }

        private void ButtonForDeletingClick(object sender, EventArgs e) {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            dataGridView1.DataSource = null;
            outputToolStripMenuItem.Enabled = false;
            saveDataToExcelToolStripMenuItem.Enabled = false;
        }

        private void ReadDataToolStripMenuItemClick(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog() {
                InitialDirectory = @"C:\Users\lyolya\source\repos\laboratory 3^_^\laboratory 3^_^\bin\Debug"
            };
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK) {
                MessageBox.Show("File was not read!", "Warning!");
                return;
            }

            if (openFileDialog.FileName == @"C:\Users\lyolya\source\repos\laboratory 3^_^\laboratory 3^_^\bin\Debug\CheckBox.txt") {
                MessageBox.Show("This file cannot be opened!", "Warning!");
                return;
            }
            using (StreamReader streamReader = new StreamReader(openFileDialog.FileName)) {
                ReadDataFromFile(streamReader);
            }
            CheckingData();
        }

        private void ReadDataFromFile(StreamReader streamReader) {
            List<double> data = new List<double>();
            for (int i = 0; i < PARAMETERS; i++) {
                try {
                    data.Add(double.Parse(streamReader.ReadLine()));
                } catch (FormatException) {
                    MessageBox.Show("File has incorrect data!", "Warning!");
                    return;
                }
            }

            if (data.Count != PARAMETERS) {
                MessageBox.Show("File has incorrect data!", "Warning!");
                return;
            }

            textBoxForCoefficient.Text = data[0].ToString();
            textBoxForLeftBorder.Text = data[1].ToString();
            textBoxForRightBorder.Text = data[2].ToString();
            textBoxForStep.Text = data[3].ToString();
        }

        private void ShowTable() {
            DataTable dotTable = new DataTable();
            dotTable.Columns.Add("X", typeof(double));
            dotTable.Columns.Add("Y", typeof(double));
            foreach (var pair in witchOfAgnesi.pairs) {
                dotTable.Rows.Add(Math.Round(pair.Key, 4), pair.Value);
            }
            dataGridView1.DataSource = dotTable;
            outputToolStripMenuItem.Enabled = true;
            saveDataToExcelToolStripMenuItem.Enabled = true;
        }


        private void OutputToolStripMenuItemClick(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog() {
                InitialDirectory = @"C:\Users\lyolya\source\repos\laboratory 3^_^\laboratory 3^_^\bin\Debug"
            };
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                if (saveFileDialog.FileName == @"C:\Users\lyolya\source\repos\laboratory 3^_^\laboratory 3^_^\bin\Debug\CheckBox.txt") {
                    MessageBox.Show("This file cannot be opened!", "Warning!");
                    return;
                }

                using (var sr = new StreamWriter(saveFileDialog.FileName)) {
                    foreach (var pair in witchOfAgnesi.pairs) {
                        sr.WriteLine(Math.Round(pair.Key, 4) + " " + pair.Value);
                    }
                }
                MessageBox.Show("File was successfully saved!", "Saving!");
            } else {
                MessageBox.Show("File was not saved!", "Warning!");
            }
        }

        private void SaveDataToExcelToolStripMenuItemClick(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog() { 
                InitialDirectory = @"C:\Users\lyolya\source\repos\laboratory 3^_^\laboratory 3^_^\bin\Debug"
            };
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            string filePath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                filePath = saveFileDialog.FileName;
                try {
                    File.Delete(filePath);
                }
                catch (IOException) {
                    MessageBox.Show("This file is opened!", "Warning!");
                    return;
                }
                ExcelWork excelWork = new ExcelWork();
                    if (excelWork.Open(filePath)) {
                        excelWork.SetData("A", 1, "a");
                        excelWork.SetData("B", 1, textBoxForCoefficient.Text);
                        excelWork.SetData("A", 2, "left");
                        excelWork.SetData("B", 2, textBoxForLeftBorder.Text);
                        excelWork.SetData("A", 3, "right");
                        excelWork.SetData("B", 3, textBoxForRightBorder.Text);
                        excelWork.SetData("A", 4, "step");
                        excelWork.SetData("B", 4, textBoxForStep.Text);
                        excelWork.SetData("A", 6, "Y");
                        excelWork.SetData("B", 6, "X");

                        int count = 7;
                        foreach (var pair in witchOfAgnesi.pairs) {
                            excelWork.SetData("A", count, Math.Round(pair.Key, 4).ToString());
                            if (double.IsNaN(pair.Value)) {
                                excelWork.SetData("B", count, "");
                            } else {
                                excelWork.SetData("B", count, pair.Value.ToString());
                            }
                            count++;
                        }

                        excelWork.DrawInExcel(witchOfAgnesi.pairs.Count);                    

                        excelWork.Save();
                    }
                
                MessageBox.Show("Excel was successfully saved!", "Saving!");
            } else {
                MessageBox.Show("File was not saved!", "Warning!");
            }         

        }
    }
    
}

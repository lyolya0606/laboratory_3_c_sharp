using System;
using System.IO;
using System.Windows.Forms;

namespace laboratory_3 {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void GreetingWorker() {
            SavingCheckBox savingCheckBox = new SavingCheckBox();
            bool isAgain = savingCheckBox.ReadCheckBox(); ;

            About about = new About(isAgain);
            if (about.IsAgain) {
                about.Owner = this;
                about.Show();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelForCoefficient = new System.Windows.Forms.Label();
            this.labelForLeftBorder = new System.Windows.Forms.Label();
            this.labelForRightBorder = new System.Windows.Forms.Label();
            this.labelForStep = new System.Windows.Forms.Label();
            this.buttonForDrawing = new System.Windows.Forms.Button();
            this.buttonForDeleting = new System.Windows.Forms.Button();
            this.textBoxForCoefficient = new System.Windows.Forms.TextBox();
            this.textBoxForLeftBorder = new System.Windows.Forms.TextBox();
            this.textBoxForRightBorder = new System.Windows.Forms.TextBox();
            this.textBoxForStep = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1174, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readDataToolStripMenuItem,
            this.saveDataToolStripMenuItem,
            this.saveDataToExcelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItemClick);
            // 
            // readDataToolStripMenuItem
            // 
            this.readDataToolStripMenuItem.Name = "readDataToolStripMenuItem";
            this.readDataToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.readDataToolStripMenuItem.Text = "Read data";
            this.readDataToolStripMenuItem.Click += new System.EventHandler(this.ReadDataToolStripMenuItemClick);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.outputToolStripMenuItem});
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.saveDataToolStripMenuItem.Text = "Save data to txt";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.inputToolStripMenuItem.Text = "Input";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.IntputToolStripMenuItemClick);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.outputToolStripMenuItem.Text = "Output";
            this.outputToolStripMenuItem.Click += new System.EventHandler(this.OutputToolStripMenuItemClick);
            // 
            // saveDataToExcelToolStripMenuItem
            // 
            this.saveDataToExcelToolStripMenuItem.Name = "saveDataToExcelToolStripMenuItem";
            this.saveDataToExcelToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.saveDataToExcelToolStripMenuItem.Text = "Save data to excel";
            this.saveDataToExcelToolStripMenuItem.Click += new System.EventHandler(this.SaveDataToExcelToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // labelForCoefficient
            // 
            this.labelForCoefficient.AutoSize = true;
            this.labelForCoefficient.Location = new System.Drawing.Point(29, 148);
            this.labelForCoefficient.Name = "labelForCoefficient";
            this.labelForCoefficient.Size = new System.Drawing.Size(80, 16);
            this.labelForCoefficient.TabIndex = 2;
            this.labelForCoefficient.Text = "Coefficient a\r\n";
            // 
            // labelForLeftBorder
            // 
            this.labelForLeftBorder.AutoSize = true;
            this.labelForLeftBorder.Location = new System.Drawing.Point(29, 190);
            this.labelForLeftBorder.Name = "labelForLeftBorder";
            this.labelForLeftBorder.Size = new System.Drawing.Size(71, 16);
            this.labelForLeftBorder.TabIndex = 3;
            this.labelForLeftBorder.Text = "Left border\r\n";
            // 
            // labelForRightBorder
            // 
            this.labelForRightBorder.AutoSize = true;
            this.labelForRightBorder.Location = new System.Drawing.Point(29, 234);
            this.labelForRightBorder.Name = "labelForRightBorder";
            this.labelForRightBorder.Size = new System.Drawing.Size(81, 16);
            this.labelForRightBorder.TabIndex = 4;
            this.labelForRightBorder.Text = "Right border";
            // 
            // labelForStep
            // 
            this.labelForStep.AutoSize = true;
            this.labelForStep.Location = new System.Drawing.Point(29, 275);
            this.labelForStep.Name = "labelForStep";
            this.labelForStep.Size = new System.Drawing.Size(35, 16);
            this.labelForStep.TabIndex = 5;
            this.labelForStep.Text = "Step\r\n";
            // 
            // buttonForDrawing
            // 
            this.buttonForDrawing.Location = new System.Drawing.Point(32, 359);
            this.buttonForDrawing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonForDrawing.Name = "buttonForDrawing";
            this.buttonForDrawing.Size = new System.Drawing.Size(108, 45);
            this.buttonForDrawing.TabIndex = 6;
            this.buttonForDrawing.Text = "Show a graph and a table";
            this.buttonForDrawing.UseVisualStyleBackColor = true;
            this.buttonForDrawing.Click += new System.EventHandler(this.ButtonForDrawingClick);
            // 
            // buttonForDeleting
            // 
            this.buttonForDeleting.Location = new System.Drawing.Point(169, 359);
            this.buttonForDeleting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonForDeleting.Name = "buttonForDeleting";
            this.buttonForDeleting.Size = new System.Drawing.Size(118, 45);
            this.buttonForDeleting.TabIndex = 7;
            this.buttonForDeleting.Text = "Delete a graph and a table";
            this.buttonForDeleting.UseVisualStyleBackColor = true;
            this.buttonForDeleting.Click += new System.EventHandler(this.ButtonForDeletingClick);
            // 
            // textBoxForCoefficient
            // 
            this.textBoxForCoefficient.Location = new System.Drawing.Point(162, 146);
            this.textBoxForCoefficient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxForCoefficient.Name = "textBoxForCoefficient";
            this.textBoxForCoefficient.Size = new System.Drawing.Size(125, 22);
            this.textBoxForCoefficient.TabIndex = 9;
            this.textBoxForCoefficient.Text = "2";
            // 
            // textBoxForLeftBorder
            // 
            this.textBoxForLeftBorder.Location = new System.Drawing.Point(162, 188);
            this.textBoxForLeftBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxForLeftBorder.Name = "textBoxForLeftBorder";
            this.textBoxForLeftBorder.Size = new System.Drawing.Size(125, 22);
            this.textBoxForLeftBorder.TabIndex = 10;
            this.textBoxForLeftBorder.Text = "-5";
            // 
            // textBoxForRightBorder
            // 
            this.textBoxForRightBorder.Location = new System.Drawing.Point(162, 231);
            this.textBoxForRightBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxForRightBorder.Name = "textBoxForRightBorder";
            this.textBoxForRightBorder.Size = new System.Drawing.Size(125, 22);
            this.textBoxForRightBorder.TabIndex = 11;
            this.textBoxForRightBorder.Text = "5";
            // 
            // textBoxForStep
            // 
            this.textBoxForStep.Location = new System.Drawing.Point(162, 273);
            this.textBoxForStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxForStep.Name = "textBoxForStep";
            this.textBoxForStep.Size = new System.Drawing.Size(125, 22);
            this.textBoxForStep.TabIndex = 12;
            this.textBoxForStep.Text = "0.1";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(325, 28);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Fuchsia;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            series1.SmartLabelStyle.Enabled = false;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValuesPerPoint = 2;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(438, 399);
            this.chart.TabIndex = 13;
            this.chart.Text = "chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Witch of Agnesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::laboratory_3.Properties.Resources.Witch_of_Agnesi;
            this.pictureBox1.Location = new System.Drawing.Point(162, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(817, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(325, 399);
            this.dataGridView1.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.textBoxForStep);
            this.Controls.Add(this.textBoxForRightBorder);
            this.Controls.Add(this.textBoxForLeftBorder);
            this.Controls.Add(this.textBoxForCoefficient);
            this.Controls.Add(this.buttonForDeleting);
            this.Controls.Add(this.buttonForDrawing);
            this.Controls.Add(this.labelForStep);
            this.Controls.Add(this.labelForRightBorder);
            this.Controls.Add(this.labelForLeftBorder);
            this.Controls.Add(this.labelForCoefficient);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Witch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskingForClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Label labelForCoefficient;
        private Label labelForLeftBorder;
        private Label labelForRightBorder;
        private Label labelForStep;
        private Button buttonForDrawing;
        private Button buttonForDeleting;
        private TextBox textBoxForCoefficient;
        private TextBox textBoxForLeftBorder;
        private TextBox textBoxForRightBorder;
        private TextBox textBoxForStep;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem saveDataToExcelToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}


namespace Tyuiu.BurdovKS.Sprint7.Project.V11
{
    partial class FormGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            openFileDialog = new OpenFileDialog();
            groupBoxGGWP_BKS = new GroupBox();
            buttonSize_BKS = new Button();
            buttonRost = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewBig = new DataGridView();
            groupBoxGGWP_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBig).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // groupBoxGGWP_BKS
            // 
            groupBoxGGWP_BKS.Controls.Add(buttonSize_BKS);
            groupBoxGGWP_BKS.Controls.Add(buttonRost);
            groupBoxGGWP_BKS.Location = new Point(12, 12);
            groupBoxGGWP_BKS.Name = "groupBoxGGWP_BKS";
            groupBoxGGWP_BKS.Size = new Size(776, 112);
            groupBoxGGWP_BKS.TabIndex = 0;
            groupBoxGGWP_BKS.TabStop = false;
            groupBoxGGWP_BKS.Text = "Загрузка данных";
            // 
            // buttonSize_BKS
            // 
            buttonSize_BKS.Location = new Point(87, 22);
            buttonSize_BKS.Name = "buttonSize_BKS";
            buttonSize_BKS.Size = new Size(85, 65);
            buttonSize_BKS.TabIndex = 1;
            buttonSize_BKS.Text = "По размеру ноги";
            buttonSize_BKS.UseVisualStyleBackColor = true;
            buttonSize_BKS.Click += buttonSize_BKS_Click;
            // 
            // buttonRost
            // 
            buttonRost.Location = new Point(6, 22);
            buttonRost.Name = "buttonRost";
            buttonRost.Size = new Size(75, 65);
            buttonRost.TabIndex = 0;
            buttonRost.Text = "По росту";
            buttonRost.UseVisualStyleBackColor = true;
            buttonRost.Click += buttonRost_Click;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(18, 138);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(357, 300);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // dataGridViewBig
            // 
            dataGridViewBig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBig.Location = new Point(381, 138);
            dataGridViewBig.Name = "dataGridViewBig";
            dataGridViewBig.Size = new Size(407, 300);
            dataGridViewBig.TabIndex = 2;
            // 
            // FormGraph
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(dataGridViewBig);
            Controls.Add(chart1);
            Controls.Add(groupBoxGGWP_BKS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormGraph";
            Text = "FormGraph";
            Load += FormGraph_Load;
            groupBoxGGWP_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBig).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private GroupBox groupBoxGGWP_BKS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button buttonRost;
        private DataGridView dataGridViewBig;
        private Button buttonSize_BKS;
    }
}
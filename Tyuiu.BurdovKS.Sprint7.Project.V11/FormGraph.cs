using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.BurdovKS.Sprint7.Project.V11.Lib;
using System.IO;

namespace Tyuiu.BurdovKS.Sprint7.Project.V11
{
    public partial class FormGraph : Form
    {
        public FormGraph()
        {
            InitializeComponent();
        }


        private void buttonRost_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Title = "Выберите CSV файл";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    LoadDataAndDisplayChart(filePath);
                }
            }
        }

        private void LoadDataAndDisplayChart(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                var values = new List<double>();

                foreach (var line in lines)
                {
                    // Предполагаем, что в каждой строке находится один рост
                    if (double.TryParse(line.Trim(), out double value))
                    {
                        values.Add(value);
                    }
                }

                // Настройка DataGridViewBig
                dataGridViewBig.Columns.Clear(); // Очищаем существующие столбцы
                dataGridViewBig.Columns.Add("Рост", "Рост"); // Добавляем новый столбец

                // Заполнение DataGridViewBig
                dataGridViewBig.Rows.Clear(); // Очищаем перед добавлением новых данных
                foreach (var value in values)
                {
                    dataGridViewBig.Rows.Add(value); // Добавляем каждое значение в новую строку
                }

                // Настройка графика
                chart1.Series.Clear();
                var series = new Series("Рост")
                {
                    ChartType = SeriesChartType.Column // Изменяем тип на столбчатую диаграмму
                };
                chart1.Series.Add(series);

                // Добавление данных в график
                for (int i = 0; i < values.Count; i++)
                {
                    series.Points.AddXY(i + 1, values[i]); // Здесь i + 1 для более понятной нумерации
                }

                chart1.Invalidate(); // Обновляем график
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }



        }

        private void buttonSize_BKS_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Title = "Выберите CSV файл";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    ZXCLoadDataAndDisplayChart(filePath);
                }
            }
        }

        private void ZXCLoadDataAndDisplayChart(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                var values = new List<double>();

                foreach (var line in lines)
                {
                    // Предполагаем, что в каждой строке находится один рост
                    if (double.TryParse(line.Trim(), out double value))
                    {
                        values.Add(value);
                    }
                }

                // Настройка DataGridViewBig
                dataGridViewBig.Columns.Clear(); // Очищаем существующие столбцы
                dataGridViewBig.Columns.Add("Размер ноги", "Размер ноги"); // Добавляем новый столбец

                // Заполнение DataGridViewBig
                dataGridViewBig.Rows.Clear(); // Очищаем перед добавлением новых данных
                foreach (var value in values)
                {
                    dataGridViewBig.Rows.Add(value); // Добавляем каждое значение в новую строку
                }

                // Настройка графика
                chart1.Series.Clear();
                var series = new Series("Размер ноги")
                {
                    ChartType = SeriesChartType.Column // Изменяем тип на столбчатую диаграмму
                };
                chart1.Series.Add(series);

                // Добавление данных в график
                for (int i = 0; i < values.Count; i++)
                {
                    series.Points.AddXY(i + 1, values[i]); // Здесь i + 1 для более понятной нумерации
                }

                chart1.Invalidate(); // Обновляем график
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }


        }

        private void buttonSoft_BKS_Click(object sender, EventArgs e)
        {

        }

        private void FormGraph_Load(object sender, EventArgs e)
        {

        }
    }
}


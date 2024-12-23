using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BurdovKS.Sprint7.Project.V11.Lib;



namespace Tyuiu.BurdovKS.Sprint7.Project.V11
{
    public partial class FormUpGradeEditor : Form
    {
        public FormUpGradeEditor()
        {
            InitializeComponent();

        }

        DataService ds = new DataService();
        private void buttonDone_BKS_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";

                openFileDialog.Title = "Выберите CSV файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string csvFilePath = openFileDialog.FileName;
                    LoadCsvData(csvFilePath);
                }
            }
        }
        private void LoadCsvData(string filePath)
        {


            DataTable dataTable = new DataTable();

            // Добавляем столбцы в DataTable
            dataTable.Columns.Add("ФИО");
            dataTable.Columns.Add("Адрес");
            dataTable.Columns.Add("Дата рождения");
            dataTable.Columns.Add("Должность");
            dataTable.Columns.Add("Дата зачисления");
            dataTable.Columns.Add("Стаж работы");
            dataTable.Columns.Add("Размер ноги");
            dataTable.Columns.Add("Образование");
            dataTable.Columns.Add("Рост");
            dataTable.Columns.Add("Цвет глаз");

            // Читаем файл и заполняем DataTable
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    // Проверяем, что количество значений соответствует количеству столбцов
                    if (values.Length == 10)
                    {
                        dataTable.Rows.Add(values);
                    }
                }
            }

            // Привязываем DataTable к DataGridView
            dataGridViewUser.DataSource = dataTable;
        }

        private void buttonSaveUser_BKS_Click(object sender, EventArgs e)
        {


            // создание диалога сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Сохранение таблицы",
                DefaultExt = "csv"
            };

            // если пользователь выбрал файл
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // список стрк для записи в файл
                    List<string> lines = new List<string>();

                    // перебор строк, начиная с индекса 1
                    for (int i = 0; i < dataGridViewUser.Rows.Count; i++)
                    {
                        DataGridViewRow row = dataGridViewUser.Rows[i];

                        // игнорируем новую строку, если она есть
                        if (row.IsNewRow)
                            continue;

                        // собираем данные из ячеек строки, разделяя их точкой с запятой
                        string line = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                        lines.Add(line);
                    }

                    // запись всех строк в файл
                    File.WriteAllLines(filePath, lines);

                    MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



    }
    }



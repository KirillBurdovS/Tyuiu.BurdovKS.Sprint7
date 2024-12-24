

using System.Windows.Forms;
using System;
using System.Data;
using Tyuiu.BurdovKS.Sprint7.Project.V11.Lib;
using System.IO;
namespace Tyuiu.BurdovKS.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int columns;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_BKS_Click(object sender, EventArgs e)
        {










        }

        private void LoadCsvData(string filePath)
        {




        }

        private void buttonSave_BKS_Click(object sender, EventArgs e)
        {


        }

        private void buttonAdd_BKS_Click(object sender, EventArgs e)
        {

        }

        private void buttonPeople_BKS_Click(object sender, EventArgs e)
        {

            FormUpGradeEditor formEdit = new FormUpGradeEditor();
            formEdit.StartPosition = FormStartPosition.Manual;
            formEdit.Location = this.Location;
            formEdit.ShowDialog();


        }

        private void buttonAbout_BKS_Click(object sender, EventArgs e)
        {

            FormAbout formEdit = new FormAbout();
            formEdit.StartPosition = FormStartPosition.Manual;
            formEdit.Location = this.Location;
            formEdit.ShowDialog();


        }

        private void buttonGrap_BKS_Click(object sender, EventArgs e)
        {
            FormGraph formEdit = new FormGraph();
            formEdit.StartPosition = FormStartPosition.Manual;
            formEdit.Location = this.Location;
            formEdit.ShowDialog();

        }
    }
}

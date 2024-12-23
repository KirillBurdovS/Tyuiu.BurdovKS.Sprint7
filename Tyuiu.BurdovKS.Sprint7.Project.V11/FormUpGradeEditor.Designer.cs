namespace Tyuiu.BurdovKS.Sprint7.Project.V11
{
    partial class FormUpGradeEditor
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
            groupBoxDataUser = new GroupBox();
            dataGridViewUser = new DataGridView();
            openFileDialogUser = new OpenFileDialog();
            saveFileDialogUser = new SaveFileDialog();
            buttonDone_BKS = new Button();
            buttonSaveUser_BKS = new Button();
            groupBoxDataUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDataUser
            // 
            groupBoxDataUser.Controls.Add(dataGridViewUser);
            groupBoxDataUser.Location = new Point(12, 79);
            groupBoxDataUser.Name = "groupBoxDataUser";
            groupBoxDataUser.Size = new Size(1114, 445);
            groupBoxDataUser.TabIndex = 0;
            groupBoxDataUser.TabStop = false;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(6, 22);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.Size = new Size(1102, 417);
            dataGridViewUser.TabIndex = 0;
            // 
            // openFileDialogUser
            // 
            openFileDialogUser.FileName = "openFileDialog1";
            // 
            // buttonDone_BKS
            // 
            buttonDone_BKS.Location = new Point(18, 12);
            buttonDone_BKS.Name = "buttonDone_BKS";
            buttonDone_BKS.Size = new Size(75, 61);
            buttonDone_BKS.TabIndex = 1;
            buttonDone_BKS.Text = "Открыть";
            buttonDone_BKS.UseVisualStyleBackColor = true;
            buttonDone_BKS.Click += buttonDone_BKS_Click;
            // 
            // buttonSaveUser_BKS
            // 
            buttonSaveUser_BKS.Location = new Point(108, 12);
            buttonSaveUser_BKS.Name = "buttonSaveUser_BKS";
            buttonSaveUser_BKS.Size = new Size(75, 61);
            buttonSaveUser_BKS.TabIndex = 2;
            buttonSaveUser_BKS.Text = "Сохранить";
            buttonSaveUser_BKS.UseVisualStyleBackColor = true;
            buttonSaveUser_BKS.Click += buttonSaveUser_BKS_Click;
            // 
            // FormUpGradeEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 536);
            Controls.Add(buttonSaveUser_BKS);
            Controls.Add(buttonDone_BKS);
            Controls.Add(groupBoxDataUser);
            Name = "FormUpGradeEditor";
            Text = "FormUpGradeEditor";
            groupBoxDataUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDataUser;
        private DataGridView dataGridViewUser;
        private OpenFileDialog openFileDialogUser;
        private SaveFileDialog saveFileDialogUser;
        private Button buttonDone_BKS;
        private Button buttonSaveUser_BKS;
    }
}
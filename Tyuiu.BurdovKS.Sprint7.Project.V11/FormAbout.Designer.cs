namespace Tyuiu.BurdovKS.Sprint7.Project.V11
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            groupBoxAbout_BKS = new GroupBox();
            pictureBoxAuthor_BKS = new PictureBox();
            textBoxAuthor_BKS = new TextBox();
            groupBoxAbout_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_BKS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAbout_BKS
            // 
            groupBoxAbout_BKS.Controls.Add(textBoxAuthor_BKS);
            groupBoxAbout_BKS.Controls.Add(pictureBoxAuthor_BKS);
            groupBoxAbout_BKS.Location = new Point(12, 12);
            groupBoxAbout_BKS.Name = "groupBoxAbout_BKS";
            groupBoxAbout_BKS.Size = new Size(551, 426);
            groupBoxAbout_BKS.TabIndex = 0;
            groupBoxAbout_BKS.TabStop = false;
            groupBoxAbout_BKS.Text = "Об авторе";
            // 
            // pictureBoxAuthor_BKS
            // 
            pictureBoxAuthor_BKS.Image = (Image)resources.GetObject("pictureBoxAuthor_BKS.Image");
            pictureBoxAuthor_BKS.Location = new Point(16, 42);
            pictureBoxAuthor_BKS.Name = "pictureBoxAuthor_BKS";
            pictureBoxAuthor_BKS.Size = new Size(208, 314);
            pictureBoxAuthor_BKS.TabIndex = 0;
            pictureBoxAuthor_BKS.TabStop = false;
            // 
            // textBoxAuthor_BKS
            // 
            textBoxAuthor_BKS.BackColor = SystemColors.Menu;
            textBoxAuthor_BKS.BorderStyle = BorderStyle.None;
            textBoxAuthor_BKS.Location = new Point(230, 53);
            textBoxAuthor_BKS.Multiline = true;
            textBoxAuthor_BKS.Name = "textBoxAuthor_BKS";
            textBoxAuthor_BKS.Size = new Size(321, 37);
            textBoxAuthor_BKS.TabIndex = 1;
            textBoxAuthor_BKS.Text = "Программу выполнил студент группы СМАРТб 24 -1  Бурдов Кирилл Сергеевич";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(groupBoxAbout_BKS);
            Name = "FormAbout";
            Text = "FormAbout";
            groupBoxAbout_BKS.ResumeLayout(false);
            groupBoxAbout_BKS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor_BKS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAbout_BKS;
        private TextBox textBoxAuthor_BKS;
        private PictureBox pictureBoxAuthor_BKS;
    }
}
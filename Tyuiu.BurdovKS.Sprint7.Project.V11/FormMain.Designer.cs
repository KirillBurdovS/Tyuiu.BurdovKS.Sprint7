namespace Tyuiu.BurdovKS.Sprint7.Project.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxOgl_BKS = new TextBox();
            buttonAbout_BKS = new Button();
            buttonPeople_BKS = new Button();
            buttonGrap_BKS = new Button();
            SuspendLayout();
            // 
            // textBoxOgl_BKS
            // 
            textBoxOgl_BKS.BackColor = SystemColors.Menu;
            textBoxOgl_BKS.BorderStyle = BorderStyle.None;
            textBoxOgl_BKS.ForeColor = SystemColors.MenuHighlight;
            textBoxOgl_BKS.Location = new Point(77, 93);
            textBoxOgl_BKS.Name = "textBoxOgl_BKS";
            textBoxOgl_BKS.Size = new Size(100, 16);
            textBoxOgl_BKS.TabIndex = 0;
            textBoxOgl_BKS.Text = "Главное Меню";
            // 
            // buttonAbout_BKS
            // 
            buttonAbout_BKS.Location = new Point(213, 257);
            buttonAbout_BKS.Name = "buttonAbout_BKS";
            buttonAbout_BKS.Size = new Size(48, 34);
            buttonAbout_BKS.TabIndex = 1;
            buttonAbout_BKS.Text = "?";
            buttonAbout_BKS.UseVisualStyleBackColor = true;
            buttonAbout_BKS.Click += buttonAbout_BKS_Click;
            // 
            // buttonPeople_BKS
            // 
            buttonPeople_BKS.Location = new Point(77, 125);
            buttonPeople_BKS.Name = "buttonPeople_BKS";
            buttonPeople_BKS.Size = new Size(91, 28);
            buttonPeople_BKS.TabIndex = 2;
            buttonPeople_BKS.Text = "Базза Данных";
            buttonPeople_BKS.UseVisualStyleBackColor = true;
            buttonPeople_BKS.Click += buttonPeople_BKS_Click;
            // 
            // buttonGrap_BKS
            // 
            buttonGrap_BKS.Location = new Point(77, 170);
            buttonGrap_BKS.Name = "buttonGrap_BKS";
            buttonGrap_BKS.Size = new Size(91, 23);
            buttonGrap_BKS.TabIndex = 3;
            buttonGrap_BKS.Text = "График";
            buttonGrap_BKS.UseVisualStyleBackColor = true;
            buttonGrap_BKS.Click += buttonGrap_BKS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 297);
            Controls.Add(buttonGrap_BKS);
            Controls.Add(buttonPeople_BKS);
            Controls.Add(buttonAbout_BKS);
            Controls.Add(textBoxOgl_BKS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Спринт 7| Проект |Бурдов Кирилл Сергеевич";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxOgl_BKS;
        private Button buttonAbout_BKS;
        private Button buttonPeople_BKS;
        private Button buttonGrap_BKS;
    }
}

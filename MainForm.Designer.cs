namespace AgendaActivitati
{
    partial class MainForm
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
            activityBtn = new Button();
            newActivity = new GroupBox();
            activityInput = new TextBox();
            activityName = new Label();
            activityList = new ListView();
            idColumn = new ColumnHeader();
            activityColumn = new ColumnHeader();
            tabControl1 = new TabControl();
            activityTab = new TabPage();
            domainTab = new TabPage();
            projectsTab = new TabPage();
            newActivity.SuspendLayout();
            tabControl1.SuspendLayout();
            activityTab.SuspendLayout();
            SuspendLayout();
            // 
            // activityBtn
            // 
            activityBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            activityBtn.BackColor = Color.Green;
            activityBtn.DialogResult = DialogResult.Yes;
            activityBtn.ForeColor = Color.White;
            activityBtn.Location = new Point(557, 113);
            activityBtn.Name = "activityBtn";
            activityBtn.Size = new Size(113, 23);
            activityBtn.TabIndex = 0;
            activityBtn.Text = "Adauga activitate";
            activityBtn.UseVisualStyleBackColor = false;
            activityBtn.Click += activityBtn_Click;
            // 
            // newActivity
            // 
            newActivity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            newActivity.Controls.Add(activityBtn);
            newActivity.Controls.Add(activityInput);
            newActivity.Controls.Add(activityName);
            newActivity.Location = new Point(6, 6);
            newActivity.Name = "newActivity";
            newActivity.Size = new Size(676, 139);
            newActivity.TabIndex = 1;
            newActivity.TabStop = false;
            newActivity.Text = "Activitate noua";
            // 
            // activityInput
            // 
            activityInput.BackColor = Color.White;
            activityInput.ForeColor = SystemColors.InfoText;
            activityInput.Location = new Point(103, 32);
            activityInput.Name = "activityInput";
            activityInput.Size = new Size(100, 23);
            activityInput.TabIndex = 3;
            // 
            // activityName
            // 
            activityName.AutoSize = true;
            activityName.Location = new Point(6, 35);
            activityName.Name = "activityName";
            activityName.Size = new Size(91, 15);
            activityName.TabIndex = 1;
            activityName.Text = "Nume activitate";
            // 
            // activityList
            // 
            activityList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            activityList.BackColor = SystemColors.HighlightText;
            activityList.Columns.AddRange(new ColumnHeader[] { idColumn, activityColumn });
            activityList.GridLines = true;
            activityList.Location = new Point(6, 151);
            activityList.Name = "activityList";
            activityList.Size = new Size(632, 281);
            activityList.TabIndex = 2;
            activityList.UseCompatibleStateImageBehavior = false;
            activityList.View = View.Details;
            // 
            // idColumn
            // 
            idColumn.Text = "Id";
            // 
            // activityColumn
            // 
            activityColumn.Text = "Activitate";
            activityColumn.Width = 100;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(activityTab);
            tabControl1.Controls.Add(domainTab);
            tabControl1.Controls.Add(projectsTab);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(783, 526);
            tabControl1.TabIndex = 3;
            // 
            // activityTab
            // 
            activityTab.Controls.Add(newActivity);
            activityTab.Controls.Add(activityList);
            activityTab.Location = new Point(4, 24);
            activityTab.Name = "activityTab";
            activityTab.Padding = new Padding(3);
            activityTab.Size = new Size(775, 498);
            activityTab.TabIndex = 0;
            activityTab.Text = "Activitati";
            activityTab.UseVisualStyleBackColor = true;
            // 
            // domainTab
            // 
            domainTab.Location = new Point(4, 24);
            domainTab.Name = "domainTab";
            domainTab.Padding = new Padding(3);
            domainTab.Size = new Size(775, 498);
            domainTab.TabIndex = 1;
            domainTab.Text = "Domenii";
            domainTab.UseVisualStyleBackColor = true;
            // 
            // projectsTab
            // 
            projectsTab.Location = new Point(4, 24);
            projectsTab.Name = "projectsTab";
            projectsTab.Padding = new Padding(3);
            projectsTab.Size = new Size(775, 498);
            projectsTab.TabIndex = 2;
            projectsTab.Text = "Proiecte";
            projectsTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 530);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Formular agenda";
            newActivity.ResumeLayout(false);
            newActivity.PerformLayout();
            tabControl1.ResumeLayout(false);
            activityTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button activityBtn;
        private GroupBox newActivity;
        private Label activityName;
        private TextBox activityInput;
        private ListView activityList;
        private ColumnHeader idColumn;
        private ColumnHeader activityColumn;
        private TabControl tabControl1;
        private TabPage activityTab;
        private TabPage domainTab;
        private TabPage projectsTab;
    }
}

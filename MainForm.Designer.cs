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
            components = new System.ComponentModel.Container();
            activityBtn = new Button();
            newActivity = new GroupBox();
            exportTxt = new Button();
            editActivityBtn = new Button();
            deleteBtn = new Button();
            activityInput = new TextBox();
            activityName = new Label();
            activityList = new ListView();
            idColumn = new ColumnHeader();
            activityColumn = new ColumnHeader();
            tabControl1 = new TabControl();
            activityTab = new TabPage();
            domainTab = new TabPage();
            domainList = new ListView();
            idDomain = new ColumnHeader();
            domainName = new ColumnHeader();
            newDomain = new GroupBox();
            btnDeleteDomain = new Button();
            btnEditDomain = new Button();
            btnAddDomain = new Button();
            domainInput = new TextBox();
            domainLabel = new Label();
            projectsTab = new TabPage();
            projectList = new ListView();
            IdProject = new ColumnHeader();
            projectNameCol = new ColumnHeader();
            activityProjectCol = new ColumnHeader();
            domainProjectCol = new ColumnHeader();
            projectBox = new GroupBox();
            cbDomain = new ComboBox();
            cbActivity = new ComboBox();
            btnDeleteProject = new Button();
            btnEditProject = new Button();
            btnAddProject = new Button();
            projectInput = new TextBox();
            idDomainLabel = new Label();
            activityIdLabel = new Label();
            projectLabel = new Label();
            errorProviderAct = new ErrorProvider(components);
            errorProviderDomain = new ErrorProvider(components);
            newActivity.SuspendLayout();
            tabControl1.SuspendLayout();
            activityTab.SuspendLayout();
            domainTab.SuspendLayout();
            newDomain.SuspendLayout();
            projectsTab.SuspendLayout();
            projectBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderAct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDomain).BeginInit();
            SuspendLayout();
            // 
            // activityBtn
            // 
            activityBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            activityBtn.BackColor = Color.Green;
            activityBtn.DialogResult = DialogResult.Yes;
            activityBtn.ForeColor = Color.White;
            activityBtn.Location = new Point(193, 110);
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
            newActivity.Controls.Add(exportTxt);
            newActivity.Controls.Add(editActivityBtn);
            newActivity.Controls.Add(deleteBtn);
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
            // exportTxt
            // 
            exportTxt.BackColor = Color.Black;
            exportTxt.Location = new Point(554, 110);
            exportTxt.Name = "exportTxt";
            exportTxt.Size = new Size(99, 23);
            exportTxt.TabIndex = 6;
            exportTxt.Text = "Exportare text";
            exportTxt.UseVisualStyleBackColor = false;
            exportTxt.Click += exportTxt_Click;
            // 
            // editActivityBtn
            // 
            editActivityBtn.ForeColor = Color.Black;
            editActivityBtn.Location = new Point(312, 110);
            editActivityBtn.Name = "editActivityBtn";
            editActivityBtn.Size = new Size(123, 23);
            editActivityBtn.TabIndex = 5;
            editActivityBtn.Text = "Editeaza activitate";
            editActivityBtn.UseVisualStyleBackColor = true;
            editActivityBtn.Click += editActivityBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Location = new Point(441, 110);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(107, 23);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Sterge activitate";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
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
            activityName.ForeColor = Color.Black;
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
            activityTab.ForeColor = Color.White;
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
            domainTab.Controls.Add(domainList);
            domainTab.Controls.Add(newDomain);
            domainTab.Location = new Point(4, 24);
            domainTab.Name = "domainTab";
            domainTab.Padding = new Padding(3);
            domainTab.Size = new Size(775, 498);
            domainTab.TabIndex = 1;
            domainTab.Text = "Domenii";
            domainTab.UseVisualStyleBackColor = true;
            // 
            // domainList
            // 
            domainList.Columns.AddRange(new ColumnHeader[] { idDomain, domainName });
            domainList.GridLines = true;
            domainList.Location = new Point(10, 141);
            domainList.Name = "domainList";
            domainList.Size = new Size(644, 342);
            domainList.TabIndex = 5;
            domainList.UseCompatibleStateImageBehavior = false;
            domainList.View = View.Details;
            // 
            // idDomain
            // 
            idDomain.Text = "Id";
            // 
            // domainName
            // 
            domainName.Text = "Domeniu";
            domainName.Width = 90;
            // 
            // newDomain
            // 
            newDomain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            newDomain.Controls.Add(btnDeleteDomain);
            newDomain.Controls.Add(btnEditDomain);
            newDomain.Controls.Add(btnAddDomain);
            newDomain.Controls.Add(domainInput);
            newDomain.Controls.Add(domainLabel);
            newDomain.Location = new Point(6, 3);
            newDomain.Name = "newDomain";
            newDomain.Size = new Size(648, 126);
            newDomain.TabIndex = 4;
            newDomain.TabStop = false;
            newDomain.Text = "Domeniu nou";
            // 
            // btnDeleteDomain
            // 
            btnDeleteDomain.BackColor = Color.Red;
            btnDeleteDomain.ForeColor = Color.White;
            btnDeleteDomain.Location = new Point(535, 97);
            btnDeleteDomain.Name = "btnDeleteDomain";
            btnDeleteDomain.Size = new Size(107, 23);
            btnDeleteDomain.TabIndex = 7;
            btnDeleteDomain.Text = "Sterge domeniu";
            btnDeleteDomain.UseVisualStyleBackColor = false;
            btnDeleteDomain.Click += btnDeleteDomain_Click;
            // 
            // btnEditDomain
            // 
            btnEditDomain.ForeColor = Color.Black;
            btnEditDomain.Location = new Point(406, 97);
            btnEditDomain.Name = "btnEditDomain";
            btnEditDomain.Size = new Size(123, 23);
            btnEditDomain.TabIndex = 6;
            btnEditDomain.Text = "Editeaza domeniu";
            btnEditDomain.UseVisualStyleBackColor = true;
            btnEditDomain.Click += btnEditDomain_Click;
            // 
            // btnAddDomain
            // 
            btnAddDomain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddDomain.BackColor = Color.Green;
            btnAddDomain.DialogResult = DialogResult.Yes;
            btnAddDomain.ForeColor = Color.White;
            btnAddDomain.Location = new Point(277, 97);
            btnAddDomain.Name = "btnAddDomain";
            btnAddDomain.Size = new Size(123, 23);
            btnAddDomain.TabIndex = 2;
            btnAddDomain.Text = "Adauga domeniu";
            btnAddDomain.UseVisualStyleBackColor = false;
            btnAddDomain.Click += btnAddDomain_Click;
            // 
            // domainInput
            // 
            domainInput.Location = new Point(122, 29);
            domainInput.Name = "domainInput";
            domainInput.Size = new Size(113, 23);
            domainInput.TabIndex = 1;
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new Point(6, 32);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new Size(110, 15);
            domainLabel.TabIndex = 0;
            domainLabel.Text = "Denumire domeniu";
            // 
            // projectsTab
            // 
            projectsTab.Controls.Add(projectList);
            projectsTab.Controls.Add(projectBox);
            projectsTab.Location = new Point(4, 24);
            projectsTab.Name = "projectsTab";
            projectsTab.Padding = new Padding(3);
            projectsTab.Size = new Size(775, 498);
            projectsTab.TabIndex = 2;
            projectsTab.Text = "Proiecte";
            projectsTab.UseVisualStyleBackColor = true;
            // 
            // projectList
            // 
            projectList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            projectList.Columns.AddRange(new ColumnHeader[] { IdProject, projectNameCol, activityProjectCol, domainProjectCol });
            projectList.GridLines = true;
            projectList.Location = new Point(6, 240);
            projectList.Name = "projectList";
            projectList.Size = new Size(570, 252);
            projectList.TabIndex = 1;
            projectList.UseCompatibleStateImageBehavior = false;
            projectList.View = View.Details;
            // 
            // IdProject
            // 
            IdProject.Text = "Id";
            // 
            // projectNameCol
            // 
            projectNameCol.Text = "Proiect";
            projectNameCol.Width = 90;
            // 
            // activityProjectCol
            // 
            activityProjectCol.Text = "Activitate";
            activityProjectCol.Width = 90;
            // 
            // domainProjectCol
            // 
            domainProjectCol.Text = "Domeniu";
            domainProjectCol.Width = 90;
            // 
            // projectBox
            // 
            projectBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            projectBox.Controls.Add(cbDomain);
            projectBox.Controls.Add(cbActivity);
            projectBox.Controls.Add(btnDeleteProject);
            projectBox.Controls.Add(btnEditProject);
            projectBox.Controls.Add(btnAddProject);
            projectBox.Controls.Add(projectInput);
            projectBox.Controls.Add(idDomainLabel);
            projectBox.Controls.Add(activityIdLabel);
            projectBox.Controls.Add(projectLabel);
            projectBox.Location = new Point(6, 6);
            projectBox.Name = "projectBox";
            projectBox.Size = new Size(570, 228);
            projectBox.TabIndex = 0;
            projectBox.TabStop = false;
            projectBox.Text = "Proiect nou";
            // 
            // cbDomain
            // 
            cbDomain.FormattingEnabled = true;
            cbDomain.Location = new Point(93, 91);
            cbDomain.Name = "cbDomain";
            cbDomain.Size = new Size(121, 23);
            cbDomain.TabIndex = 10;
            // 
            // cbActivity
            // 
            cbActivity.FormattingEnabled = true;
            cbActivity.Location = new Point(93, 63);
            cbActivity.Name = "cbActivity";
            cbActivity.Size = new Size(121, 23);
            cbActivity.TabIndex = 9;
            // 
            // btnDeleteProject
            // 
            btnDeleteProject.BackColor = Color.Red;
            btnDeleteProject.ForeColor = Color.White;
            btnDeleteProject.Location = new Point(457, 199);
            btnDeleteProject.Name = "btnDeleteProject";
            btnDeleteProject.Size = new Size(107, 23);
            btnDeleteProject.TabIndex = 8;
            btnDeleteProject.Text = "Sterge proiect";
            btnDeleteProject.UseVisualStyleBackColor = false;
            btnDeleteProject.Click += btnDeleteProject_Click;
            // 
            // btnEditProject
            // 
            btnEditProject.ForeColor = Color.Black;
            btnEditProject.Location = new Point(328, 199);
            btnEditProject.Name = "btnEditProject";
            btnEditProject.Size = new Size(123, 23);
            btnEditProject.TabIndex = 7;
            btnEditProject.Text = "Editeaza proiect";
            btnEditProject.UseVisualStyleBackColor = true;
            btnEditProject.Click += btnEditProject_Click;
            // 
            // btnAddProject
            // 
            btnAddProject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddProject.BackColor = Color.Green;
            btnAddProject.DialogResult = DialogResult.Yes;
            btnAddProject.ForeColor = Color.White;
            btnAddProject.Location = new Point(199, 199);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(123, 23);
            btnAddProject.TabIndex = 4;
            btnAddProject.Text = "Adauga proiect";
            btnAddProject.UseVisualStyleBackColor = false;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // projectInput
            // 
            projectInput.Location = new Point(93, 29);
            projectInput.Name = "projectInput";
            projectInput.Size = new Size(121, 23);
            projectInput.TabIndex = 3;
            // 
            // idDomainLabel
            // 
            idDomainLabel.AutoSize = true;
            idDomainLabel.Location = new Point(7, 94);
            idDomainLabel.Name = "idDomainLabel";
            idDomainLabel.Size = new Size(68, 15);
            idDomainLabel.TabIndex = 2;
            idDomainLabel.Text = "Id domeniu";
            // 
            // activityIdLabel
            // 
            activityIdLabel.AutoSize = true;
            activityIdLabel.Location = new Point(7, 63);
            activityIdLabel.Name = "activityIdLabel";
            activityIdLabel.Size = new Size(68, 15);
            activityIdLabel.TabIndex = 1;
            activityIdLabel.Text = "Id activitate";
            // 
            // projectLabel
            // 
            projectLabel.AutoSize = true;
            projectLabel.Location = new Point(7, 32);
            projectLabel.Name = "projectLabel";
            projectLabel.Size = new Size(80, 15);
            projectLabel.TabIndex = 0;
            projectLabel.Text = "Nume proiect";
            // 
            // errorProviderAct
            // 
            errorProviderAct.ContainerControl = this;
            // 
            // errorProviderDomain
            // 
            errorProviderDomain.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 530);
            Controls.Add(tabControl1);
            KeyPreview = true;
            Name = "MainForm";
            Text = "Formular agenda";
            newActivity.ResumeLayout(false);
            newActivity.PerformLayout();
            tabControl1.ResumeLayout(false);
            activityTab.ResumeLayout(false);
            domainTab.ResumeLayout(false);
            newDomain.ResumeLayout(false);
            newDomain.PerformLayout();
            projectsTab.ResumeLayout(false);
            projectBox.ResumeLayout(false);
            projectBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderAct).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDomain).EndInit();
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
        private Button deleteBtn;
        private Button editActivityBtn;
        private ErrorProvider errorProviderAct;
        private Button exportTxt;
        private GroupBox newDomain;
        private Label domainLabel;
        private Button btnAddDomain;
        private TextBox domainInput;
        private ListView domainList;
        private Button btnDeleteDomain;
        private Button btnEditDomain;
        private ColumnHeader idDomain;
        private ColumnHeader domainName;
        private ErrorProvider errorProviderDomain;
        private GroupBox projectBox;
        private TextBox projectInput;
        private Label idDomainLabel;
        private Label activityIdLabel;
        private Label projectLabel;
        private Button btnDeleteProject;
        private Button btnEditProject;
        private Button btnAddProject;
        private ListView projectList;
        private ComboBox cbDomain;
        private ComboBox cbActivity;
        private ColumnHeader IdProject;
        private ColumnHeader projectNameCol;
        private ColumnHeader activityProjectCol;
        private ColumnHeader domainProjectCol;
    }
}

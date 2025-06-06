using AgendaActivitati.Model;

namespace AgendaActivitati
{
    public partial class MainForm : Form
    {
        private List<Activity> activities = new List<Activity>();
        private List<Domain> domains = new List<Domain>();
        private List<Project> projects = new List<Project>();

        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsActivityValid()
        {
            return !string.IsNullOrWhiteSpace(activityInput.Text.Trim());
        }
        private void activityBtn_Click(object sender, EventArgs e)
        {
            if (!IsActivityValid())
            {
                errorProviderAct.SetError(activityInput, "Câmpul activitate este gol!");
                return;
            }

            errorProviderAct.SetError(activityInput, string.Empty);

            string activityName = activityInput.Text;

            Activity activity = new Activity(activityName);
            activities.Add(activity);
            displayActivities();
            activityInput.Clear();
        }

        private void displayActivities()
        {
            activityList.Items.Clear();
            foreach (var activity in activities)
            {
                var listViewItem = new ListViewItem(activity.IdActivity.ToString());
                listViewItem.SubItems.Add(activity.ActivityName);
                activityList.Items.Add(listViewItem);
            }

            fillCbWithIdsActivities();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (activityList.SelectedItems.Count > 0)
            {
                var selectedItem = activityList.SelectedItems[0];
                int selectedId = int.Parse(selectedItem.Text);

                var activityToRemove = activities.FirstOrDefault(a => a.IdActivity == selectedId);
                if (activityToRemove != null)
                {
                    var confirmResult = MessageBox.Show("Sunteti sigur ca vreti sa stergeti aceasta activitate?", "Confirmati stergerea", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        activities.Remove(activityToRemove);
                        displayActivities();
                    }
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati activitatea pe care doriti sa o stergeti!");
            }
        }

        private void editActivityBtn_Click(object sender, EventArgs e)
        {
            if (activityList.SelectedItems.Count > 0)
            {
                var selectedItem = activityList.SelectedItems[0];
                int selectedId = int.Parse(selectedItem.Text);

                var activityToEdit = activities.FirstOrDefault(a => a.IdActivity == selectedId);
                if (activityToEdit != null)
                {
                    string newName = Microsoft.VisualBasic.Interaction.InputBox("Editeaza nume activitate:", "Editeaza", activityToEdit.ActivityName);

                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        activityToEdit.ActivityName = newName;
                        displayActivities();
                    }
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati activitatea pe care doriti sa o editati!");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.R))
            {
                activityInput.Clear();
                activityInput.Focus();
                MessageBox.Show("Resetare camp activitate!", "Shortcut activat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ExportListViewToTxt(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {

                foreach (ColumnHeader column in activityList.Columns)
                {
                    writer.Write(column.Text + "\t");
                }
                writer.WriteLine();


                foreach (ListViewItem item in activityList.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        writer.Write(subItem.Text + "\t");
                    }
                    writer.WriteLine();
                }
            }

            MessageBox.Show("Datele au fost exportate cu succes in calea  " + filePath, "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Save ListView Data";
            saveFileDialog.FileName = "activities.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportListViewToTxt(saveFileDialog.FileName);
            }
        }

        private bool IsDomainValid()
        {
            return !string.IsNullOrWhiteSpace(domainInput.Text.Trim());
        }

        private void displayDomains()
        {
            domainList.Items.Clear();
            foreach (var domain in domains)
            {
                var listViewItem = new ListViewItem(domain.IdDomain.ToString());
                listViewItem.SubItems.Add(domain.DomainName);
                domainList.Items.Add(listViewItem);
            }

            fillCbWithIdsDomains();
        }

        private void btnAddDomain_Click(object sender, EventArgs e)
        {
            if (!IsDomainValid())
            {
                errorProviderDomain.SetError(domainInput, "Câmpul activitate este gol!");
                return;
            }

            errorProviderDomain.SetError(domainInput, string.Empty);

            string domainName = domainInput.Text;

            Domain domain = new Domain(domainName);
            domains.Add(domain);
            displayDomains();
            domainInput.Clear();
        }

        private void btnDeleteDomain_Click(object sender, EventArgs e)
        {
            if (domainList.SelectedItems.Count > 0)
            {
                var selectedItem = domainList.SelectedItems[0];
                int selectedId = int.Parse(selectedItem.Text);

                var domainToRemove = domains.FirstOrDefault(a => a.IdDomain == selectedId);
                if (domainToRemove != null)
                {
                    var confirmResult = MessageBox.Show("Sunteti sigur ca vreti sa stergeti aceasta activitate?", "Confirmati stergerea", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        domains.Remove(domainToRemove);
                        displayDomains();
                    }
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati domeniul pe care doriti sa il stergeti!");
            }
        }

        private void btnEditDomain_Click(object sender, EventArgs e)
        {
            if (domainList.SelectedItems.Count > 0)
            {
                var selectedItem = domainList.SelectedItems[0];
                int selectedId = int.Parse(selectedItem.Text);

                var domainToEdit = domains.FirstOrDefault(a => a.IdDomain == selectedId);
                if (domainToEdit != null)
                {
                    string newName = Microsoft.VisualBasic.Interaction.InputBox("Editeaza nume activitate:", "Editeaza", domainToEdit.DomainName);

                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        domainToEdit.DomainName = newName;
                        displayDomains();
                    }
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati domeniul pe care doriti sa o editati!");
            }
        }

        private void fillCbWithIdsActivities()
        {
            cbActivity.Items.Clear();
            foreach (ListViewItem item in activityList.Items)
            {
                string id = item.Text;
                cbActivity.Items.Add(id);
            }
        }
        private void fillCbWithIdsDomains()
        {
            cbDomain.Items.Clear();
            foreach (ListViewItem item in domainList.Items)
            {
                string id = item.Text;
                cbDomain.Items.Add(id);
            }
        }

        private void displayProjects()
        {
            projectList.Items.Clear();
            foreach (var project in projects)
            {
                string activityName = activities.FirstOrDefault(a => a.IdActivity == project.IdActivity)?.ActivityName ?? "Unknown";
                string domainName = domains.FirstOrDefault(d => d.IdDomain == project.IdDomain)?.DomainName ?? "Unknown";
                var listViewItem = new ListViewItem(project.IdProject.ToString());
                listViewItem.SubItems.Add(project.ProjectName);
                listViewItem.SubItems.Add(activityName);
                listViewItem.SubItems.Add(domainName);
                projectList.Items.Add(listViewItem);
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            string projectName = projectInput.Text;
            int idActivity = int.Parse(cbActivity.Text);
            int idDomain = int.Parse(cbDomain.Text);

            Project project = new Project(idActivity, idDomain, projectName);
            projects.Add(project);
            displayProjects();
            projectInput.Clear();
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (projectList.SelectedItems.Count > 0)
            {
                var selectedItem = projectList.SelectedItems[0];
                int selectedId = int.Parse(selectedItem.Text);

                var projectToRemove = projects.FirstOrDefault(a => a.IdProject == selectedId);
                if (projectToRemove != null)
                {
                    var confirmResult = MessageBox.Show("Sunteti sigur ca vreti sa stergeti acest proiect?", "Confirmati stergerea", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        projects.Remove(projectToRemove);
                        displayProjects();
                    }
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati proiectul pe care doriti sa il stergeti!");
            }
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            if (projectList.SelectedItems.Count > 0)
            {
                var selectedItem = projectList.SelectedItems[0];
                int selectedId = int.Parse(selectedItem.Text);

                var projectToEdit = projects.FirstOrDefault(a => a.IdProject == selectedId);
                if (projectToEdit != null)
                {
                    string newName = Microsoft.VisualBasic.Interaction.InputBox("Editeaza nume activitate:", "Editeaza", projectToEdit.ProjectName);
                    string newActivityIdInput = Microsoft.VisualBasic.Interaction.InputBox("Introdu ID-ul noii activitati:", "Editeaza activitate", projectToEdit.IdActivity.ToString());
                    string newDomainIdInput = Microsoft.VisualBasic.Interaction.InputBox("Introdu ID-ul noului domeniu:", "Editeaza domeniu", projectToEdit.IdDomain.ToString());

                    if (!string.IsNullOrWhiteSpace(newName) && int.TryParse(newActivityIdInput, out int newActivityId) && int.TryParse(newDomainIdInput, out int newDomainId))
                    {
                        var activityExists = activities.Any(a => a.IdActivity == newActivityId);
                        var domainExists = domains.Any(a => a.IdDomain == newDomainId);

                        if (!activityExists)
                        {
                            MessageBox.Show("ID-ul activitatii nu exista.");
                            return;
                        }
                        projectToEdit.ProjectName = newName;
                        projectToEdit.IdActivity = newActivityId;
                        projectToEdit.IdDomain = newDomainId;
                        displayProjects();
                    }
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati domeniul pe care doriti sa o editati!");
            }
        }
    }
}

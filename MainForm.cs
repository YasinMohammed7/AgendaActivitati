using AgendaActivitati.Model;

namespace AgendaActivitati
{
    public partial class MainForm : Form
    {
        private List<Activity> activities = new List<Activity>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void activityBtn_Click(object sender, EventArgs e)
        {
            string activityName = activityInput.Text;

            Activity activity = new Activity(activityName);
            activities.Add(activity);
            displayActivities();
        }

        private void displayActivities()
        {
            activityList.Items.Clear();
            foreach (var activity in activities)
            {
                var listViewItem = new ListViewItem(activity.Id.ToString());
                listViewItem.SubItems.Add(activity.ActivityName);
                activityList.Items.Add(listViewItem);
            }
        }
    }
}

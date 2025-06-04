using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati.Model
{
    internal class Activity
    {
        public int Id { get; set; }
        public string ActivityName { get; set; }

        public Activity(string activityName)
        {
            ActivityName = activityName;
        }

        public Activity()
        {
        }
    }
}

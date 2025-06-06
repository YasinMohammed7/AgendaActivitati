using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati.Model
{
    internal class Activity
    {
        private static int _nextId = 1;
        public int IdActivity { get; set; }
        public string ActivityName { get; set; }

        public Activity(string activityName)
        {
            IdActivity = _nextId++;
            ActivityName = activityName;
        }
    }
}

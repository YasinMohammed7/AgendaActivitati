using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati.Model
{
    internal class Project
    {
        private static int _nextId = 1;
        public string ProjectName { get; set; }
        public int IdProject { get; set; }
        public int IdActivity { get; set; }
        public int IdDomain { get; set; }

        public Project(int idActivity, int idDomain, string projectName)
        {
            IdProject = _nextId++;
            IdActivity = idActivity;
            IdDomain = idDomain;
            ProjectName = projectName;
        }
    }
}

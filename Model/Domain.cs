using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati.Model
{
    internal class Domain
    {
        private static int _nextId = 1;
        public int IdDomain { get; set; }

        public string DomainName { get; set; }

        public Domain(string domainName)
        {
            IdDomain = _nextId++;
            DomainName = domainName;
        }
    }
}

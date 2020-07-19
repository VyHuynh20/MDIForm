using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18110400_TaskManagement
{
    public class User
    {
        public string userName { get; set; }
        public string fullName { get; set; }
        public DateTime dateBirth { get; set; }
        public string department { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public List<Task> listTasks { get; set; }
        public override string ToString()
        {
            return this.userName;
        }
    }
}

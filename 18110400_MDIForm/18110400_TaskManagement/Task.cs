using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18110400_TaskManagement
{
    public class Task
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }
        public List<User> listUsers { get; set; }
    }
}

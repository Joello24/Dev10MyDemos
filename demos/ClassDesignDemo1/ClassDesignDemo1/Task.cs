using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesignDemo1
{
    class Task
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        /*
        public string FirstName { get; set; }
        public string LastName { get
            {
                return LastName;
            }
            set {
                LastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        */

        public void CompleteTask() 
        {
            IsComplete = true;
        }

    }
}

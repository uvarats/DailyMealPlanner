using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class UserData
    {

        public int Weight { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public DailyActivity Activity { get; set; }
        public double BMR { get; set; }
        public double ARM { get; set; }

        public UserData()
        {

        }
    }
}

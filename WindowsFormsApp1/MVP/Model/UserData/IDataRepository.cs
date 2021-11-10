using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.MVP.Model
{
    public interface IDataRepository
    {
        int Weight { get; }
        int Height { get; }
        int Age { get; }
        DailyActivity Activity { get; }
        void SetUserData(int weight, int height, int age, DailyActivity activity);
        double GetDCR();
        void Save();
    }
}

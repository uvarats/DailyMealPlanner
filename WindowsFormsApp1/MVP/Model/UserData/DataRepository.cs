using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.MVP.Model
{
    class DataRepository : IDataRepository
    {
        private readonly string _filePath;
        private readonly UserData _data;

        public DataRepository(string programPath)
        {
            _filePath = programPath + @"\UserData.xml";
            //_data = UserData.Instance;
            if (File.Exists(_filePath))
            {
                _data = GenericSerializer<UserData>.Deserialize(_filePath);
            } else
            {
                _data = new UserData();
                SetUserData(65, 180, 18, DailyActivity.Normal);
                Save();
            }
        }

        public int Weight { get => _data.Weight; }
        public int Height { get => _data.Height; }
        public int Age { get => _data.Age; }
        public DailyActivity Activity { get => _data.Activity; }

        public double GetDCR() => _data.BMR + _data.ARM;

        public void Save()
        {
            GenericSerializer<UserData>.Serialize(_data, _filePath);
        }

        private double GetARM()
        {
            switch (Activity)
            {
                case DailyActivity.Low:
                    return 1.2;
                case DailyActivity.Normal:
                    return 1.375;
                case DailyActivity.Average:
                    return 1.55;
                case DailyActivity.High:
                    return 1.725;
                default:
                    return 1.375;
            }
        }
        public void SetUserData(int weight, int height, int age, DailyActivity activity)
        {
            _data.Weight = weight;
            _data.Height = height;
            _data.Age = age;
            _data.Activity = activity;
            _data.ARM = GetARM();
            _data.BMR = 447.593 + 9.247 * Weight + 3.098 * Height - 4.330 * Age;
            Save();
        }
    }
}

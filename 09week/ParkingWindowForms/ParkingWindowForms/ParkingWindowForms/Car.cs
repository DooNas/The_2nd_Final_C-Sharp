using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingWindowForms
{
    class Car
    {
        private int seq;
        private string carNumber;
        private DateTime inTime;
        private DateTime outTime;

        public int Seq
        {
            get => seq;
            set => seq = value;
        }

        public string CarNumber
        {
            get => carNumber;
            set => carNumber = value;
        }

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }

        public DateTime GetInTime()
        {
            return inTime;
        }
        public DateTime GetOutTime()
        {
            return outTime;
        }
        public int Price(DateTime inTime, DateTime outTime)
        {
            int result = 0;

            double oATimeIntervalValue = outTime.ToOADate() - inTime.ToOADate();
            DateTime TimeIntervalValue = DateTime.FromOADate(oATimeIntervalValue);
            int days = TimeIntervalValue.Day;
            int hours = TimeIntervalValue.Hour;
            int mins = TimeIntervalValue.Minute;
            int secons = TimeIntervalValue.Second;

            result = (hours * 3600) + (mins * 600) + (secons * 10);

            return result;
        }
    }
}
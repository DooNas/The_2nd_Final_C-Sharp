using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingWindowForms
{
    public partial class ParkingMgtForm : Form
    {
        ArrayList carNumberList = new ArrayList();
        List<Car> cars = new List<Car>();
        Car car;
        int seq = 0;
        DateTime inTime;
        DateTime outTime;

        public ParkingMgtForm()
        {
            InitializeComponent();
            carNumberList = new ArrayList();
            btnCarIn.Click += btnCarIn_Click;
            btnCarOut.Click += btnCarOut_Click;

        }
        private void btnCarIn_Click(object sender, EventArgs e)
        {
            car = new Car();
            car.Seq = ++seq;
            car.CarNumber = cdoCarList.Text;
            car.SetInTime();
            cars.Add(car);
            carNumberList.Add(cdoCarList.Text);
            cdoCarList.Items.Clear();
            cdoCarList.Items.AddRange(carNumberList.ToArray());

            StringBuilder sb = new StringBuilder();
            sb.Append("차량 번호 : ");
            sb.Append(cdoCarList.Text);
            sb.Append(" [입고 시간] ");
            sb.Append(car.GetInTime());
            listBoxState.Items.Add(sb.ToString());
            Console.WriteLine("현재 차량 대수 : " + cars.Count);
            int counts = cdoCarList.Items.Count;
            lb_CarCount.Text = counts.ToString();
        }

        private void btnCarOut_Click(object sender, EventArgs e)
        {
            foreach (var car in cars)
            {
                if (car.CarNumber.Contains(cdoCarList.Text)) //동일한 차량 번호 파악
                {
                    car.SetOutTime();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("차량 번호 : ");
                    sb.Append(cdoCarList.Text);
                    sb.Append(" [입고 시간] ");
                    inTime = car.GetInTime();
                    sb.Append(inTime);
                    sb.Append(" [ 출고 시간 ] ");
                    outTime = car.GetOutTime();
                    sb.Append(outTime);
                    listBoxState.Items.Add(sb.ToString());
                    cars.Remove(car);

                    MessageBox.Show(
                        "출차\n입고 시간 : " + car.GetInTime().ToString() +
                        "\n출고 시간 : " + car.GetOutTime().ToString() +
                        "\n주차비 : " + car.Price(inTime, outTime).ToString() + "원"
                        );
                    break;
                }
            }
            carNumberList.Remove(cdoCarList.Text);
            cdoCarList.Items.Clear();
            cdoCarList.Items.AddRange(carNumberList.ToArray());
            Console.WriteLine("현재 차량 대수: " + cars.Count);
            int counts = cdoCarList.Items.Count;
            lb_CarCount.Text = counts.ToString();
        }

    }
}

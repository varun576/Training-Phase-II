using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SimplePrograms
{
    internal class ElectricReading
    {
        private int consumernumber, previousreading, currentreading; private string consumername, consumertype;

        public ElectricReading(int consumernumber, string consumername, int currentreading, int previousreading, string consumertype)
        {
            Consumernumber = consumernumber; Previousreading = previousreading; Currentreading = currentreading; Consumername = consumername; Consumertype = consumertype;
        }

        public int Consumernumber { get => consumernumber; set => consumernumber = value; }
        public int Previousreading { get => previousreading; set => previousreading = value; }
        public int Currentreading { get => currentreading; set => currentreading = value; }
        public string Consumername { get => consumername; set => consumername = value; }
        public string Consumertype
        {
            get => consumertype; set => consumertype
        = value;
        }

        public int CalculateBill()
        {
            int consumption = Currentreading - Previousreading;

            int billamt = 0;
            if (Consumertype.Equals("Domestic"))
            {

                if (consumption <= 100)
                {
                    billamt = 0;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    billamt = (consumption - 100) * 2;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billamt = (consumption - 100) * 5;
                }
                else if (consumption > 500)
                {
                    billamt = (consumption - 100) * 10;
                }


            }
            else if (Consumertype.Equals("Commercial"))
            {
                if (consumption <= 100)
                {
                    billamt = 10;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    billamt = (consumption - 100) * 20;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billamt = (consumption - 100) * 50;
                }
                else if (consumption > 500)
                {
                    billamt = (consumption - 100) * 100;
                }
            }
            return billamt;
        }

        //public void displayBillDetails(int billamt)
        //{
        //    calculateBill();
        //    Console.WriteLine($"bill:{consumernumber} {consumername} {billamt}");
        //}
    }
}

using System;

namespace Ex08.Entities
{
    class HourContract 
    {
        //os parametros dos tempos do contrato de worker
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() {

        }

        public HourContract(DateTime date, double valuePerHour, int hours) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() {
            return Hours * ValuePerHour;
        }
    }
}
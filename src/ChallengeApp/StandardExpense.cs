using System;
using System.Collections.Generic; // dodać aby móc używać LIST

namespace ChallengeApp
{
    public class StandardExpense
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public int ID { get; private set; } = 0;
        public string Category { get; set; }
        static int serialNo = 0;
        public StandardExpense(string name, double value, DateTime date, string category)
        {
            this.Name = name;
            this.Value = value;
            if (value <= 0)
            {
                Console.WriteLine("wartość musi być większa od zero");
            }
            this.Date = date;
            this.Category = category;
            this.ID=serialNo;
            serialNo++;
        }
    }
}

using System;

namespace ChallengeApp
{
    public class Expense
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public int ID { get; private set; } = 0;
        public string Category { get; set; }
        static int serialNo = 0;
        public Expense(string name, double value, DateTime date, string category)
        {
            this.Name = name;
            this.Value = value;
            this.Date = date;
            this.Category = category;
            this.ID = serialNo;
            serialNo++;
        }
    }
}

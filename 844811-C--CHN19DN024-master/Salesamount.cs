namespace Auto
{
    class Salesamount
    {
        string Pname;
        int quantity;
        double Price;
        static double totalsales;
        public Salesamount() { }
        public Salesamount(string pn, int q, double pr)
        {
            Pname = pn;
            quantity = q;
            Price = pr;
            totalsales += pr * q;
        }
        public double display()
        {
            return totalsales;
        }
    }
}

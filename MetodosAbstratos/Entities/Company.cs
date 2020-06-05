namespace MetodosAbstratos.Entities
{
    class Company : Taxpayer
    {
        public int Employee { get; private set; }
        public Company(string name, double anualIcome, int employee) :base(name,anualIcome)
        {
            Employee = employee;
        }

        public override double TaxValue()
        {
            if(Employee > 10)
            {
                return (AnualIncome * 0.14);
            }
            else
            {
                return (AnualIncome * 0.16);
            }
        }
    }
}

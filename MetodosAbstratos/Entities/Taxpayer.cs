using System.Globalization;

namespace MetodosAbstratos.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; protected set; }
        public double AnualIncome { get; protected set; }
        public Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double TaxValue();

        public override string ToString()
        {
            return Name
                + ": $ "
                + TaxValue().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}

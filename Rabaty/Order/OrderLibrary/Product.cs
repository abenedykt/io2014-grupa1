namespace OrderLibrary
{
    public class Product
    {
        private double _netto;
        private double _tax;

        public string Name { get; set; }
        public double Price { get; set; }
        public double PriceAfterDiscount { get; set; }
        public double Netto
        {
            get
            {
                return _netto;
            }
            set
            {
                _netto = value < 0 ? 0 : value;
                Tax = Tax;
            }
        }
        public double Tax
        {
            get
            {
                return _tax;
            }
            set
            {
                _tax = value;
                Price = Netto * (1 + Tax);
            }
        }

        public Product(string name, double netto, double tax = 0.23)
        {
            Name = name;
            Netto = netto;
            Tax = tax;
            PriceAfterDiscount = netto;
        }


    }
}

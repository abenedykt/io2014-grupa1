using System;

namespace _3.Zlozonosc
{
    public class Class1
    {
        public double Metoda1()
        {
            return DateTime.Now.Second*2;
        }

        public int Metoda2(int k, int j)
        {
            return k + j;
        }

        public double Metoda3(bool monday, double @base, double tax)
        {
            if (monday)
            {
                return @base + @base * tax;
            }
            return @base;
        }

        public double Metoda4(DayOfWeek day, double @base, double discountBase)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return @base + discountBase * 1;
                case DayOfWeek.Tuesday: return @base + discountBase * 2;
                case DayOfWeek.Wednesday: return @base + discountBase * 3;
                case DayOfWeek.Thursday: return @base + discountBase * 4;
            }
            return 0;
        }
    }
}

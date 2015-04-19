using System;

namespace _3.Zlozonosc
{
    public class Class1
    {
        public void Metoda1()
        {

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

        public double Metoda4(DayOfWeek day, double @base, double tax)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return @base + tax * 1;
                case DayOfWeek.Tuesday: return @base + tax * 2;
                case DayOfWeek.Wednesday: return @base + tax * 3;
                case DayOfWeek.Thursday: return @base + tax * 4;
                case DayOfWeek.Friday: return @base + tax * 5;
                case DayOfWeek.Saturday: return @base + tax * 6;
                case DayOfWeek.Sunday: return @base + tax * 7;
            }

            return 0;
        }

    }
}

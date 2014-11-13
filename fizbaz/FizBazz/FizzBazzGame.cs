namespace FizBazz
{
    public class FizzBazzGame
    {
        public object Play(object p)
        {
            if ((int)p % 15 == 0) p = "FizzBazz";
            else if ((int)p % 5 == 0) p = "Bazz";
            else if ((int)p % 3 == 0) p = "Fizz"; 
            return p;
        }
    }
}

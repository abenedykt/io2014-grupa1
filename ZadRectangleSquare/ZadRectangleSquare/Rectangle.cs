namespace ZadRectangleSquare
{
    public class Rectangle
    {
        private int a;
        private int b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int CalculateArea()
        {
            return this.a * this.b;
        }

        public int CalculateCircuit()
        {
            return 2 * this.a  + 2 * this.b;
        }
    }
}

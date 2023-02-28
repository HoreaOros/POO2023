namespace _0228
{
    internal class HorzBar
    {
        private int width;

        public HorzBar(int width)
        {
            this.width = width;
            System.Console.Write('+');
            for (int i = 1; i < width - 1; i++)
            {
                System.Console.Write("-");
            }
            System.Console.WriteLine('+');

        }

        public int Width 
        { 
            get
            {
                return width;
            }
        }
    }
}
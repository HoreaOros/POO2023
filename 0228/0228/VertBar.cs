namespace _0228
{
    internal class VertBar
    {
        private int height;

        public VertBar(int height)
        {
            this.height = height;
            for (int i = 0; i < height; i++)
            {
                System.Console.WriteLine("|");
            }
        }
        public int Height 
        { 
            get
            {
                return height;
            }
        }
    }
}
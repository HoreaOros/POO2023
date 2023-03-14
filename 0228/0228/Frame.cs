namespace _0228
{
    /// <summary>
    /// +----+
    /// |
    /// |
    /// |
    /// +----+
    /// </summary>
    internal class Frame
    {
        HorzBar h1, h2;
        VertBar v;

        public Frame(int width, int height)
        {
            h1 = new HorzBar(width);
            v = new VertBar(height);
            h2 = new HorzBar(width);
        }
        public int Width
        {
            get
            {
                return h1.Width;
            }
        }
        public int Height
        {
            get
            {
                return v.Height;
            }
        }
        public VertBar VertBar
        {
            get
            {
                return v;
            }
        }
    }
}
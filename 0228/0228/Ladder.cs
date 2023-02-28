namespace _0228
{
    internal class Ladder
    {
        private Frame frame1, frame2;
        private VertBar vert;

        public Ladder(int width, int height1, int height2)
        {
            frame1 = new Frame(width, height1);
            vert = new VertBar(height2);
            frame2 = new Frame(width, height1);
        }
        public int Width
        {
            get
            {
                return frame1.Width;
            }
        }
        public int FrameHeight
        {
            get
            {
                return frame1.Height;
            }
        }
        public int Height
        {
            get
            {
                return vert.Height;
            }
        }
    }
}
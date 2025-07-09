using System.Drawing;

namespace P2_PC2_Paint_GarciaE.DrawingCore
{
    public class Canvas
    {
        private Bitmap _bitmap;
        private Graphics _graphics;

        public Canvas(int width, int height)
        {
            _bitmap = new Bitmap(width, height);
            _graphics = Graphics.FromImage(_bitmap);
            Clear(Color.White); // Limpia al iniciar
        }

        public Bitmap Bitmap => _bitmap;

        public void Clear(Color color)
        {
            _graphics.Clear(color);
        }

        public void SetPixel(int x, int y, Color color)
        {
            if (x >= 0 && y >= 0 && x < _bitmap.Width && y < _bitmap.Height)
            {
                _bitmap.SetPixel(x, y, color);
            }
        }

        public Color GetPixel(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < _bitmap.Width && y < _bitmap.Height)
                return _bitmap.GetPixel(x, y);
            return Color.Transparent;
        }

        public void RenderToPictureBox(System.Windows.Forms.PictureBox pictureBox)
        {
            pictureBox.Image = (Bitmap)_bitmap.Clone();
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace RandomPixelPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _ = new PixelPaintBox(topLeftPictureBox);
            _ = new PixelPaintBox(topMidPictureBox);
            _ = new PixelPaintBox(topRightPictureBox);
            _ = new PixelPaintBox(midLeftPictureBox);
            _ = new PixelPaintBox(midMidPictureBox);
            _ = new PixelPaintBox(midRightPictureBox);
            _ = new PixelPaintBox(bottomLeftPictureBox);
            _ = new PixelPaintBox(bottomMidPictureBox);
            _ = new PixelPaintBox(bottomRightPictureBox);

            BackColor = Color.BurlyWood;
        }
    }
}

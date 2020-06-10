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
            _ = new PixelPaintBox(topRightPictureBox);
            _ = new PixelPaintBox(bottomLeftPictureBox);
            _ = new PixelPaintBox(bottomRightPictureBox);

            BackColor = Color.White;
        }
    }
}

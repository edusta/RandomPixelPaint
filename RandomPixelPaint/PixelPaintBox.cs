using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class PixelPaintBox
{
	private readonly Random rnd = new Random();
	private readonly Timer randomTimer = new Timer
	{
		Interval = 1
	};

	private PictureBox pictureBox;
    private Bitmap originalImageBitmap;

	private Dictionary<(int, int), int> pixelDict = new Dictionary<(int, int), int>();

    public static readonly int bitmapWidth = 150;
    public static readonly int bitmapHeight = 150;

    public PixelPaintBox(PictureBox pictureBox)
	{
		this.pictureBox = pictureBox;

        InitializeBitmap();
        InitializeTimer();
        PaintRandomImage(true);
        LoadRandomImage();
	}

	private void InitializeTimer()
	{
		randomTimer.Tick += new EventHandler(Timer_OnTick);
	}

    private void InitializeBitmap()
    {
        pictureBox.Image = new Bitmap(bitmapWidth, bitmapHeight);
    }

    private void Timer_OnTick(object sender, EventArgs e)
    {
        if (pixelDict.Count == 0)
        {
            randomTimer.Stop();
            System.Threading.Thread.Sleep(2000);
            PaintRandomImage(false);
            LoadRandomImage();
            return;
        }

        var randomSelection = pixelDict.ElementAt(rnd.Next(0, pixelDict.Count));
        var randomKey = randomSelection.Key;

        int randomX = randomKey.Item1;
        int randomY = randomKey.Item2;

        pixelDict.Remove(randomKey);

        ((Bitmap)pictureBox.Image).SetPixel(randomX, randomY, originalImageBitmap.GetPixel(randomX, randomY));

        pictureBox.Refresh();
    }

    private void PaintRandomImage(bool shouldSetPixel)
    {
        for (int row = 0; row < bitmapHeight; row++)
        {
            for (int column = 0; column < bitmapWidth; column++)
            {
                if (shouldSetPixel)
                {
                    ((Bitmap)pictureBox.Image).SetPixel(row, column, Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
                }
                pixelDict[(row, column)] = 1;
            }
        }
    }

    private void LoadRandomImage()
    {
        var request = System.Net.WebRequest.Create("https://picsum.photos/" + bitmapWidth);

        using (var response = request.GetResponse())
        using (var stream = response.GetResponseStream())
        {
            originalImageBitmap = new Bitmap(stream);

            randomTimer.Start();
        }
    }
}

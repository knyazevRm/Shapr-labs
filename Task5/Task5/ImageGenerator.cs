using System.Text;

namespace Task5;


public class ImageGenerator
{
    private int Height { get; set; }
    private int Width { get; set; }
    private Random Rand;

    public ImageGenerator(int height, int width)
    {
        Rand = new Random();
        Height = height;
        Width = width;
    }

    public String generationImage()
    {
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                stringBuilder.Append(Rand.Next(0, 5) < 3 ? "*" : "_");
            }

            stringBuilder.Append("\n");
        }

        return stringBuilder.ToString();
    }
}
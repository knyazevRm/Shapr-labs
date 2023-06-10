namespace Task5;

public class Camera
{
    private int Size { get; set; }
    private List<String> photos = new();
    private ImageGenerator ImageGenerator;

    public Camera(int size)
    {
        this.Size = size;
        ImageGenerator = new(size, size);
    }

    public void TakePhoto()
    {
        photos.Add(ImageGenerator.generationImage());
    }

    public String GetLastPhoto()
    {
        /*if (photos.Count > 0)
        {
            return photos[^1];
        }

        return "No new photos."; // в одну строку*/

        return photos.Count > 0 ? photos[^1] : "No new photos.";
    }
}
namespace imagemResizer.Service
{
    public class Resizer
    {
        public static void ImageResizer(Image image, int newWidth, int newHeight, string fileDestinyPath)
        {
            Bitmap novaImagem = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(novaImagem))
            {
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            novaImagem.Save(fileDestinyPath);
            image.Dispose();
        }
    }
}

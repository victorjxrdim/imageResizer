namespace imagemResizer.Service
{
    public class Resizer
    {
        public static void ImageResizer(Image image, int newHeight, string fileDestinyPath)
        {
            double ratio = (double)newHeight / image.Height;
            int novaLargura = (int)(image.Width * ratio);
            int novaAltura = newHeight;

            Bitmap novaImagem = new Bitmap(novaLargura, novaAltura);
            using (Graphics g = Graphics.FromImage(novaImagem))
            {
                g.DrawImage(image, 0, 0, novaLargura, novaAltura);
            }

            novaImagem.Save(fileDestinyPath);
            image.Dispose();
        }
    }
}

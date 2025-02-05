using imagemResizer.Service;

namespace imagemResizer
{
    public partial class Form1 : Form
    {
        private string imagePath;
        private string imagePathDestiny;
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectImageButton(object sender, EventArgs a)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Select the image that you want to resize";
            openFile.Filter = "File Images|*.jpg;*.png;*.bmp;*.jpeg";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFile.FileName;
                selectedImage.Image = Image.FromFile(imagePath);
                selectedImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void SelectDestinyPath(object sender, EventArgs a)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                imagePathDestiny = folderBrowserDialog.SelectedPath;
                fileLabel.Text = imagePathDestiny;
            }
        }

        private void ResizeImage(object sender, EventArgs a)
        {
            if (string.IsNullOrEmpty(imagePath) || string.IsNullOrEmpty(imagePathDestiny))
            {
                MessageBox.Show("Select an image, and a directory that you want to save, please.");
                return;
            }

            if (!int.TryParse(widthTextBox.Text, out int newWidth) || newWidth <= 0)
            {
                MessageBox.Show("Insert a valid width.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(heightTextBox.Text, out int newHeight) || newHeight <= 0)
            {
                MessageBox.Show("Insert a valid height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newNameFile = Path.GetFileNameWithoutExtension(imagePath) + "_resized" + Path.GetExtension(imagePath);
            string finalPathName = Path.Combine(imagePathDestiny, newNameFile);

            try
            {
                Resizer.ImageResizer(Image.FromFile(imagePath), newWidth, newHeight, finalPathName);
                MessageBox.Show("Your image has been resized", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to process the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

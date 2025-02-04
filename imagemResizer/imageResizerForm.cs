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

            openFile.Title = "Selecione a imagem que deseja para redimensionar";
            openFile.Filter = "Arquivos de Imagem|*.jpg;*.png;*.bmp;*.jpeg";

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
                MessageBox.Show("Selecione a imagem, e um diretório antes de redimensionar por favor");
                return;
            }

            if (!int.TryParse(heightTextBox.Text, out int newHeight) || newHeight <= 0)
            {
                MessageBox.Show("Insira um valor válido para a altura.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newNameFile = Path.GetFileNameWithoutExtension(imagePath) + "_resized" + Path.GetExtension(imagePath);
            string finalPathName = Path.Combine(imagePathDestiny, newNameFile);

            try
            {
                Resizer.ImageResizer(Image.FromFile(imagePath), newHeight, finalPathName);
                MessageBox.Show("Imagem redimensionada e salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

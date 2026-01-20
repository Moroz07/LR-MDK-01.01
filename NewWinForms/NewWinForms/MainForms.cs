using System.Windows.Forms;

namespace NewWinForms
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
            //FileNamesListBox.Items.Add("Пупкин");
            //FileNamesListBox.Items.Add("Пушкин");
            //FileNamesListBox.Items.Add("Лермонтов");
            //FileNamesListBox.Items.Add("Попов");
            //FileNamesListBox.Items.Add("Смирнов");
        }

        private void FileNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileNamesListBox.SelectedItem != null)
            {
                PictureArea.Load(FileNamesListBox.SelectedItem.ToString());
            }
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpeg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                FileNamesListBox.Items.Add(filePath);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (FileNamesListBox.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Вы точно хотите удалить этот файл?", "Внимание!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    FileNamesListBox.Items.RemoveAt(FileNamesListBox.SelectedIndex);
                    if (FileNamesListBox.Items.Count > 0)
                    {
                        FileNamesListBox.SelectedIndex = FileNamesListBox.Items.Count - 1;
                    }
                    else PictureArea.Image = null;
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (FileNamesListBox.SelectedItem != null)
            {
                string filePath;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "jpeg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                    FileNamesListBox.Items.Add(filePath);
                }
            }
        }
    }
}

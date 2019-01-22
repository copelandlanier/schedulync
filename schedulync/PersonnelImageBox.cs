using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Calendar_NEW
{
    public partial class PersonnelImageBox : UserControl
    {
        protected bool validData;
        string PersonnelImagePath;
        protected Image PersonnelImage;
        protected Thread GetImageThread;

        public PersonnelImageBox()
        {
            InitializeComponent();
            this.panel_PersonnelImage.DragDrop += new DragEventHandler(panel_PersonnelImage_DragDrop);
            this.panel_PersonnelImage.DragEnter += new DragEventHandler(panel_PersonnelImage_DragEnter);
            this.panel_PersonnelImage.DragLeave += panel_PersonnelImage_DragLeave;
            this.panel_PersonnelImage.DoubleClick += panel_PersonnelImage_DoubleClick;
        }

        private void panel_PersonnelImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (openFile_PersonnelImage.ShowDialog() == DialogResult.OK)
                {
                    PersonnelImage = (Bitmap)Image.FromFile(openFile_PersonnelImage.FileName, true);
                    imgResize();
                }
            }

            catch
            {
                MessageBox.Show("Selection is not an image file. Please select an image file");
                panel_PersonnelImage.BackgroundImage = Properties.Resources.Empty_Personnel;
            }
        }

        private void panel_PersonnelImage_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (GetImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                imgResize();
            }
        }

        private void panel_PersonnelImage_DragLeave(object sender, EventArgs e)
        {
            panel_PersonnelImage.BackgroundImage = Properties.Resources.Empty_Personnel;
        }

        private void panel_PersonnelImage_DragEnter(object sender, DragEventArgs e)
        {
            string filename;
            validData = GetFilename(out filename, e);
            if (validData)
            {
                PersonnelImagePath = filename;
                GetImageThread = new Thread(new ThreadStart(LoadImage));
                GetImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = System.IO.Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }

        protected void LoadImage()
        {
            PersonnelImage = new Bitmap(PersonnelImagePath);
        }

        public void imgResize()
        {
            try
            {
                Image imageIn = PersonnelImage;
                var postCrop = resizeImage(PersonnelImage, new Size(80, 80));
                panel_PersonnelImage.BackgroundImage = postCrop;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }    
}

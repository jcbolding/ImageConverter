using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageConverter
{
    public partial class Form1 : Form
    {

        class ImageInfo
        {
            public ImageInfo(string name, Image image)
            {
                FileName = name;
                Image = image;
            }

            public string FileName
            { get; set; }
            public Image Image
            { get; set; }

            public override string ToString()
            {
               return FileName;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            if(openImageFiles.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var fileName in openImageFiles.FileNames)
                {
                    var img = Image.FromFile(fileName);
                    
                    lstFiles.Items.Add(new ImageInfo(fileName, img)); 
                }
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var imageInfo = lstFiles.SelectedItem as ImageInfo;
            if (imageInfo != null)
                imgPreview.BackgroundImage = imageInfo.Image;
            else
                imgPreview.BackgroundImage = null;
        }

        private void btnConvertFiles_Click(object sender, EventArgs e)
        {

            ImageFormat format= ImageFormat.Jpeg;
            string ext = ".jpg";

            if(cmbFormat.Text == "png")
            {
                format = ImageFormat.Png;
                ext = ".png";
            }
            else if(cmbFormat.Text == "bmp")
            {
                format = ImageFormat.Bmp;
                ext = ".bmp";
            }
            else if(cmbFormat.Text == "gif")
            {
                format = ImageFormat.Gif;
                ext = ".gif";
            }

            if(!Directory.Exists(txtOutputLocation.Text))
            {
                Directory.CreateDirectory(txtOutputLocation.Text);
            }

            foreach (ImageInfo imgInfo in lstFiles.Items)
            {
                var file = imgInfo.FileName;

                file = file.Substring(file.LastIndexOf('\\') +1);
                file = file.Substring(0, file.LastIndexOf('.'));
                var img = HandleAlpha(imgInfo.Image);
                img.Save(txtOutputLocation.Text + file + ext, format);
            }
                
        }

        private Image HandleAlpha(Image source)
        {
            if(source.RawFormat.Guid != ImageFormat.Png.Guid)
            {
                return source;
            }
            // Assumes myImage is the PNG you are converting
            var b = new Bitmap(source.Width, source.Height);
            b.SetResolution(source.HorizontalResolution, source.VerticalResolution);

            using (var g = Graphics.FromImage(b))
            {
                g.Clear(Color.White);
                g.DrawImageUnscaled(source, 0, 0);
            }

            return b;
        }

        private void lstFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                lstFiles.Items.Remove(lstFiles.SelectedItem);
            }
        }

    }
}

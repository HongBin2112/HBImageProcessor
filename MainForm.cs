using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;

using Emgu.CV.Structure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace projectJX_cs
{
    public partial class MainForm : Form
    {

        CropImage cropInputImage = new CropImage();
        ImageProcess imageProcess = new ImageProcess();
        //FormDebug formDebug;
        
        Rectangle cropInputRect;

        public MainForm()
        {
            InitializeComponent();
            imageBox_input.AllowDrop = true;
            
            /*
            this.Text = String.Empty;
            this.ControlBox = false;
            */
        }




        internal Dictionary<string, string> GetDebugInfos()
        {
            Dictionary<string, string> debugInfos = new Dictionary<string, string>();
            string strSelectedFilesPath = "Not loaded.";
            string strNowConvertedImage = imageProcess.NowConvertedImage;
            if (imageProcess.SelectedFilesPath != null) { strSelectedFilesPath = string.Join("$", imageProcess.SelectedFilesPath); }
            
            debugInfos.Add("NowConvertedImage", strNowConvertedImage);
            debugInfos.Add("SelectedFilesPath", strSelectedFilesPath);
            debugInfos.Add("ImageSaveFolder", imageProcess.ImageSaveFolder);
            return debugInfos;
        }

        private void ShowLoadedImage()
        {
            imageBox_input.Image = imageProcess.InputImage;
            cropInputImage.IsImageLoaded = true;
            groupBoxOperation.Enabled = true;
            labelName.Text = imageProcess.NowConvertedImage;
            labelSize.Text = "Input Image Size:\n" + imageProcess.InputImage.Size.ToString();
        }


        private void ChangeBackgroundColor_MouseEnter(object sender, EventArgs e)
        {
            Color dataBackgroundColor = Color.FromArgb(68,68,102);
            if (sender is Label)
            {
                var senderLabel = (Label)sender;
                senderLabel.BackColor = dataBackgroundColor;
            }
            else if(sender is TrackBar)
            {
                var senderTrackBar = (TrackBar)sender;
                senderTrackBar.BackColor = dataBackgroundColor;
            }
        }
        private void ChangeBackgroundColor_MouseLeave(object sender, EventArgs e)
        {
            Color dataBackgroundColor = Color.FromArgb(51, 51, 76);
            if (sender is Label)
            {
                var senderLabel = (Label)sender;
                senderLabel.BackColor = dataBackgroundColor;
            }
            else if (sender is TrackBar)
            {
                var senderTrackBar = (TrackBar)sender;
                senderTrackBar.BackColor = dataBackgroundColor;
            }

        }


        // event Define

        private void loadImagesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            imageProcess.LoadFiles();
            imageProcess.LoadImage();
            if(imageProcess.InputImage != null)
            {
                ShowLoadedImage();
            }
        }




        //-------------Input image crop functions-------------
        private void imageBox_input_MouseDown(object sender, MouseEventArgs e)
        {
            cropInputImage.IsMouseDown = true;
            cropInputImage.StartPoint = e.Location;
        }

        private void imageBox_input_MouseMove(object sender, MouseEventArgs e)
        {
            if (cropInputImage.IsMouseDown)
            {
                cropInputImage.EndPoint = e.Location;
                imageBox_input.Invalidate();
            }
        }

        private void imageBox_input_Paint(object sender, PaintEventArgs e)
        {
            if (cropInputImage.IsImageLoaded)
            {
                /*because ratioInputImage_WnH is fixed. we can use it to calculate displayImageWidth.*/
                double ratioInputImage_WnH = (double)imageProcess.InputImage.Size.Width / imageProcess.InputImage.Size.Height;
                double ratioX = imageBox_input.ClientSize.Width / (double)imageProcess.InputImage.Size.Width;
                double ratioY = imageBox_input.ClientSize.Height / (double)imageProcess.InputImage.Size.Height;

                /*displayImageWidth is width of the image that show on the screen. not the input size.*/
                int displayImageWidth = imageBox_input.ClientSize.Width;
                int displayImageHeight = imageBox_input.ClientSize.Height;
                int offsetX=0, offsetY=0;
                double displayRatioX = 1, displayRatioY = 1;

                /*if ratioX>ratioY, empty will fill image's right and left side. no empty at Height.
                  for ratioX<ratioY, it's top and bottom. and no empty at Width.*/
                
                if (ratioX> ratioY)
                {
                    displayImageWidth = (int)(imageBox_input.ClientSize.Height * ratioInputImage_WnH);
                    displayImageHeight = imageBox_input.ClientSize.Height;
                    displayRatioX =  (double)displayImageWidth/ imageProcess.InputImage.Size.Width;
                    displayRatioY = ratioY;
                    offsetX = (imageBox_input.ClientSize.Width - displayImageWidth) / 2;
                    offsetY = 0;
                }
                else if(ratioX< ratioY)
                {
                    displayImageWidth = imageBox_input.ClientSize.Width;
                    displayImageHeight = (int)(imageBox_input.ClientSize.Width / ratioInputImage_WnH);
                    displayRatioX = ratioX;
                    displayRatioY = (double)displayImageHeight/ imageProcess.InputImage.Size.Height;
                    offsetX = 0;
                    offsetY = (imageBox_input.ClientSize.Height - displayImageHeight) / 2;
                }
                
                
                cropInputRect = cropInputImage.GetCropRect(displayRatioX, displayRatioY, offsetX, offsetY);
                if (cropInputRect != Rectangle.Empty)  { e.Graphics.DrawRectangle(Pens.Aqua, cropInputImage.GetCropRect()); }
                /*label1.Text = cropInputRect.ToString() + '\n' + imageBox_input.Size.ToString() + '\n'
                    + imageProcess.InputImage.Size.ToString() + '\n' + displayImageWidth.ToString()+','+ displayImageHeight.ToString()
                    +'|' + offsetX.ToString()+','+ offsetY.ToString()+'|' + displayRatioX.ToString() + ',' + displayRatioY.ToString();*/
            }
        }

        private void imageBox_input_MouseUp(object sender, MouseEventArgs e)
        {
            if (cropInputImage.IsMouseDown)
            {
                cropInputImage.EndPoint = e.Location;
                cropInputImage.IsMouseDown = false;
            }
        }
        //-------------------------------------------------------------




        private void checkedListBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnConverted_Click(object sender, EventArgs e)
        {
            /* Notice! the order of imageProcess like "CropImage", "ToGray", cannot be re-arranged.*/


            //First. if (Crop == true)
            imageProcess.CropImage(cropInputRect, checkedListBoxOperation.GetItemChecked(2));

            // if (Invert Color == true)
            imageProcess.InvertColor(checkedListBoxOperation.GetItemChecked(1));
            // if (Flip == true)
            imageProcess.HFlip(checkedListBoxOperation.GetItemChecked(3));
            // Contrast
            imageProcess.ApplyContrast();
            imageProcess.ApplyGamma();
            //Final. if (ToGray == true)!
            imageProcess.ToGray(checkedListBoxOperation.GetItemChecked(0));



            // show the converted image
            if (imageProcess.IsGray)
            {
                labelOutputSize.Text = "Output Image Size: \n " + imageProcess.GrayImage.Size.ToString();
                pazPictureBox_converted.Image = imageProcess.GrayImage.ToBitmap<Gray, byte>();
            }
            else
            {
                labelOutputSize.Text = "Output Image Size: \n " + imageProcess.OutputImage.Size.ToString();
                pazPictureBox_converted.Image = imageProcess.OutputImage.ToBitmap<Bgr, byte>();
            }

            btnSave.Enabled = true;
        }










        // Open New Window -> Debug From 
        
        /*
        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDebug = new FormDebug(this);
            formDebug.StartPosition = this.StartPosition;
            formDebug.Show();
            //Application.Run(formDebug);
        }
        */
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imageProcess.InputImage != null)
            {
                imageProcess.NowConvertedIndex++;
                imageProcess.LoadImage();
                imageBox_input.Image = imageProcess.InputImage;
                labelName.Text = imageProcess.NowConvertedImage;
                labelSize.Text = "Input Image Size:\n " + imageProcess.InputImage.Size.ToString();
            }
        }




        private void btnReset_Click(object sender, EventArgs e)
        {
            imageProcess.LoadImage();
            pazPictureBox_converted.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            imageProcess.SaveOutputImage();        
        }

        private void outputFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if(folderDlg.ShowDialog() == DialogResult.OK)
            {
                imageProcess.ImageSaveFolder = folderDlg.SelectedPath;
                labelOutputFolder.Text = "Output Folder: \n " + "\"" + imageProcess.ImageSaveFolder + "\\\"";
            }
        }

        private void trackBarGamma_Scroll(object sender, EventArgs e)
        {
            imageProcess.Gamma = trackBarGamma.Value*0.01;
            groupBoxGamma.Text = "Gamma(x100): " + trackBarGamma.Value;
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            imageProcess.Contrast = trackBarContrast.Value*0.01;
            groupBoxContrast.Text = "Contrast(x100): " + (trackBarContrast.Value-100);
            
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageBox_input_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void imageBox_input_DragDrop(object sender, DragEventArgs e)
        {
            string filename = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
            if (filename != null)
            {
                bool isLoadSuccess = imageProcess.LoadFile(filename);
                
                if (isLoadSuccess)
                {
                    imageProcess.LoadImage();
                    ShowLoadedImage();
                }
            }

        }

        private void labelEnlarge_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void labelMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

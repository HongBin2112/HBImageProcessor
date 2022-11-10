using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;

using Emgu.CV.Structure;
using HBImageProcessor;


namespace projectJX_cs
{
    public partial class MainForm : Form
    {

        internal CropImage cropInputImage = new CropImage();
        internal ImageProcess imageProcess = new ImageProcess();
        private Rectangle cropInputRect;



        public MainForm()
        {
            InitializeComponent();
            imageBox_input.AllowDrop = true;
            
            /*
            this.Text = String.Empty;
            this.ControlBox = false;
            */
        }


        private delegate void DelDoNext();
        private void AskSaveBeforeDoNext(DelDoNext callback)
        {
            if (imageProcess.InputImage != null)
            {
                bool isDoNext = true;

                if (imageProcess.IsSave == false)
                { isDoNext = HBImageProcessor.UtilHBIP.IsDoNext(); }

                if (isDoNext)
                {
                    callback();
                    imageProcess.IsSave = true;
                }
            }
        }


        private void ShowLoadedImage()
        {
            imageBox_input.Image = imageProcess.InputImage;
            cropInputImage.IsImageLoaded = true;
            groupBoxOperation.Enabled = true;
            labelName.Text = imageProcess.NowConvertedImage;
            labelSize.Text = "Input Image Size:\n" + imageProcess.InputImage.Size.ToString();
        }








        // event Define
        private void ChangeBackgroundColor_MouseEnter(object sender, EventArgs e)
        {
            Color dataBackgroundColor = Color.FromArgb(68,68,102);
            UtilHBIP.ChangeBackgroundColor(sender, dataBackgroundColor);
        }
        private void ChangeBackgroundColor_MouseLeave(object sender, EventArgs e)
        {
            Color dataBackgroundColor = Color.FromArgb(51, 51, 76);
            UtilHBIP.ChangeBackgroundColor(sender, dataBackgroundColor);

        }


 
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
            // Contrast, Gamma
            imageProcess.ApplyContrast();
            imageProcess.ApplyGamma();
            // if (Invert Color == true)
            imageProcess.InvertColor(checkedListBoxOperation.GetItemChecked(1));
            // if (Flip == true)
            imageProcess.HFlip(checkedListBoxOperation.GetItemChecked(3));

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
            imageProcess.IsSave = false;
            
        }












        private void ChangeNowConvertedIndex(bool isForward)
        {

            if(isForward) { imageProcess.NowConvertedIndex++; }
            else { imageProcess.NowConvertedIndex--; }

            imageProcess.LoadImage();
            imageProcess.InitBools();
            ShowLoadedImage();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            btnConverted_Click(sender, e);
            btnSave_Click(sender, e);


            DelDoNext delDoNext = () => { ChangeNowConvertedIndex(true); };
            AskSaveBeforeDoNext(delDoNext);
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            DelDoNext delDoNext = () => { ChangeNowConvertedIndex(false); };
            AskSaveBeforeDoNext(delDoNext);
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
            if(imageProcess.InputImage == null) { this.Close(); }

            DelDoNext delDoNext = this.Close;
            AskSaveBeforeDoNext(delDoNext);
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
            if(this.WindowState == FormWindowState.Normal) {this.WindowState = FormWindowState.Maximized; }
            else { this.WindowState = FormWindowState.Normal; }
        }

        private void labelMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        




        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DelDoNext delDoNext = imageProcess.RemoveImage;
            AskSaveBeforeDoNext(delDoNext);
            
            if (imageProcess.LoadImage()) 
            {
                ShowLoadedImage();
            }
            else
            {
                groupBoxOperation.Enabled = false;
                cropInputImage.IsImageLoaded = false;

                labelName.Text = "Load Image";
                labelSize.Text = "";
                labelOutputSize.Text = "";

                imageBox_input.Image = null;
                pazPictureBox_converted.Image = null;

            }
            
        }


        /* 
         Function:openChildFormInPanel(),
         Ref:https://rjcodeadvance.com/iu-moderno-submenu-desplegable-deslizante-menu-lateral-responsivo-only-form-c-winform/ 
        */
        private Form? activeForm = null;
        private void openChildFormInPanel(Form childForm, Panel targetPanel)
        {
            
            if (activeForm != null)
            {
                activeForm.Close();
                
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            targetPanel.Controls.Add(childForm);
            targetPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //FormMenu formMenu = new FormMenu(this);
        private void btnMenu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormMenu(this), panelMenuSpace);
        }
    }
}

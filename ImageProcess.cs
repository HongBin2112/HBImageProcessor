using Emgu.CV.Structure;
using Emgu.CV;

using System;
/*
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing;
*/

namespace projectJX_cs
{
    internal class ImageProcess
    {
        private OpenFileDialog imgsOfd;
        private string[]? selectedFilesPath;
        private Dictionary<string, string> imagesPath;
        private List<string> images;

        private string? nowConvertedImage;
        private int nowConvertedIndex;
        private bool isGray, isColorInverted, isHFlip;
        private string imageSaveFolder;

        private double gamma, contrast;

        private Image<Bgr, byte>? inputImage;
        private Image<Bgr, byte>? outputImage;
        private Image<Gray, byte>? grayImage;

        public ImageProcess()
        {
            imgsOfd = new OpenFileDialog();
            imagesPath = new Dictionary<string, string>();
            images = new List<string>();
            nowConvertedIndex = 0;
            isGray = false;
            isColorInverted = false;
            isHFlip = false;
            imageSaveFolder = ".";
            gamma = 1;
            contrast = 1;

            imgsOfd.Filter = "Image Files(*.png,*.bmp,*.jpg,*.jpeg)|*.png;*.bmp;*.jpg;*.jpeg";
            imgsOfd.Title = "Select Images";
            imgsOfd.Multiselect = true; 
        }

        public string[] SelectedFilesPath
        {
            get { return selectedFilesPath; }
        }

        public string NowConvertedImage
        {
            get { return nowConvertedImage; }
        }

        public int NowConvertedIndex
        {
            get { return nowConvertedIndex; }
            set { 
                if(value < images.Count) { nowConvertedIndex = value; }
                else { nowConvertedIndex = 0; }
            }
        }

        public Image<Bgr, byte> InputImage
        {
            get { return inputImage; }
        }

        public Image<Bgr, byte> OutputImage
        {
            get { return outputImage; }
        }

        public Image<Gray, byte> GrayImage
        {
            get { return grayImage; }
        }

        public bool IsGray
        {
            get { return isGray; }
        }

        public string ImageSaveFolder
        {
            get { return imageSaveFolder; }
            set { imageSaveFolder = value; }
        }

        public double Gamma
        {
            set { gamma = value; }
        }
        public double Contrast
        {
            set { contrast = value; }
        }






        // ----------Methods---------


        private void CopyImageInputToOutput()
        {
            outputImage = inputImage.Copy();
        }


        public void LoadFiles()
        {
            if(imgsOfd.ShowDialog() == DialogResult.OK)
            {
                selectedFilesPath = imgsOfd.FileNames;
                foreach (string imgPath in selectedFilesPath)
                {
                    string imgName = Path.GetFileName(imgPath);
                    if(imagesPath.ContainsKey(imgName) == false) { imagesPath.Add(imgName, imgPath); }
                    if(images.Contains(imgName) == false) { images.Add(imgName); }
                }
                nowConvertedImage = images[nowConvertedIndex];
            }
        }


        public bool LoadFile(string filePath)
        {
            FileInfo fi_loadFile = new FileInfo(Path.GetFileName(filePath));
            bool isLoadSuccess;

            string imgName = fi_loadFile.Name;
            string imgFormat = fi_loadFile.Extension;

            //Console.WriteLine(imgFormat);
            if(imgFormat== ".png" || imgFormat == ".jpg" || imgFormat== ".bmp" || imgFormat== ".jpeg" ) { isLoadSuccess = true; }
            else { isLoadSuccess = false; }

            if (isLoadSuccess)
            {
                if (imagesPath.ContainsKey(imgName) == false) { imagesPath.Add(imgName, filePath); }
                if (images.Contains(imgName) == false) { images.Add(imgName); }
                nowConvertedImage = images[nowConvertedIndex];
            }
            return isLoadSuccess;

        }



        public void LoadImage()
        {
            if (nowConvertedImage != null)
            {
                nowConvertedImage = images[nowConvertedIndex];
                inputImage = new Image<Bgr, byte>(imagesPath[nowConvertedImage]);
                outputImage = inputImage.Copy();
            }
        }





        public void CropImage(Rectangle _rect, bool enableCrop = true)
        {
            if(_rect != null && enableCrop)
            {
                Image<Bgr, byte> temp;
                try
                {
                    inputImage.ROI = _rect;
                    temp = inputImage.CopyBlank();
                    inputImage.CopyTo(temp);
                    outputImage = temp;
                    inputImage.ROI = Rectangle.Empty;
                }
                catch (Exception) { outputImage = inputImage.Copy(); }
            }
            else { outputImage = inputImage.Copy(); }
       
            
        }



        public void ToGray(bool enableToGray = true)
        {
            isGray = enableToGray;
            grayImage = outputImage.Copy().Convert<Gray, byte>();
        }

        public void InvertColor(bool enableInvertColor = true)
        {
            Image<Bgr, byte> temp = outputImage.Copy();

            if (enableInvertColor) 
            {
                CvInvoke.BitwiseNot(temp, outputImage);
                isColorInverted = true;
            }
            else if(enableInvertColor == false) { isColorInverted = false; }
            
        }

        public void HFlip(bool enableFlip = true)
        {
            Image<Bgr, byte> temp = outputImage.Copy();
            if (enableFlip) 
            {
                CvInvoke.Flip(temp, outputImage, Emgu.CV.CvEnum.FlipType.Horizontal);
                isHFlip = true;
            }
            else if (enableFlip == false) { isHFlip = false; }
        }


        public void ApplyContrast(bool enableApply = true)
        {
            double brightness = 0;
            if (enableApply)
            {
                outputImage = outputImage.Mul(contrast) + brightness;
            }
        }

        public void ApplyGamma(bool enableApply = true)
        {
            if (enableApply)
            {
                outputImage._GammaCorrect(gamma);
            }

        }


        public void SaveOutputImage()
        {
            FileInfo fi_nowConvertedImage = new FileInfo(nowConvertedImage);
            string outputImageName = fi_nowConvertedImage.Name + "_converted" + fi_nowConvertedImage.Extension;
            string imageSavePath = imageSaveFolder + '\\' + outputImageName;
            if (isGray)
            {
                grayImage.ToBitmap().Save(imageSavePath);
            }
            else
            {
                outputImage.Copy().ToBitmap().Save(imageSavePath);
            }
        }



    }
}

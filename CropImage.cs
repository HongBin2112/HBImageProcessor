using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectJX_cs
{
    internal class CropImage
    {
        private bool isImageLoaded;
        private Point startPoint;
        private Point endPoint;
        private bool isMouseDown;

        public CropImage()
        {
            this.startPoint = new Point(0, 0);
            this.endPoint = new Point(0, 0);
            this.isMouseDown = false;
            this.isImageLoaded = false;
        }

        public bool IsImageLoaded
        {
            get { return isImageLoaded; }
            set { isImageLoaded = value; }
        }
        public bool IsMouseDown
        {
            get { return this.isMouseDown; }
            set 
            {
                if (this.isImageLoaded) { this.isMouseDown = value; }
                else { this.isMouseDown = false; } 
            }
        }

        public Point StartPoint 
        {
            get { return this.startPoint; }
            set { this.startPoint = value; }
        }

        public Point EndPoint
        {
            get { return this.endPoint; }
            set { this.endPoint = value; }  
        }

        public Rectangle GetCropRect()
        {
            Rectangle cropRect = new Rectangle();
            cropRect.X = Math.Min(this.startPoint.X, this.endPoint.X);
            cropRect.Y = Math.Min(this.startPoint.Y, this.endPoint.Y);
            cropRect.Width = Math.Abs(this.startPoint.X - this.endPoint.X);
            cropRect.Height = Math.Abs(this.startPoint.Y - this.endPoint.Y);

            return cropRect;
        }

        public Rectangle GetCropRect(double ratioX, double ratioY, int offsetX, int offsetY)
        {
            Rectangle cropRect = new Rectangle();
            cropRect.X = (int)(Math.Min(this.startPoint.X, this.endPoint.X) / ratioX);
            cropRect.Y = (int)(Math.Min(this.startPoint.Y, this.endPoint.Y) / ratioY);
            cropRect.Width = (int)(Math.Abs(this.startPoint.X - this.endPoint.X) / ratioX);
            cropRect.Height = (int)(Math.Abs(this.startPoint.Y - this.endPoint.Y) / ratioY);

            /*if ratioX>ratioY, empty will fill image's right and left side. no empty at Height.
             * for ratioX<ratioY, it's top and bottom. and no empty at Width.
             */
            cropRect.X = cropRect.X - (int)(offsetX / ratioX); 
            cropRect.Y = cropRect.Y - (int)(offsetY / ratioY); 

            return cropRect;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBImageProcessor
{
    public partial class FormMenu : Form
    {
        private projectJX_cs.MainForm _mainForm;
        public FormMenu(projectJX_cs.MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImageProcessing_Click(object sender, EventArgs e)
        {
            /*
             panelImageProcessing.Visible = true;
             panelImageToText.Visible = false;
            this.Close();
             */
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int numLoadedImages = _mainForm.imageProcess.Images.Count;
            for(int i = 0; i < numLoadedImages; i++)
            {
                _mainForm.imageProcess.RemoveImage();
            }
            _mainForm.imageProcess.Images.Clear();
            _mainForm.groupBoxOperation.Enabled = false;
            _mainForm.cropInputImage.IsImageLoaded = false;
            _mainForm.imageBox_input.Image = null;
            _mainForm.pazPictureBox_converted.Image = null;
            
        }
    }
}

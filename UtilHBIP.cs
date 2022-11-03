using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBImageProcessor
{
    static internal class UtilHBIP
    {   
        static public bool IsDoNext()
        {
            System.Windows.Forms.DialogResult goNext;
            goNext = MessageBox.Show("Do you really want to go the next before saving your converted image?",
                                      "Are You Sure?",
                                      MessageBoxButtons.YesNo);

            bool result;

            if (goNext.ToString() == "Yes") { result = true; }
            else { result = false; }

            return result;
        }



        static public void ChangeBackgroundColor(object sender, Color dataOfBackgroundColor)
        {
            if (sender is Label)
            {
                var senderLabel = (Label)sender;
                senderLabel.BackColor = dataOfBackgroundColor;
            }
            else if (sender is TrackBar)
            {
                var senderTrackBar = (TrackBar)sender;
                senderTrackBar.BackColor = dataOfBackgroundColor;
            }
        }



    }
}

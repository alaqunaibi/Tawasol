using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TawasolSupportPro
{
    public class clsFontMatters
    {
         
        public  clsFontMatters()
       {
          
       }

        public void FillFonts(ToolStripComboBox cbox)
         {
              foreach (FontFamily oneFontFamily in FontFamily.Families)
             {
                 cbox.Items.Add(oneFontFamily.Name);
             }
         }

        public void FillFontSize(ToolStripComboBox cbox)
        {

            int[] fontsize = new int[16] {8,9,10,11,12,14,16,18,20,22,24,26,28,36,48,72};

            for (int i = 0; i < 16; i++)
            {
                cbox.Items.Add(fontsize[i].ToString());
            }
        }




    }



}

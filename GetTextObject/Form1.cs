using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace GetTextObject
{
     public partial class GetTextObject : Form
     {
          public GetTextObject()
          {
               InitializeComponent();
          }

          private void hSmartWindowControl1_HInitWindow(object sender, EventArgs e)
          {
               HWindow hWindow = (sender as HSmartWindowControl).HalconWindow;
               HTextModel hTextModel = new HTextModel("auto", "Industrial_Rej");
               HImage hImage = new HImage("ocr/medication_package_02_right");


               HTextResult hTextResult = hImage.FindText(hTextModel);
               HObject hTextLine = hTextResult.GetTextObject(new HTuple("line", 0));

               hWindow.SetColored(3);
               hWindow.DispImage(hImage);
               hWindow.DispObj(hTextLine);
               hSmartWindowControl1.SetFullImagePart(null);
          }
     }
}

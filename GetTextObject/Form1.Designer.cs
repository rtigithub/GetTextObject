namespace GetTextObject
{
     partial class GetTextObject
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
               this.hSmartWindowControl1 = new HalconDotNet.HSmartWindowControl();
               this.tableLayoutPanel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // tableLayoutPanel1
               // 
               this.tableLayoutPanel1.AutoSize = true;
               this.tableLayoutPanel1.ColumnCount = 1;
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
               this.tableLayoutPanel1.Controls.Add(this.hSmartWindowControl1, 0, 0);
               this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
               this.tableLayoutPanel1.Name = "tableLayoutPanel1";
               this.tableLayoutPanel1.RowCount = 1;
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
               this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 624);
               this.tableLayoutPanel1.TabIndex = 0;
               // 
               // hSmartWindowControl1
               // 
               this.hSmartWindowControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.hSmartWindowControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
               this.hSmartWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.hSmartWindowControl1.HDoubleClickToFitContent = true;
               this.hSmartWindowControl1.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
               this.hSmartWindowControl1.HImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
               this.hSmartWindowControl1.HKeepAspectRatio = true;
               this.hSmartWindowControl1.HMoveContent = true;
               this.hSmartWindowControl1.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
               this.hSmartWindowControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
               this.hSmartWindowControl1.Location = new System.Drawing.Point(0, 0);
               this.hSmartWindowControl1.Margin = new System.Windows.Forms.Padding(0);
               this.hSmartWindowControl1.Name = "hSmartWindowControl1";
               this.hSmartWindowControl1.Size = new System.Drawing.Size(890, 624);
               this.hSmartWindowControl1.TabIndex = 0;
               this.hSmartWindowControl1.WindowSize = new System.Drawing.Size(890, 624);
               this.hSmartWindowControl1.HInitWindow += new HalconDotNet.HInitWindowEventHandler(this.hSmartWindowControl1_HInitWindow);
               // 
               // GetTextObject
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(890, 624);
               this.Controls.Add(this.tableLayoutPanel1);
               this.Name = "GetTextObject";
               this.Text = "Form1";
               this.tableLayoutPanel1.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
          private HalconDotNet.HSmartWindowControl hSmartWindowControl1;
     }
}


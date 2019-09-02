using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;

namespace test0820
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //擷取攝影機的影像
        private Capture capture;
        //判斷攝影機鏡頭狀態
        private bool captureinprocess;

        /// <summary> 
        /// 啟動攝影機與暫停攝影機
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private void Capture_But_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                if (captureinprocess)
                {
                    Application.Idle -= new EventHandler(ProcessFrame);
                    Capture_But.Text = "Start！";
                }
                else
                {
                    Application.Idle += new EventHandler(ProcessFrame);
                    Capture_But.Text = "Stop！";
                }
                captureinprocess = !captureinprocess;
            }
            else
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
        }
        /// <summary>
        /// 讀取攝影機的影像畫面並且顯示在ImageBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void ProcessFrame(object sender, EventArgs arg)
        {
            //顯示擷取到的影像
            Image<Bgr, Byte> ImageFrame = capture.QueryFrame().ToImage<Bgr, Byte>();
            Capture_ImageBox.Image = ImageFrame;

            //將讀取到的影像轉換成灰階 並顯示
            Image<Gray, Byte> GrayFrame = ImageFrame.Convert<Gray, Byte>();
            Gray_ImageBox.Image = GrayFrame;

            Image<Gray, Byte> CannyFrame = ImageFrame.Canny(120, 255);
            Binary_ImageBox.Image = CannyFrame;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //路徑設定
            string imagePath = "C:\\Users\\user\\Desktop\\circle.gif"; 
            Image<Bgr, Byte> original = new Image<Bgr, Byte>(imagePath);
            //直接顯示
            CvInvoke.Imshow("original", original);

            //灰階處理
            Image<Gray, Byte> Gray = original.Convert<Gray, Byte>();
            CvInvoke.Imshow("Gray", Gray);

            //水平Sobel
            Image<Gray, Single> SobelS = Gray.Sobel(2, 0, 3);
            CvInvoke.Imshow("SobelS", SobelS);
            //垂直Sobel
            Image<Gray, Single> SobelC = Gray.Sobel(0, 2, 3);
            CvInvoke.Imshow("SobelC", SobelC);

            //整合Sobel
            Image<Gray, Single> SobelA = SobelC.Sobel(2, 0, 3);
            CvInvoke.Imshow("SobelA", SobelA);

            //霍夫找/畫圓
            CircleF[] circles = CvInvoke.HoughCircles(Gray, HoughType.Gradient, 1, 50, 100, 12, 50, 70);
            Image<Bgr, Byte> circleImage = original.Clone();
            foreach (CircleF circle in circles)
            {
                circleImage.Draw(circle, new Bgr(Color.Red), 5);
                Console.WriteLine("圓心座標 X: " + circle.Center.X.ToString() + "  Y: " + circle.Center.Y.ToString());
            }
            CvInvoke.Imshow("HoughCircles", circleImage);
        }

    }
}







  

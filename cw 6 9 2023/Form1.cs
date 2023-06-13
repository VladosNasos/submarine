using System.IO;

namespace cw_6_9_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            BackColor = Color.White;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            Graphics g = this.CreateGraphics();
            Pen p = new Pen(new SolidBrush(Color.OrangeRed), 120);
            Rectangle r = new Rectangle(120, 145, 180, 180);
            g.DrawEllipse(p, r);


            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Cyan);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(1, 200, 1000, 500));
            myBrush.Dispose();
            formGraphics.Dispose();

            //System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            //System.Drawing.Graphics formGraphics2;
            //formGraphics2 = this.CreateGraphics();
            //formGraphics2.FillRectangle(myBrush2, new Rectangle(200, 300, 20, 400));
            //myBrush2.Dispose();
            //formGraphics2.Dispose();
            Graphics g2 = this.CreateGraphics();
            Pen p2 = new Pen(new SolidBrush(Color.Black), 120);
            Rectangle r2 = new Rectangle(450, 180, 5, 100);
            g.DrawEllipse(p2, r2);

            Graphics g1 = this.CreateGraphics();
            Pen p1 = new Pen(new SolidBrush(Color.Gray), 120);
            Rectangle r1 = new Rectangle(300, 300, 400, 70);
            g.DrawEllipse(p1, r1);

            Graphics g3 = this.CreateGraphics();
            Pen p3 = new Pen(new SolidBrush(Color.White), 30);
            Rectangle r3 = new Rectangle(445, 170, 5, 5);
            g.DrawEllipse(p3, r3);

            Graphics g4 = this.CreateGraphics();
            Pen p4 = new Pen(new SolidBrush(Color.Gray), 30);
            Rectangle r4 = new Rectangle(488, 190, 10, 30);
            g.DrawEllipse(p4, r4);

            Graphics g5= this.CreateGraphics();
            Pen p5 = new Pen(new SolidBrush(Color.White), 30);
            Rectangle r5 = new Rectangle(280, 320, 5, 5);
            g.DrawEllipse(p5, r5);

            Graphics g6 = this.CreateGraphics();
            Pen p6 = new Pen(new SolidBrush(Color.White), 30);
            Rectangle r6 = new Rectangle(360, 320, 5, 5);
            g.DrawEllipse(p6, r6);

            Graphics g7 = this.CreateGraphics();
            Pen p7 = new Pen(new SolidBrush(Color.White), 30);
            Rectangle r7 = new Rectangle(440, 320, 5, 5);
            g.DrawEllipse(p7, r7);

            Graphics g8 = this.CreateGraphics();
            Pen p8 = new Pen(new SolidBrush(Color.White), 30);
            Rectangle r8 = new Rectangle(520, 320, 5, 5);
            g.DrawEllipse(p8, r8);

            Graphics g9 = this.CreateGraphics();
            Pen p9 = new Pen(new SolidBrush(Color.White), 30);
            Rectangle r9 = new Rectangle(600, 320, 5, 5);
            g.DrawEllipse(p9, r9);

            Graphics g81 = this.CreateGraphics();
            Pen p81 = new Pen(new SolidBrush(Color.White), 30);
            Rectangle r81 = new Rectangle(680, 320, 5, 5);
            g.DrawEllipse(p81, r81);
            //Image i = Image.FromFile(@"C:\Users\Vlados\Desktop.jpg");
            //using (Bitmap source = new Bitmap(image))
            //{
            //    using (Bitmap cuttedImage = source.Clone(new System.Drawing.Rectangle(250, 0, 5550, 4000), source.PixelFormat))
            //    {
                   
                            
            //               Bitmap.Image.Save(@"C:\Users\Vlados\Desktop.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                 
            //    }
            //}
        }
    }
}
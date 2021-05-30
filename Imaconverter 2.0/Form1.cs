using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imaconverter_2._0
{
    public partial class Form1 : Form
    {

        bool res = false;
        public Form1()
        {
            InitializeComponent();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(Width, Height);
            this.MaximumSize = this.MinimumSize;
            checkmark1.Visible = false;
            FadeIn(this, 4);
        }

        private async void FadeIn(Form o, int interval = 80)
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1; //make fully visible       
        }

        private async void FadeOut(Form o, int interval = 80)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; //make fully invisible  
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            FadeOut(this, 7);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String s = comboBox1.SelectedItem.ToString();
            if (res == true)
            {
                s = comboBox1.SelectedItem.ToString();
                System.Drawing.Image image = System.Drawing.Image.FromFile(@openFileDialog1.FileName);
                String we = openFileDialog1.FileName.Substring(0, openFileDialog1.FileName.Length - 4);
                System.Threading.Thread.Sleep(1000);
                SaveFileDialog saveF = new SaveFileDialog();
                saveF.Filter = $"Image (*{s})|*{s}";
                if (saveF.ShowDialog() == DialogResult.OK)
                {
                    timer1.Start();
                }

                if (s == ".jpg")
                {
                    image.Save($@"{saveF.FileName}", System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                if (s == ".png")
                {
                    image.Save($@"{saveF.FileName}", System.Drawing.Imaging.ImageFormat.Png);
                }
                else if (s == ".bmp")
                {
                    image.Save($@"{saveF.FileName}", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                else if (s == ".ico")
                {
                    image.Save($@"{saveF.FileName}", System.Drawing.Imaging.ImageFormat.Icon);
                }
                else
                {

                    s = comboBox1.SelectedItem.ToString();
                    s = comboBox1.SelectedItem.ToString();
                    if ((comboBox1.SelectedItem.ToString() != ".png") && (comboBox1.SelectedItem.ToString() != ".jpg") && (comboBox1.SelectedItem.ToString() != ".bmp") && (comboBox1.SelectedItem.ToString() != ".ico"))
                    {
                        MessageBox.Show("New format not specified",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error // for Error 
                                                 //MessageBoxIcon.Information  // for Information
                                                 //MessageBoxIcon.Question // for Question
                        );
                    }
                    s = comboBox1.SelectedItem.ToString();
                    s = comboBox1.SelectedItem.ToString();
                    s = comboBox1.SelectedItem.ToString();
                    s = comboBox1.SelectedItem.ToString();
                }
            }
            else
            {
                MessageBox.Show("File not specified",
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error // for Error 
                         //MessageBoxIcon.Information  // for Information
                         //MessageBoxIcon.Question // for Question
);
            }
            /*
            image.Save(@"C:\Users\Admin\Desktop\Dysk Okru (OKR)\DesktopBackground.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            image.Save(@"C:\Users\Admin\Desktop\Dysk Okru (OKR)\DesktopBackground.gif", System.Drawing.Imaging.ImageFormat.Gif);
            image.Save(@"C:\Users\Admin\Desktop\Dysk Okru (OKR)\DesktopBackground.ico", System.Drawing.Imaging.ImageFormat.Icon);
            */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.png, *.jpg, *.bmp, *.ico)|*.png;*.jpg;*.bmp;*.ico";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK)
            {
                res = false;
                checkmark1.Visible = false;
            }
            else
            {
                res = true;
                checkmark1.Visible = true;
                guna2TextBox1.Text = openFileDialog1.FileName;
            }
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Browse for images";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Increment(2);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            res = false;
            checkmark1.Visible = false;
            guna2ProgressBar1.Value = 0;
            guna2TextBox1.Clear();
            timer1.Stop();
        }

        private void checkmark1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

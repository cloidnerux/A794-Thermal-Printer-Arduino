using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            Bitmap b = new Bitmap(ofd.FileName);
            OutputTextBox.Text = string.Empty;
            string result = string.Empty;
            result += "const unsigned char PROGMEM logo[] = {\n";
            byte tmp = 0;
            for (int w = 0; w < b.Width; w++)
            {
                tmp = 0;
                ImageProgressBar.Value = w / b.Width * 100;
                for (int h = 0; h < b.Height; h+=8)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        tmp |= (b.GetPixel(w, h + i).GetBrightness() < 0.5) ? ((byte)1) : ((byte)0);
                        tmp <<= 1;
                    }
                    result += "0x" + tmp.ToString("X2") + ", ";
                }
                result += "\n";
            }
            result += "};";
            OutputTextBox.Text = result;
        }
    }
}

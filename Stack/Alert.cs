using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Alert : Form
    {
        public enum AlertType
        {
            success, error
        }

        public Alert(string message, AlertType type)
        {
            InitializeComponent();

            messageInfo.Text = message;

            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.FromArgb(39, 174, 96);
                    break;
                case AlertType.error:
                    this.BackColor = Color.FromArgb(231, 76, 60);
                    break;
            }

            fadeIn.Start();
        }

        public static void showUp(string message, AlertType type)
        {
            new Alert(message, type).Show();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            this.Top = 30;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 30;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            timeOut.Stop();

            fadeOut.Start();
        }

        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.1;
            }
            else
            {
                fadeIn.Stop();
            }
        }

        public int interval = 0;

        private void FadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.1;

                this.Top += 2;
            }
            else
            {
                fadeOut.Stop();

                this.Close();
            }
        }

        private void TimeOut_Tick(object sender, EventArgs e)
        {
            fadeOut.Start();
        }
    }
}

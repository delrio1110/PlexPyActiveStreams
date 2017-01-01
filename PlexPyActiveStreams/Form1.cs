using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlexPyActiveStreams
{
    public partial class Form1 : Form
    {
        iniHandler iniSettings;
        static string activeStreams = "0";
        public Form1()
        {
            InitializeComponent();
            iniSettings = new iniHandler();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("PlexPyActiveStreams.ini"))
            {
                updateIni();
            }
            else
            {
                txtPPIP.Text = iniSettings.Read("PPIP");
                txtPPAPI.Text = iniSettings.Read("PPAPI");
            }
        }        

        private void btnPPSubmit_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            updateIni();
            getActiveStreams();
            timer.Start();      
        }

        private void updateIni()
        {
            iniSettings.Write("PPIP", txtPPIP.Text);
            iniSettings.Write("PPAPI", txtPPAPI.Text);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            getActiveStreams();
        }

        private void getActiveStreams()
        {
            using (var webClient = new System.Net.WebClient())
            {
                string url = "http://" + txtPPIP.Text + "/api/v2?apikey=" + txtPPAPI.Text + "&cmd=get_activity";
                string json = webClient.DownloadString(url);
                txtPPOutput.Text = json;
                dynamic data = JObject.Parse(json);
                activeStreams = data.response.data.stream_count;
                notifyIcon.Icon = updateIcon(activeStreams);
            }
        }

        private Icon updateIcon(string text)
        {
            Bitmap bitmap = new Bitmap(32, 32);

            Icon icon = Properties.Resources.icon;
            Font drawFont = new Font("Calibri", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            graphics.DrawIcon(icon, 0, 0);
            graphics.DrawString(text, drawFont, drawBrush, 1, 2);
            Icon createdIcon = Icon.FromHandle(bitmap.GetHicon());

            drawFont.Dispose();
            drawBrush.Dispose();
            graphics.Dispose();
            bitmap.Dispose();

            return createdIcon;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500, "Minimized to tray!", "PlexPy will be polled every minute for new data", ToolTipIcon.Info);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

    }
}

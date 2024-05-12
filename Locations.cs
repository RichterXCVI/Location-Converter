using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_Loc_Converter
{
    public partial class Locations : Form
    {
        private Font? customFont;
        private SoundPlayer? soundPlayer;

        public Locations()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadCustomFont();
            PreloadSound();
            SubscribeEvents();
            Shown += async (s, e) => await FadeIn();
        }

        private async Task FadeIn()
        {
            double opacityStep = 0.05;
            while (Opacity < 1)
            {
                Opacity += opacityStep;
                if (Opacity > 1)
                    Opacity = 1;
                await Task.Delay(20);
            }
        }

        private void SubscribeEvents()
        {
            txtInput.TextChanged += Txt_TextChanged;
            txtScript.TextChanged += Txt_TextChanged;
            txtInput.Click += (s, e) => txtResults.BackColor = SystemColors.ActiveCaption;
            txtResults.Click += (s, e) => txtResults.BackColor = string.IsNullOrEmpty(txtScript.Text.Trim()) ? Color.Red : SystemColors.Window;
        }

        private void Txt_TextChanged(object? sender, EventArgs e) => btnConvert.Enabled = !string.IsNullOrEmpty(txtScript.Text.Trim());

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
            string[] locations = txtInput.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string customPrefix = txtScript.Text.Trim();
            txtScript.BackColor = string.IsNullOrEmpty(customPrefix) ? Color.Red : SystemColors.ActiveCaption;
            foreach (string location in locations)
            {
                txtResults.AppendText(customPrefix + "{t:#s." + location + "}" + Environment.NewLine);
            }
            soundPlayer?.Play();
            btnConvert.Enabled = false;
        }

        private void LoadCustomFont()
        {
            using Stream? stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HM_Loc_Converter.WhiteRabbit.ttf");
            if (stream != null)
            {
                PrivateFontCollection privateFonts = new PrivateFontCollection();
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                IntPtr fontPtr = Marshal.AllocCoTaskMem(buffer.Length);
                Marshal.Copy(buffer, 0, fontPtr, buffer.Length);
                privateFonts.AddMemoryFont(fontPtr, buffer.Length);
                customFont = new Font(privateFonts.Families[0], 12f);
                Marshal.FreeCoTaskMem(fontPtr);
            }
        }

        private void PreloadSound() => soundPlayer = new SoundPlayer(Properties.Resources.sndConvert);
    }
}

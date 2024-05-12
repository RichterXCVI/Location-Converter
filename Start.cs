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
    public partial class Start : Form
    {
        private Font? customFont;
        private SoundPlayer soundPlayer = new SoundPlayer();

        public Start()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadCustomFont();
            PreloadSound();
            KeyPreview = true;
            KeyDown += async (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    soundPlayer.Play();
                    await FadeOutAndOpenLocations();
                }
            };
            Activate();
        }

        private async Task FadeOutAndOpenLocations()
        {
            double opacityStep = 0.1;
            while (Opacity > 0)
            {
                Opacity -= opacityStep;
                await Task.Delay(50);
            }
            Hide();
            var locationsForm = new Locations();
            locationsForm.FormClosed += (s, args) => Close();
            locationsForm.Show();
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
                customFont = privateFonts.Families.Length > 0 ? new Font(privateFonts.Families[0], 12f) : null;
                Marshal.FreeCoTaskMem(fontPtr);
            }
        }

        private void PreloadSound()
        {
            soundPlayer = new SoundPlayer(Properties.Resources.sndLogin);
            soundPlayer.Load();
        }
    }
}

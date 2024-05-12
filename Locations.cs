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
        private SoundPlayer? soundPlayer; // Declare soundPlayer as nullable

        public Locations()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadCustomFont();
            SetControlFonts();
            PreloadSound(); // Load the sound file
            txtInput.TextChanged += Txt_TextChanged;
            txtScript.TextChanged += Txt_TextChanged;
            txtInput.Click += (s, e) => txtResults.BackColor = SystemColors.ActiveCaption;
            txtResults.Click += (s, e) => txtResults.BackColor = string.IsNullOrEmpty(txtScript.Text.Trim()) ? Color.Red : SystemColors.Window;

            // Subscribe to the Shown event to trigger fade-in effect
            this.Shown += Locations_Shown!;
        }

        // Method to handle the Shown event and trigger fade-in effect
        private async void Locations_Shown(object sender, EventArgs e)
        {
            await FadeIn();
        }

        // Fade-in effect method
        private async Task FadeIn()
        {
            double opacityStep = 0.05; // Decrease the step size for smoother fade-in
            while (Opacity < 1)
            {
                Opacity += opacityStep;
                if (Opacity > 1) // Ensure Opacity doesn't exceed 1
                    Opacity = 1;
                await Task.Delay(20); // Increase the delay for a slower fade-in
            }
        }

        private void Txt_TextChanged(object? sender, EventArgs e) => btnConvert.Enabled = !string.IsNullOrEmpty(txtScript.Text.Trim());

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
            string[] locations = txtInput.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string customPrefix = txtScript.Text.Trim();
            if (string.IsNullOrEmpty(customPrefix))
            {
                txtScript.BackColor = Color.Red;
                return;
            }
            else
            {
                txtScript.BackColor = SystemColors.ActiveCaption;
            }
            foreach (string location in locations)
            {
                txtResults.AppendText(customPrefix + "{t:#s." + location + "}" + Environment.NewLine);
            }
            soundPlayer?.Play(); // Play the sound if soundPlayer is not null
            btnConvert.Enabled = false;
        }

        private void LoadCustomFont()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using Stream? stream = assembly.GetManifestResourceStream("HM_Loc_Converter.WhiteRabbit.ttf");
            if (stream != null)
            {
                PrivateFontCollection privateFonts = new PrivateFontCollection();
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                IntPtr fontPtr = Marshal.AllocCoTaskMem(buffer.Length);
                Marshal.Copy(buffer, 0, fontPtr, buffer.Length);
                privateFonts.AddMemoryFont(fontPtr, buffer.Length);
                if (privateFonts.Families.Length > 0)
                {
                    customFont = new Font(privateFonts.Families[0], 12f);
                    Marshal.FreeCoTaskMem(fontPtr);
                }
            }
        }

        private void SetControlFonts()
        {
            if (customFont != null)
            {
                foreach (Control control in Controls)
                {
                    if (control is Label lbl)
                    {
                        lbl.Font = customFont;
                    }
                    else if (control is TextBox txt)
                    {
                        txt.Font = customFont;
                    }
                }
            }
        }

        private void PreloadSound() => soundPlayer = new SoundPlayer(Properties.Resources.sndConvert);
    }
}

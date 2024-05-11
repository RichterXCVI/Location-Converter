using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadCustomFont();
            SetControlFonts();
            PreloadSound();
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    soundPlayer.Play();
                    Hide();
                    var locationsForm = new Locations();
                    locationsForm.FormClosed += (s, args) => Close();
                    locationsForm.Show();
                }
            };
            this.Activate();
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
                else
                {
                    Console.WriteLine("Failed to load the font.");
                }
            }
            else
            {
                Console.WriteLine("Failed to load the font resource.");
            }
        }

        private void SetControlFonts()
        {
            if (customFont != null)
            {
                foreach (Control control in Controls)
                {
                    if (control is Label lbl && lbl.Name.StartsWith("lbl"))
                    {
                        lbl.Font = customFont;
                    }
                    else if (control is TextBox txt && txt.Name.StartsWith("txt"))
                    {
                        txt.Font = customFont;
                    }
                }
            }
            else
            {
                Console.WriteLine("Custom font is null.");
            }
        }

        private void PreloadSound()
        {
            soundPlayer = new SoundPlayer(Properties.Resources.sndLogin);
            soundPlayer.Load();
        }
    }
}

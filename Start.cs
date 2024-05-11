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
        private Font? customFont; // Make the customFont field nullable
        private SoundPlayer soundPlayer;

        public Start()
        {
            InitializeComponent();

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Load the embedded font
            LoadCustomFont();

            // Set the font for controls
            SetControlFonts();

            // Preload the sound file
            soundPlayer = new SoundPlayer(); // Initialize the sound player
            PreloadSound();

            // Subscribe to the KeyDown event
            this.KeyPreview = true; // Allow form to receive key events even if not focused
            this.KeyDown += Start_KeyDown;

            // Set focus to the form itself
            this.Activate();
        }

        private void Start_KeyDown(object? sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Play the preloaded sound
                soundPlayer.Play();

                // Close only the Start form
                this.Hide();

                // Show the Locations form
                Locations locationsForm = new Locations();
                locationsForm.FormClosed += (s, args) => this.Close(); // Close the Start form when the Locations form is closed
                locationsForm.Show();
            }
        }

        private void LoadCustomFont()
        {
            // Read the font data from embedded resource
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream? stream = assembly.GetManifestResourceStream("HM_Loc_Converter.WhiteRabbit.ttf");
            if (stream != null)
            {
                using (stream)
                {
                    // Create a PrivateFontCollection
                    PrivateFontCollection privateFonts = new PrivateFontCollection();

                    // Load the font from the stream
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    IntPtr fontPtr = Marshal.AllocCoTaskMem(buffer.Length);
                    Marshal.Copy(buffer, 0, fontPtr, buffer.Length);
                    privateFonts.AddMemoryFont(fontPtr, buffer.Length);

                    // Check if the font was loaded successfully
                    if (privateFonts.Families.Length > 0)
                    {
                        // Create a Font object
                        customFont = new Font(privateFonts.Families[0], 12f); // Adjust the size as needed

                        // Free the memory
                        Marshal.FreeCoTaskMem(fontPtr);
                    }
                    else
                    {
                        // Log an error or display a message if the font was not loaded
                        Console.WriteLine("Failed to load the font.");
                    }
                }
            }
            else
            {
                // Handle the case when the resource stream is null (e.g., log a warning)
                Console.WriteLine("Failed to load the font resource.");
            }
        }

        private void SetControlFonts()
        {
            // Set the font for controls if customFont is not null
            if (customFont != null)
            {
                // Set the font for labels and textboxes starting with "lbl" or "txt"
                foreach (Control control in Controls)
                {
                    if (control is Label lbl && lbl.Name.StartsWith("lbl"))
                    {
                        lbl.Font = customFont!;
                    }
                    else if (control is TextBox txt && txt.Name.StartsWith("txt"))
                    {
                        txt.Font = customFont!;
                    }
                }
            }
            else
            {
                // Handle the case when customFont is null (e.g., log a warning)
                Console.WriteLine("Custom font is null.");
            }
        }

        private void PreloadSound()
        {
            // Load and initialize the sound player
            soundPlayer = new SoundPlayer(Properties.Resources.HMLClogin);
            soundPlayer.Load();
        }
    }
}

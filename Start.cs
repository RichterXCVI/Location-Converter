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
        // Declaring variables
        private Font? customFont;                                   // Custom font for the form
        private SoundPlayer soundPlayer = new SoundPlayer();        // Sound player for playing audio

        // Constructor for the Start form
        public Start()
        {
            InitializeComponent();                                  // Initialize form components
            StartPosition = FormStartPosition.CenterScreen;         // Set form start position to the center of the screen
            LoadCustomFont();                                       // Load custom font
            PreloadSound();                                         // Preload sound for later use
            KeyPreview = true;                                      // Allow form to preview keyboard input
            KeyDown += async (s, e) =>                              // Subscribe to KeyDown event asynchronously
            {
                if (e.KeyCode == Keys.Enter)                        // Check if the Enter key is pressed
                {
                    soundPlayer.Play();                             // Play the loaded sound
                    await FadeOutAndOpenLocations();                // Fade out the form and open the Locations form
                }
            };
            Activate();                                             // Activate the form
                                            
            this.Load += (s, e) => this.Focus();                    // Set focus to the form itself when it loads
        }

        // Method to fade out the form and open the Locations form
        private async Task FadeOutAndOpenLocations()
        {
            double opacityStep = 0.1;                               // Opacity decrement step
            while (Opacity > 0)                                     // Loop until form becomes completely transparent
            {
                Opacity -= opacityStep;                             // Decrease form opacity
                await Task.Delay(50);                               // Delay for smoother animation
            }   
            Hide();                                                 // Hide the form
            var locationsForm = new Locations();                    // Create a new instance of the Locations form
            locationsForm.FormClosed += (s, args) => Close();       // Subscribe to the FormClosed event to close the Start form when Locations form is closed
            locationsForm.Show();                                   // Show the Locations form
        }

        // Method to load a custom font for the form
        private void LoadCustomFont()
        {
            using Stream? stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HM_Loc_Converter.WhiteRabbit.ttf");       // Get the embedded resource stream for the custom font
            if (stream != null)                                                                                                         // Check if stream is not null
            {
                PrivateFontCollection privateFonts = new PrivateFontCollection();                                                       // Create a new PrivateFontCollection instance
                byte[] buffer = new byte[stream.Length];                                                                                // Create a buffer to store font data
                stream.Read(buffer, 0, buffer.Length);                                                                                  // Read font data from the stream
                IntPtr fontPtr = Marshal.AllocCoTaskMem(buffer.Length);                                                                 // Allocate memory for the font data
                Marshal.Copy(buffer, 0, fontPtr, buffer.Length);                                                                        // Copy font data to the allocated memory
                privateFonts.AddMemoryFont(fontPtr, buffer.Length);                                                                     // Add the font to the PrivateFontCollection
                customFont = privateFonts.Families.Length > 0 ? new Font(privateFonts.Families[0], 12f) : null;                         // Set the customFont variable to the loaded font, or null if loading failed
                Marshal.FreeCoTaskMem(fontPtr);                                                                                         // Free the allocated memory
            }
        }

        // Method to preload sound for later use
        private void PreloadSound()
        {
            soundPlayer = new SoundPlayer(Properties.Resources.sndLogin);       // Load sound from project resources
            soundPlayer.Load();                                                 // Load the sound into memory
        }
    }
}

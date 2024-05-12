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
                                                                    // Declaring variables
        private Font? customFont;                                   // Custom font for the form
        private SoundPlayer? soundPlayer;                           // Sound player for playing audio

        // Constructor for the Locations form
        public Locations()
        {
            InitializeComponent();                                  // Initialize form components
            StartPosition = FormStartPosition.CenterScreen;         // Set form start position to the center of the screen
            LoadCustomFont();                                       // Load custom font
            PreloadSound();                                         // Preload sound for later use
            SubscribeEvents();                                      // Subscribe to form events
            Shown += async (s, e) => await FadeIn();                // Subscribe to the Shown event to trigger fade-in animation when form is shown
        }

        // Method to perform fade-in animation
        private async Task FadeIn()
        {
            double opacityStep = 0.05;                              // Opacity increment step
            while (Opacity < 1)                                     // Loop until form becomes fully visible
            {
                Opacity += opacityStep;                             // Increase form opacity
                if (Opacity > 1)                                    // Ensure opacity doesn't exceed 1
                    Opacity = 1;
                await Task.Delay(20);                               // Delay for smoother animation
            }
        }

        // Method to subscribe to control events
        private void SubscribeEvents()
        {
            txtInput.TextChanged += Txt_TextChanged;                // Subscribe to TextChanged event of txtInput and txtScript controls
            txtScript.TextChanged += Txt_TextChanged;   
            txtInput.Click += (s, e) => txtResults.BackColor = SystemColors.ActiveCaption;                                                              // Change background color of txtResults when txtInput is clicked
            txtResults.Click += (s, e) => txtResults.BackColor = string.IsNullOrEmpty(txtScript.Text.Trim()) ? Color.Red : SystemColors.Window;         // Change background color of txtResults when txtResults is clicked
        }

        // Event handler for TextChanged event of txtInput and txtScript controls
        private void Txt_TextChanged(object? sender, EventArgs e) => btnConvert.Enabled = !string.IsNullOrEmpty(txtScript.Text.Trim());                 // Enable/disable btnConvert based on text input

        // Event handler for btnConvert click event
        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtResults.Clear();                                                                                                                         // Clear text in txtResults
            string[] locations = txtInput.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);                                      // Split input text into an array of locations
            string customPrefix = txtScript.Text.Trim();                                                                                                // Get custom prefix from txtScript
            txtScript.BackColor = string.IsNullOrEmpty(customPrefix) ? Color.Red : SystemColors.ActiveCaption;                                          // Change background color of txtScript based on input
            foreach (string location in locations)                                                                                                      // Iterate through each location
            {
                txtResults.AppendText(customPrefix + "{t:#s." + location + "}" + Environment.NewLine);                                                  // Append formatted location to txtResults
            }
            soundPlayer?.Play();                                                                                                                        // Play sound
            btnConvert.Enabled = false;                                                                                                                 // Disable btnConvert after conversion
        }

        // Method to load custom font
        private void LoadCustomFont()
        {   
            using Stream? stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("HM_Loc_Converter.WhiteRabbit.ttf");                       // Get embedded font resource stream
            if (stream != null)                                                                                                                         // Check if stream is not null
            {
                PrivateFontCollection privateFonts = new PrivateFontCollection();                                                                       // Create a new PrivateFontCollection instance
                byte[] buffer = new byte[stream.Length];                                                                                                // Create a buffer to store font data
                stream.Read(buffer, 0, buffer.Length);                                                                                                  // Read font data from stream
                IntPtr fontPtr = Marshal.AllocCoTaskMem(buffer.Length);                                                                                 // Allocate memory for font data
                Marshal.Copy(buffer, 0, fontPtr, buffer.Length);                                                                                        // Copy font data to allocated memory
                privateFonts.AddMemoryFont(fontPtr, buffer.Length);                                                                                     // Add font to PrivateFontCollection
                customFont = new Font(privateFonts.Families[0], 12f);                                                                                   // Create a new Font instance using the loaded font
                Marshal.FreeCoTaskMem(fontPtr);                                                                                                         // Free allocated memory
            }
        }

        // Method to preload sound
        private void PreloadSound() => soundPlayer = new SoundPlayer(Properties.Resources.sndConvert);                                                  // Load sound from resources
    }
}

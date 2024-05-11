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
    public partial class Locations : Form
    {
        private Font? customFont; // Make the customFont field nullable
        private SoundPlayer soundPlayer; // Remove the nullable annotation

        public Locations()
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
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Clear previous results
            txtResults.Clear();

            // Split the input text into lines
            string[] locations = txtInput.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Get the custom prefix from the txtScript textbox
            string customPrefix = txtScript.Text.Trim();

            // Check if the script prefix is empty
            if (string.IsNullOrEmpty(customPrefix))
            {
                // Highlight the txtScript textbox in red
                txtScript.BackColor = Color.Red;
                return; // Exit the method to prevent further processing
            }
            else
            {
                // Reset the background color of the txtScript textbox
                txtScript.BackColor = SystemColors.Window;
            }

            // Iterate through each location and append the converted string to results
            foreach (string location in locations)
            {
                // Replace "player.loc" with the current location
                string convertedLocation = customPrefix + "{t:#s." + location + "}";

                // Append the converted location to the results textbox with a newline
                txtResults.AppendText(convertedLocation + Environment.NewLine);
            }

            // Play the preloaded sound
            soundPlayer.Play();
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
                // Set the font for labels and textboxes
                foreach (Control control in Controls)
                {
                    if (control is Label lbl)
                    {
                        lbl.Font = customFont!;
                    }
                    else if (control is TextBox txt)
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
            soundPlayer = new SoundPlayer(Properties.Resources.HMLCconvert);
        }
    }
}

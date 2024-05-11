using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HM_Loc_Converter
{
    public partial class Locations : Form
    {
        private Font? customFont; // Make the customFont field nullable

        public Locations()
        {
            InitializeComponent();

            // Load the embedded font
            LoadCustomFont();

            // Set the font for controls
            SetControlFonts();

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
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
        }


        private void LoadCustomFont()
        {
            // Your existing code to load the custom font
        }

        private void SetControlFonts()
        {
            // Your existing code to set the font for controls
        }
    }
}

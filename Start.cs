using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HM_Loc_Converter
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Load the embedded font
            LoadCustomFont();

            // Set the font for controls
            SetControlFonts();

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
            // Your existing code to load the custom font
        }

        private void SetControlFonts()
        {
            // Your existing code to set the font for controls
        }
    }
}

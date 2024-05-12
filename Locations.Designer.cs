namespace HM_Loc_Converter
{
    partial class Locations
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locations));
            txtResults = new RichTextBox();
            btnConvert = new Button();
            lblInput = new Label();
            lblResults = new Label();
            txtScript = new TextBox();
            lblPrefix = new Label();
            txtInput = new TextBox();
            lblRichter = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtResults
            // 
            txtResults.BackColor = SystemColors.ActiveCaption;
            txtResults.Cursor = Cursors.IBeam;
            txtResults.Font = new Font("White Rabbit", 8.5F);
            txtResults.Location = new Point(9, 48);
            txtResults.Margin = new Padding(12);
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(447, 514);
            txtResults.TabIndex = 1;
            txtResults.Text = "";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.ButtonHighlight;
            btnConvert.FlatStyle = FlatStyle.Popup;
            btnConvert.Font = new Font("White Rabbit", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = SystemColors.ActiveCaptionText;
            btnConvert.Location = new Point(137, 572);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(188, 48);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.BackColor = SystemColors.InfoText;
            lblInput.Font = new Font("White Rabbit", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInput.ForeColor = Color.Fuchsia;
            lblInput.Location = new Point(602, 188);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(162, 18);
            lblInput.TabIndex = 3;
            lblInput.Text = "Paste Locs:";
            lblInput.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("White Rabbit", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResults.ForeColor = Color.Fuchsia;
            lblResults.Location = new Point(172, 25);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(120, 18);
            lblResults.TabIndex = 4;
            lblResults.Text = "Results:";
            // 
            // txtScript
            // 
            txtScript.BackColor = SystemColors.ActiveCaption;
            txtScript.Font = new Font("White Rabbit", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScript.Location = new Point(499, 67);
            txtScript.Name = "txtScript";
            txtScript.PlaceholderText = "Enter prefix [example:\"richter.t1cracker\"]";
            txtScript.Size = new Size(378, 17);
            txtScript.TabIndex = 5;
            txtScript.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPrefix
            // 
            lblPrefix.AutoSize = true;
            lblPrefix.Font = new Font("White Rabbit", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrefix.ForeColor = Color.Fuchsia;
            lblPrefix.Location = new Point(609, 47);
            lblPrefix.Name = "lblPrefix";
            lblPrefix.Size = new Size(161, 15);
            lblPrefix.TabIndex = 6;
            lblPrefix.Text = "Script Prefix:";
            // 
            // txtInput
            // 
            txtInput.BackColor = SystemColors.ActiveCaption;
            txtInput.Font = new Font("White Rabbit", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(501, 220);
            txtInput.Margin = new Padding(50, 50, 0, 0);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "unknown_jrttl_tkf3hq.public_yjlf2y";
            txtInput.Size = new Size(375, 397);
            txtInput.TabIndex = 7;
            // 
            // lblRichter
            // 
            lblRichter.AutoSize = true;
            lblRichter.BackColor = SystemColors.InfoText;
            lblRichter.Font = new Font("White Rabbit", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRichter.ForeColor = Color.Yellow;
            lblRichter.Location = new Point(502, 155);
            lblRichter.Name = "lblRichter";
            lblRichter.Size = new Size(180, 9);
            lblRichter.TabIndex = 8;
            lblRichter.Text = "Developed by: richterXCVI";
            lblRichter.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InfoText;
            label1.Font = new Font("White Rabbit", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(502, 139);
            label1.Name = "label1";
            label1.Size = new Size(131, 9);
            label1.TabIndex = 9;
            label1.Text = "Location Converter";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Locations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(887, 632);
            Controls.Add(label1);
            Controls.Add(lblRichter);
            Controls.Add(txtInput);
            Controls.Add(lblPrefix);
            Controls.Add(txtScript);
            Controls.Add(lblResults);
            Controls.Add(lblInput);
            Controls.Add(btnConvert);
            Controls.Add(txtResults);
            Cursor = Cursors.No;
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(907, 675);
            MinimumSize = new Size(907, 675);
            Name = "Locations";
            Text = "HM_Loc_Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox txtResults;
        private Button btnConvert;
        private Label lblInput;
        private Label lblResults;
        private TextBox txtScript;
        private Label lblPrefix;
        private TextBox txtInput;
        private Label lblRichter;
        private Label label1;
    }
}

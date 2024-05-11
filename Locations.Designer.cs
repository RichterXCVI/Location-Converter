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
            label1 = new Label();
            txtInput = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtResults
            // 
            txtResults.BackColor = SystemColors.ActiveCaption;
            txtResults.BorderStyle = BorderStyle.FixedSingle;
            txtResults.Cursor = Cursors.No;
            txtResults.Font = new Font("White Rabbit", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResults.Location = new Point(377, 201);
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(502, 350);
            txtResults.TabIndex = 1;
            txtResults.Text = "";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.GrayText;
            btnConvert.FlatStyle = FlatStyle.System;
            btnConvert.Font = new Font("White Rabbit", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = SystemColors.ActiveCaptionText;
            btnConvert.Location = new Point(84, 557);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(163, 48);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.BackColor = SystemColors.InfoText;
            lblInput.Font = new Font("White Rabbit", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInput.ForeColor = Color.Fuchsia;
            lblInput.Location = new Point(101, 26);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(117, 15);
            lblInput.TabIndex = 3;
            lblInput.Text = "Paste Locs";
            lblInput.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("White Rabbit", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResults.ForeColor = Color.Fuchsia;
            lblResults.Location = new Point(575, 166);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(84, 15);
            lblResults.TabIndex = 4;
            lblResults.Text = "Results";
            // 
            // txtScript
            // 
            txtScript.BackColor = SystemColors.InactiveCaption;
            txtScript.Location = new Point(427, 65);
            txtScript.Name = "txtScript";
            txtScript.PlaceholderText = "Enter script here [ex:\"richter.t1cracker\"]";
            txtScript.Size = new Size(398, 23);
            txtScript.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("White Rabbit", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(551, 36);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 6;
            label1.Text = "Script Prefix";
            // 
            // txtInput
            // 
            txtInput.BackColor = SystemColors.ActiveCaption;
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Font = new Font("White Rabbit", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(12, 47);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "unknown_jrttl_tkf3hq.public_yjlf2y";
            txtInput.Size = new Size(319, 504);
            txtInput.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InfoText;
            label2.Font = new Font("White Rabbit", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(748, 611);
            label2.Name = "label2";
            label2.Size = new Size(110, 9);
            label2.TabIndex = 8;
            label2.Text = "By: richterXCVI";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Locations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(891, 635);
            Controls.Add(label2);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Controls.Add(txtScript);
            Controls.Add(lblResults);
            Controls.Add(lblInput);
            Controls.Add(btnConvert);
            Controls.Add(txtResults);
            Cursor = Cursors.No;
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(907, 674);
            MinimumSize = new Size(907, 674);
            Name = "Locations";
            Text = "HM-Loc Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox txtResults;
        private Button btnConvert;
        private Label lblInput;
        private Label lblResults;
        private TextBox txtScript;
        private Label label1;
        private TextBox txtInput;
        private Label label2;
    }
}

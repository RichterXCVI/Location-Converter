namespace HM_Loc_Converter
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            txtStart = new TextBox();
            txtPress = new TextBox();
            SuspendLayout();
            // 
            // txtStart
            // 
            txtStart.BackColor = SystemColors.Desktop;
            txtStart.BorderStyle = BorderStyle.None;
            txtStart.Cursor = Cursors.No;
            txtStart.Font = new Font("White Rabbit", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStart.ForeColor = Color.Lime;
            txtStart.Location = new Point(12, 12);
            txtStart.MaximumSize = new Size(763, 211);
            txtStart.MinimumSize = new Size(763, 211);
            txtStart.Multiline = true;
            txtStart.Name = "txtStart";
            txtStart.ReadOnly = true;
            txtStart.RightToLeft = RightToLeft.No;
            txtStart.Size = new Size(763, 211);
            txtStart.TabIndex = 0;
            txtStart.Text = resources.GetString("txtStart.Text");
            // 
            // txtPress
            // 
            txtPress.BackColor = SystemColors.Desktop;
            txtPress.BorderStyle = BorderStyle.None;
            txtPress.Cursor = Cursors.No;
            txtPress.Font = new Font("White Rabbit", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPress.ForeColor = Color.Red;
            txtPress.Location = new Point(220, 247);
            txtPress.MaximumSize = new Size(280, 16);
            txtPress.MinimumSize = new Size(280, 16);
            txtPress.Name = "txtPress";
            txtPress.ReadOnly = true;
            txtPress.Size = new Size(280, 16);
            txtPress.TabIndex = 1;
            txtPress.Text = "PRESS ENTER TO CONTINUE";
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(771, 284);
            Controls.Add(txtPress);
            Controls.Add(txtStart);
            Cursor = Cursors.No;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(771, 284);
            MinimumSize = new Size(771, 284);
            Name = "Start";
            Text = "Start";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStart;
        private TextBox txtPress;
    }
}
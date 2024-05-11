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
            txtStart3 = new TextBox();
            txtStart1 = new TextBox();
            textBox3 = new TextBox();
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
            txtStart.MaximumSize = new Size(747, 69);
            txtStart.MinimumSize = new Size(747, 69);
            txtStart.Multiline = true;
            txtStart.Name = "txtStart";
            txtStart.ReadOnly = true;
            txtStart.RightToLeft = RightToLeft.No;
            txtStart.Size = new Size(747, 69);
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
            txtPress.Location = new Point(229, 246);
            txtPress.MaximumSize = new Size(280, 16);
            txtPress.MinimumSize = new Size(280, 16);
            txtPress.Name = "txtPress";
            txtPress.ReadOnly = true;
            txtPress.Size = new Size(280, 16);
            txtPress.TabIndex = 1;
            txtPress.Text = "PRESS ENTER TO CONTINUE";
            // 
            // txtStart3
            // 
            txtStart3.BackColor = SystemColors.Desktop;
            txtStart3.BorderStyle = BorderStyle.None;
            txtStart3.Cursor = Cursors.No;
            txtStart3.Font = new Font("White Rabbit", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStart3.ForeColor = Color.Lime;
            txtStart3.Location = new Point(12, 170);
            txtStart3.MaximumSize = new Size(747, 57);
            txtStart3.MinimumSize = new Size(747, 57);
            txtStart3.Multiline = true;
            txtStart3.Name = "txtStart3";
            txtStart3.ReadOnly = true;
            txtStart3.RightToLeft = RightToLeft.No;
            txtStart3.Size = new Size(747, 57);
            txtStart3.TabIndex = 2;
            txtStart3.Text = resources.GetString("txtStart3.Text");
            // 
            // txtStart1
            // 
            txtStart1.BackColor = SystemColors.Desktop;
            txtStart1.BorderStyle = BorderStyle.None;
            txtStart1.Cursor = Cursors.No;
            txtStart1.Font = new Font("White Rabbit", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStart1.ForeColor = Color.Cyan;
            txtStart1.Location = new Point(8, 75);
            txtStart1.Multiline = true;
            txtStart1.Name = "txtStart1";
            txtStart1.ReadOnly = true;
            txtStart1.RightToLeft = RightToLeft.No;
            txtStart1.Size = new Size(747, 89);
            txtStart1.TabIndex = 3;
            txtStart1.Text = resources.GetString("txtStart1.Text");
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Desktop;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Cursor = Cursors.No;
            textBox3.Font = new Font("White Rabbit", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Yellow;
            textBox3.Location = new Point(68, 32);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(78, 10);
            textBox3.TabIndex = 4;
            textBox3.Text = "richterXCVI";
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(771, 284);
            Controls.Add(textBox3);
            Controls.Add(txtStart1);
            Controls.Add(txtStart3);
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
        private TextBox txtStart3;
        private TextBox txtStart1;
        private TextBox textBox3;
    }
}
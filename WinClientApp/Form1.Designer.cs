namespace WinClientApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contentControl1 = new View.ContentControl();
            SuspendLayout();
            // 
            // contentControl1
            // 
            contentControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentControl1.Location = new Point(12, 12);
            contentControl1.Name = "contentControl1";
            contentControl1.Size = new Size(760, 337);
            contentControl1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(784, 361);
            Controls.Add(contentControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 350);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinClient Application";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private View.ContentControl contentControl1;
    }
}
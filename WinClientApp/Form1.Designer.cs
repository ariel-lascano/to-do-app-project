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
            formContent2 = new View.FormContent();
            SuspendLayout();
            // 
            // formContent2
            // 
            formContent2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formContent2.Location = new Point(12, 12);
            formContent2.Name = "formContent2";
            formContent2.Size = new Size(760, 387);
            formContent2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(784, 411);
            Controls.Add(formContent2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 350);
            Name = "Form1";
            Text = "WinClientApp";
            ResumeLayout(false);
        }

        #endregion

        private View.FormContent formContent1;
        private View.FormContent formContent2;
    }
}
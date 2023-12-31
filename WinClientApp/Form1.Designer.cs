﻿namespace WinClientApp
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
            logonButton = new Button();
            contentControl = new View.ContentControl();
            refreshButton = new Button();
            SuspendLayout();
            // 
            // logonButton
            // 
            logonButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logonButton.AutoSize = true;
            logonButton.BackColor = SystemColors.Window;
            logonButton.BackgroundImageLayout = ImageLayout.Stretch;
            logonButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            logonButton.Image = Properties.Resources.user_32;
            logonButton.Location = new Point(682, 2);
            logonButton.Name = "logonButton";
            logonButton.Size = new Size(71, 38);
            logonButton.TabIndex = 4;
            logonButton.Text = "test";
            logonButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            logonButton.UseVisualStyleBackColor = false;
            // 
            // contentControl
            // 
            contentControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentControl.Location = new Point(12, 49);
            contentControl.Name = "contentControl";
            contentControl.Size = new Size(760, 300);
            contentControl.TabIndex = 5;
            // 
            // refreshButton
            // 
            refreshButton.BackgroundImage = Properties.Resources.EventWarning_16x;
            refreshButton.BackgroundImageLayout = ImageLayout.Center;
            refreshButton.Location = new Point(14, 7);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(47, 28);
            refreshButton.TabIndex = 7;
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Visible = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(784, 361);
            Controls.Add(refreshButton);
            Controls.Add(contentControl);
            Controls.Add(logonButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 350);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinClientApp";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button logonButton;
        private View.ContentControl contentControl;
        private Button refreshButton;
    }
}
namespace WinClientApp.View
{
    partial class ContentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Todo items list");
            treeView1 = new TreeView();
            propertyGrid1 = new PropertyGrid();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeView1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            treeView1.Location = new Point(3, 24);
            treeView1.Margin = new Padding(5);
            treeView1.Name = "treeView1";
            treeNode1.Name = "rootNode";
            treeNode1.Text = "Todo items list";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1 });
            treeView1.Size = new Size(294, 159);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            propertyGrid1.BackColor = SystemColors.ControlLight;
            propertyGrid1.Location = new Point(3, 189);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(294, 208);
            propertyGrid1.TabIndex = 1;
            propertyGrid1.ToolbarVisible = false;
            // 
            // ContentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(propertyGrid1);
            Controls.Add(treeView1);
            Name = "ContentControl";
            Size = new Size(300, 400);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private PropertyGrid propertyGrid1;
    }
}

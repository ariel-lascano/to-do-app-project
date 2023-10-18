namespace WinClientApp.View
{
    partial class FormContent
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
            TreeNode treeNode1 = new TreeNode("");
            backgroundPanel = new Panel();
            dataGridView = new DataGridView();
            priorityColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            descriptionColumn = new DataGridViewTextBoxColumn();
            newGroupButton = new Button();
            treeViewItems = new TreeView();
            backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.BackColor = SystemColors.Window;
            backgroundPanel.Controls.Add(dataGridView);
            backgroundPanel.Controls.Add(newGroupButton);
            backgroundPanel.Controls.Add(treeViewItems);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(700, 350);
            backgroundPanel.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.Window;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { priorityColumn, nameColumn, descriptionColumn });
            dataGridView.Location = new Point(298, 41);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(386, 296);
            dataGridView.TabIndex = 4;
            // 
            // priorityColumn
            // 
            priorityColumn.HeaderText = "Priority";
            priorityColumn.Name = "priorityColumn";
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "nameColumn";
            // 
            // descriptionColumn
            // 
            descriptionColumn.HeaderText = "Description";
            descriptionColumn.Name = "descriptionColumn";
            // 
            // newGroupButton
            // 
            newGroupButton.Image = Properties.Resources.Group;
            newGroupButton.Location = new Point(12, 5);
            newGroupButton.Name = "newGroupButton";
            newGroupButton.Size = new Size(92, 30);
            newGroupButton.TabIndex = 3;
            newGroupButton.Text = "New group";
            newGroupButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            newGroupButton.UseVisualStyleBackColor = true;
            // 
            // treeViewItems
            // 
            treeViewItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeViewItems.BackColor = SystemColors.Window;
            treeViewItems.Location = new Point(12, 41);
            treeViewItems.Name = "treeViewItems";
            treeNode1.Name = "RootNode";
            treeNode1.Text = "";
            treeViewItems.Nodes.AddRange(new TreeNode[] { treeNode1 });
            treeViewItems.Size = new Size(280, 296);
            treeViewItems.TabIndex = 2;
            // 
            // FormContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backgroundPanel);
            Name = "FormContent";
            Size = new Size(700, 350);
            backgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel backgroundPanel;
        private Button newGroupButton;
        private TreeView treeViewItems;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn priorityColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn descriptionColumn;
    }
}

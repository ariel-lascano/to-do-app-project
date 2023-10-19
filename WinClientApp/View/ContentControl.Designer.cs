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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            treeView = new TreeView();
            upButton = new Button();
            downButton = new Button();
            cancelButton = new Button();
            newItemButton = new Button();
            dataGridView = new DataGridView();
            priorityColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            descriptionColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeView.BackColor = SystemColors.Window;
            treeView.BorderStyle = BorderStyle.FixedSingle;
            treeView.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            treeView.ForeColor = SystemColors.WindowFrame;
            treeView.Location = new Point(55, 5);
            treeView.Margin = new Padding(5);
            treeView.Name = "treeView";
            treeNode1.Name = "rootNode";
            treeNode1.Text = "Todo items list";
            treeView.Nodes.AddRange(new TreeNode[] { treeNode1 });
            treeView.Size = new Size(200, 280);
            treeView.TabIndex = 0;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // upButton
            // 
            upButton.BackgroundImage = Properties.Resources.ArrowUpEnd;
            upButton.BackgroundImageLayout = ImageLayout.Center;
            upButton.Location = new Point(3, 62);
            upButton.Name = "upButton";
            upButton.Size = new Size(47, 28);
            upButton.TabIndex = 2;
            upButton.UseVisualStyleBackColor = true;
            upButton.Click += upButton_Click;
            // 
            // downButton
            // 
            downButton.BackgroundImage = Properties.Resources.ArrowDownEnd;
            downButton.BackgroundImageLayout = ImageLayout.Center;
            downButton.Location = new Point(3, 89);
            downButton.Name = "downButton";
            downButton.Size = new Size(47, 28);
            downButton.TabIndex = 3;
            downButton.UseVisualStyleBackColor = true;
            downButton.Click += downButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelButton.BackgroundImage = Properties.Resources.Delete;
            cancelButton.BackgroundImageLayout = ImageLayout.Center;
            cancelButton.Location = new Point(3, 257);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(47, 28);
            cancelButton.TabIndex = 4;
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // newItemButton
            // 
            newItemButton.BackgroundImage = Properties.Resources.AddRow;
            newItemButton.BackgroundImageLayout = ImageLayout.Center;
            newItemButton.Location = new Point(3, 5);
            newItemButton.Name = "newItemButton";
            newItemButton.Size = new Size(47, 28);
            newItemButton.TabIndex = 6;
            newItemButton.UseVisualStyleBackColor = true;
            newItemButton.Click += newItemButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = SystemColors.Window;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { priorityColumn, nameColumn, descriptionColumn });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.GridColor = SystemColors.Control;
            dataGridView.Location = new Point(263, 5);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(318, 280);
            dataGridView.TabIndex = 8;
            // 
            // priorityColumn
            // 
            priorityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            priorityColumn.DefaultCellStyle = dataGridViewCellStyle3;
            priorityColumn.HeaderText = "Priority";
            priorityColumn.Name = "priorityColumn";
            priorityColumn.ReadOnly = true;
            priorityColumn.Width = 74;
            // 
            // nameColumn
            // 
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nameColumn.DefaultCellStyle = dataGridViewCellStyle4;
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "nameColumn";
            nameColumn.Width = 68;
            // 
            // descriptionColumn
            // 
            descriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            descriptionColumn.DefaultCellStyle = dataGridViewCellStyle5;
            descriptionColumn.HeaderText = "Description";
            descriptionColumn.Name = "descriptionColumn";
            // 
            // ContentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView);
            Controls.Add(downButton);
            Controls.Add(upButton);
            Controls.Add(newItemButton);
            Controls.Add(cancelButton);
            Controls.Add(treeView);
            Name = "ContentControl";
            Size = new Size(600, 300);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private Button upButton;
        private Button downButton;
        private Button cancelButton;
        private Button newItemButton;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn priorityColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn descriptionColumn;
    }
}

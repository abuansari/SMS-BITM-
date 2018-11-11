namespace StockManagementSystem
{
    partial class CategorySetup
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
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryListDataGridView = new System.Windows.Forms.DataGridView();
            this.hiddenLebel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.emptyFileLebel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(102, 73);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(111, 35);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(108, 35);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(222, 20);
            this.categoryNameTextBox.TabIndex = 2;
            // 
            // categoryListDataGridView
            // 
            this.categoryListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryListDataGridView.Location = new System.Drawing.Point(27, 160);
            this.categoryListDataGridView.Name = "categoryListDataGridView";
            this.categoryListDataGridView.Size = new System.Drawing.Size(382, 150);
            this.categoryListDataGridView.TabIndex = 3;
            this.categoryListDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryListDataGridView_CellDoubleClick);
            // 
            // hiddenLebel
            // 
            this.hiddenLebel.AutoSize = true;
            this.hiddenLebel.Location = new System.Drawing.Point(110, 120);
            this.hiddenLebel.Name = "hiddenLebel";
            this.hiddenLebel.Size = new System.Drawing.Size(0, 13);
            this.hiddenLebel.TabIndex = 4;
            this.hiddenLebel.Visible = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(219, 73);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(111, 35);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // emptyFileLebel
            // 
            this.emptyFileLebel.AutoSize = true;
            this.emptyFileLebel.Location = new System.Drawing.Point(383, 35);
            this.emptyFileLebel.Name = "emptyFileLebel";
            this.emptyFileLebel.Size = new System.Drawing.Size(0, 13);
            this.emptyFileLebel.TabIndex = 0;
            // 
            // CategorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 341);
            this.Controls.Add(this.hiddenLebel);
            this.Controls.Add(this.categoryListDataGridView);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.emptyFileLebel);
            this.Controls.Add(this.label1);
            this.Name = "CategorySetup";
            this.Text = "CategorySetup Setup";
            this.Load += new System.EventHandler(this.CategorySetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.DataGridView categoryListDataGridView;
        private System.Windows.Forms.Label hiddenLebel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label emptyFileLebel;
    }
}


namespace CSharpPractice
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
            PartsDataGridView = new DataGridView();
            searchButton1 = new Button();
            ProductsDataGridView = new DataGridView();
            InventoryManagementSystemLabel = new Label();
            productsLabel = new Label();
            partsLabel = new Label();
            partsTextBox = new TextBox();
            productsTextBox = new TextBox();
            searchButton2 = new Button();
            addButton2 = new Button();
            modifyButton2 = new Button();
            deleteButton2 = new Button();
            addButton1 = new Button();
            modifyButton1 = new Button();
            deleteButton1 = new Button();
            exitButton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PartsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PartsDataGridView
            // 
            PartsDataGridView.AllowUserToAddRows = false;
            PartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsDataGridView.Location = new Point(12, 182);
            PartsDataGridView.MultiSelect = false;
            PartsDataGridView.Name = "PartsDataGridView";
            PartsDataGridView.ReadOnly = true;
            PartsDataGridView.RowHeadersVisible = false;
            PartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsDataGridView.Size = new Size(584, 298);
            PartsDataGridView.TabIndex = 0;
            // 
            // searchButton1
            // 
            searchButton1.Location = new Point(353, 140);
            searchButton1.Name = "searchButton1";
            searchButton1.Size = new Size(54, 23);
            searchButton1.TabIndex = 1;
            searchButton1.Text = "Search";
            searchButton1.UseVisualStyleBackColor = true;
            searchButton1.Click += addPartButton_Click;
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AllowUserToAddRows = false;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(626, 182);
            ProductsDataGridView.MultiSelect = false;
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.ReadOnly = true;
            ProductsDataGridView.RowHeadersVisible = false;
            ProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGridView.Size = new Size(585, 298);
            ProductsDataGridView.TabIndex = 2;
            // 
            // InventoryManagementSystemLabel
            // 
            InventoryManagementSystemLabel.AutoSize = true;
            InventoryManagementSystemLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            InventoryManagementSystemLabel.Location = new Point(12, 27);
            InventoryManagementSystemLabel.Name = "InventoryManagementSystemLabel";
            InventoryManagementSystemLabel.Size = new Size(338, 30);
            InventoryManagementSystemLabel.TabIndex = 3;
            InventoryManagementSystemLabel.Text = "Inventory Management System";
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Segoe UI", 12F);
            productsLabel.Location = new Point(626, 149);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(71, 21);
            productsLabel.TabIndex = 4;
            productsLabel.Text = "Products";
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new Font("Segoe UI", 12F);
            partsLabel.Location = new Point(12, 149);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(44, 21);
            partsLabel.TabIndex = 5;
            partsLabel.Text = "Parts";
            // 
            // partsTextBox
            // 
            partsTextBox.Location = new Point(413, 140);
            partsTextBox.Name = "partsTextBox";
            partsTextBox.Size = new Size(183, 23);
            partsTextBox.TabIndex = 6;
            // 
            // productsTextBox
            // 
            productsTextBox.Location = new Point(1026, 140);
            productsTextBox.Name = "productsTextBox";
            productsTextBox.Size = new Size(183, 23);
            productsTextBox.TabIndex = 7;
            // 
            // searchButton2
            // 
            searchButton2.Location = new Point(963, 140);
            searchButton2.Name = "searchButton2";
            searchButton2.Size = new Size(54, 23);
            searchButton2.TabIndex = 8;
            searchButton2.Text = "Search";
            searchButton2.UseVisualStyleBackColor = true;
            searchButton2.Click += searchButton2_Click;
            // 
            // addButton2
            // 
            addButton2.Location = new Point(972, 500);
            addButton2.Name = "addButton2";
            addButton2.Size = new Size(75, 23);
            addButton2.TabIndex = 9;
            addButton2.Text = "Add";
            addButton2.UseVisualStyleBackColor = true;
            addButton2.Click += addButton2_Click;
            // 
            // modifyButton2
            // 
            modifyButton2.Location = new Point(1053, 500);
            modifyButton2.Name = "modifyButton2";
            modifyButton2.Size = new Size(75, 23);
            modifyButton2.TabIndex = 10;
            modifyButton2.Text = "Modify";
            modifyButton2.UseVisualStyleBackColor = true;
            modifyButton2.Click += modifyButton2_Click;
            // 
            // deleteButton2
            // 
            deleteButton2.Location = new Point(1134, 500);
            deleteButton2.Name = "deleteButton2";
            deleteButton2.Size = new Size(75, 23);
            deleteButton2.TabIndex = 11;
            deleteButton2.Text = "Delete";
            deleteButton2.UseVisualStyleBackColor = true;
            deleteButton2.Click += deleteButton2_Click;
            // 
            // addButton1
            // 
            addButton1.Location = new Point(359, 500);
            addButton1.Name = "addButton1";
            addButton1.Size = new Size(75, 23);
            addButton1.TabIndex = 12;
            addButton1.Text = "Add";
            addButton1.UseVisualStyleBackColor = true;
            addButton1.Click += addButton1_Click;
            // 
            // modifyButton1
            // 
            modifyButton1.Location = new Point(440, 500);
            modifyButton1.Name = "modifyButton1";
            modifyButton1.Size = new Size(75, 23);
            modifyButton1.TabIndex = 13;
            modifyButton1.Text = "Modify";
            modifyButton1.UseVisualStyleBackColor = true;
            modifyButton1.Click += modifyButton1_Click;
            // 
            // deleteButton1
            // 
            deleteButton1.Location = new Point(521, 500);
            deleteButton1.Name = "deleteButton1";
            deleteButton1.Size = new Size(75, 23);
            deleteButton1.TabIndex = 14;
            deleteButton1.Text = "Delete";
            deleteButton1.UseVisualStyleBackColor = true;
            deleteButton1.Click += deleteButton1_Click;
            // 
            // exitButton1
            // 
            exitButton1.Location = new Point(1134, 561);
            exitButton1.Name = "exitButton1";
            exitButton1.Size = new Size(75, 23);
            exitButton1.TabIndex = 15;
            exitButton1.Text = "Exit";
            exitButton1.UseVisualStyleBackColor = true;
            exitButton1.Click += exitButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 661);
            Controls.Add(exitButton1);
            Controls.Add(deleteButton1);
            Controls.Add(modifyButton1);
            Controls.Add(addButton1);
            Controls.Add(deleteButton2);
            Controls.Add(modifyButton2);
            Controls.Add(addButton2);
            Controls.Add(searchButton2);
            Controls.Add(productsTextBox);
            Controls.Add(partsTextBox);
            Controls.Add(partsLabel);
            Controls.Add(productsLabel);
            Controls.Add(InventoryManagementSystemLabel);
            Controls.Add(ProductsDataGridView);
            Controls.Add(searchButton1);
            Controls.Add(PartsDataGridView);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PartsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InventoryManagementSystemLabel;
        private DataGridView PartsDataGridView;
        private DataGridView ProductsDataGridView;
        private Button searchButton1;
        private Button searchButton2;
        private Label productsLabel;
        private Label partsLabel;
        private TextBox partsTextBox;
        private TextBox productsTextBox;
        private Button addButton1;
        private Button addButton2;
        private Button deleteButton1;
        private Button modifyButton2;
        private Button modifyButton1;
        private Button deleteButton2;
        private Button exitButton1;
    }
}

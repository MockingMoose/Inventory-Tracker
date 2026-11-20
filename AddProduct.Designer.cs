namespace CSharpPractice
{
    partial class AddProduct
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
            candidatePartsDataGridView = new DataGridView();
            associatedPartsDataGridView = new DataGridView();
            label1 = new Label();
            allCandidatePartsLabel = new Label();
            addProductLabel = new Label();
            addButton = new Button();
            searchButton = new Button();
            deleteButton = new Button();
            button4 = new Button();
            saveButton = new Button();
            nameTextBox = new TextBox();
            inventoryTextBox = new TextBox();
            priceTextBox = new TextBox();
            maxTextBox = new TextBox();
            minTextBox = new TextBox();
            minLabel = new Label();
            maxLabel = new Label();
            priceLabel = new Label();
            inventoryLabel = new Label();
            nameLabel = new Label();
            idLabel = new Label();
            partsTextBox = new TextBox();
            idTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)candidatePartsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // candidatePartsDataGridView
            // 
            candidatePartsDataGridView.AllowUserToAddRows = false;
            candidatePartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            candidatePartsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            candidatePartsDataGridView.Location = new Point(397, 75);
            candidatePartsDataGridView.MultiSelect = false;
            candidatePartsDataGridView.Name = "candidatePartsDataGridView";
            candidatePartsDataGridView.ReadOnly = true;
            candidatePartsDataGridView.RowHeadersVisible = false;
            candidatePartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            candidatePartsDataGridView.Size = new Size(573, 150);
            candidatePartsDataGridView.TabIndex = 0;
            // 
            // associatedPartsDataGridView
            // 
            associatedPartsDataGridView.AllowUserToAddRows = false;
            associatedPartsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedPartsDataGridView.Location = new Point(397, 296);
            associatedPartsDataGridView.MultiSelect = false;
            associatedPartsDataGridView.Name = "associatedPartsDataGridView";
            associatedPartsDataGridView.ReadOnly = true;
            associatedPartsDataGridView.RowHeadersVisible = false;
            associatedPartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedPartsDataGridView.Size = new Size(573, 150);
            associatedPartsDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(397, 277);
            label1.Name = "label1";
            label1.Size = new Size(186, 15);
            label1.TabIndex = 2;
            label1.Text = "Parts Associated with this Product";
            // 
            // allCandidatePartsLabel
            // 
            allCandidatePartsLabel.AutoSize = true;
            allCandidatePartsLabel.Location = new Point(397, 57);
            allCandidatePartsLabel.Name = "allCandidatePartsLabel";
            allCandidatePartsLabel.Size = new Size(107, 15);
            allCandidatePartsLabel.TabIndex = 3;
            allCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addProductLabel.Location = new Point(33, 24);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(105, 21);
            addProductLabel.TabIndex = 4;
            addProductLabel.Text = "Add Product";
            // 
            // addButton
            // 
            addButton.Location = new Point(901, 232);
            addButton.Name = "addButton";
            addButton.Size = new Size(48, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(738, 36);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(59, 23);
            searchButton.TabIndex = 6;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(874, 453);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(874, 488);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(778, 488);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(118, 189);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(184, 23);
            nameTextBox.TabIndex = 11;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(118, 232);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(184, 23);
            inventoryTextBox.TabIndex = 12;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(118, 277);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(184, 23);
            priceTextBox.TabIndex = 13;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(69, 328);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(100, 23);
            maxTextBox.TabIndex = 14;
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(254, 328);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(100, 23);
            minTextBox.TabIndex = 15;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(208, 331);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(28, 15);
            minLabel.TabIndex = 16;
            minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Location = new Point(24, 331);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(29, 15);
            maxLabel.TabIndex = 17;
            maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(56, 280);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(33, 15);
            priceLabel.TabIndex = 18;
            priceLabel.Text = "Price";
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Location = new Point(38, 236);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(57, 15);
            inventoryLabel.TabIndex = 19;
            inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(56, 197);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(77, 150);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 21;
            idLabel.Text = "ID";
            // 
            // partsTextBox
            // 
            partsTextBox.Location = new Point(803, 37);
            partsTextBox.Name = "partsTextBox";
            partsTextBox.Size = new Size(167, 23);
            partsTextBox.TabIndex = 22;
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(118, 150);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(184, 23);
            idTextBox.TabIndex = 23;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 552);
            Controls.Add(idTextBox);
            Controls.Add(partsTextBox);
            Controls.Add(idLabel);
            Controls.Add(nameLabel);
            Controls.Add(inventoryLabel);
            Controls.Add(priceLabel);
            Controls.Add(maxLabel);
            Controls.Add(minLabel);
            Controls.Add(minTextBox);
            Controls.Add(maxTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(inventoryTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(saveButton);
            Controls.Add(button4);
            Controls.Add(deleteButton);
            Controls.Add(searchButton);
            Controls.Add(addButton);
            Controls.Add(addProductLabel);
            Controls.Add(allCandidatePartsLabel);
            Controls.Add(label1);
            Controls.Add(associatedPartsDataGridView);
            Controls.Add(candidatePartsDataGridView);
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)candidatePartsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView candidatePartsDataGridView;
        private DataGridView associatedPartsDataGridView;
        private Label label1;
        private Label allCandidatePartsLabel;
        private Label addProductLabel;
        private Button addButton;
        private Button searchButton;
        private Button deleteButton;
        private Button button4;
        private Button saveButton;
        private TextBox textBox1;
        private TextBox nameTextBox;
        private TextBox inventoryTextBox;
        private TextBox priceTextBox;
        private TextBox maxTextBox;
        private TextBox minTextBox;
        private Label minLabel;
        private Label maxLabel;
        private Label priceLabel;
        private Label inventoryLabel;
        private Label nameLabel;
        private Label idLabel;
        private TextBox partsTextBox;
        private TextBox idTextBox;
    }
}
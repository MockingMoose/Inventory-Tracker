namespace CSharpPractice
{
    partial class AddPart
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
            label1 = new Label();
            radioInHouse = new RadioButton();
            radioOutsourced = new RadioButton();
            nameTextBox = new TextBox();
            priceTextBox = new TextBox();
            maxTextBox = new TextBox();
            nameOrIDTextBox = new TextBox();
            idTextBox = new TextBox();
            inventoryTextBox = new TextBox();
            minTextBox = new TextBox();
            saveButton1 = new Button();
            cancelButton1 = new Button();
            idLabel = new Label();
            nameLabel = new Label();
            inventoryLabel = new Label();
            priceLabel = new Label();
            maxLabel = new Label();
            minLabel = new Label();
            nameOrIDLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // radioInHouse
            // 
            radioInHouse.AutoSize = true;
            radioInHouse.Font = new Font("Segoe UI", 12F);
            radioInHouse.Location = new Point(177, 25);
            radioInHouse.Name = "radioInHouse";
            radioInHouse.Size = new Size(91, 25);
            radioInHouse.TabIndex = 1;
            radioInHouse.TabStop = true;
            radioInHouse.Text = "In-House";
            radioInHouse.UseVisualStyleBackColor = true;
            radioInHouse.CheckedChanged += radioInHouse_CheckedChanged;
            // 
            // radioOutsourced
            // 
            radioOutsourced.AutoSize = true;
            radioOutsourced.Font = new Font("Segoe UI", 12F);
            radioOutsourced.Location = new Point(347, 25);
            radioOutsourced.Name = "radioOutsourced";
            radioOutsourced.Size = new Size(109, 25);
            radioOutsourced.TabIndex = 2;
            radioOutsourced.TabStop = true;
            radioOutsourced.Text = "Outsourced";
            radioOutsourced.UseVisualStyleBackColor = true;
            radioOutsourced.CheckedChanged += radioOutsourced_CheckedChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(219, 122);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(198, 23);
            nameTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(219, 203);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(198, 23);
            priceTextBox.TabIndex = 4;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(219, 242);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(89, 23);
            maxTextBox.TabIndex = 5;
            // 
            // nameOrIDTextBox
            // 
            nameOrIDTextBox.Location = new Point(219, 282);
            nameOrIDTextBox.Name = "nameOrIDTextBox";
            nameOrIDTextBox.Size = new Size(198, 23);
            nameOrIDTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            idTextBox.BackColor = SystemColors.InactiveCaption;
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(219, 82);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(198, 23);
            idTextBox.TabIndex = 7;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(219, 163);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(198, 23);
            inventoryTextBox.TabIndex = 8;
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(393, 242);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(89, 23);
            minTextBox.TabIndex = 9;
            // 
            // saveButton1
            // 
            saveButton1.Location = new Point(407, 369);
            saveButton1.Name = "saveButton1";
            saveButton1.Size = new Size(75, 23);
            saveButton1.TabIndex = 10;
            saveButton1.Text = "Save";
            saveButton1.UseVisualStyleBackColor = true;
            saveButton1.Click += saveButton1_Click;
            // 
            // cancelButton1
            // 
            cancelButton1.Location = new Point(538, 369);
            cancelButton1.Name = "cancelButton1";
            cancelButton1.Size = new Size(75, 23);
            cancelButton1.TabIndex = 11;
            cancelButton1.Text = "Cancel";
            cancelButton1.UseVisualStyleBackColor = true;
            cancelButton1.Click += cancelButton1_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 12F);
            idLabel.Location = new Point(156, 82);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 21);
            idLabel.TabIndex = 12;
            idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F);
            nameLabel.Location = new Point(142, 122);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 21);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Font = new Font("Segoe UI", 12F);
            inventoryLabel.Location = new Point(128, 163);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(76, 21);
            inventoryLabel.TabIndex = 14;
            inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F);
            priceLabel.Location = new Point(115, 201);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(89, 21);
            priceLabel.TabIndex = 15;
            priceLabel.Text = "Price / Cost";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Segoe UI", 12F);
            maxLabel.Location = new Point(165, 240);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(39, 21);
            maxLabel.TabIndex = 16;
            maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Segoe UI", 12F);
            minLabel.Location = new Point(347, 242);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(37, 21);
            minLabel.TabIndex = 17;
            minLabel.Text = "Min";
            // 
            // nameOrIDLabel
            // 
            nameOrIDLabel.AutoSize = true;
            nameOrIDLabel.Font = new Font("Segoe UI", 12F);
            nameOrIDLabel.Location = new Point(93, 280);
            nameOrIDLabel.Name = "nameOrIDLabel";
            nameOrIDLabel.Size = new Size(88, 21);
            nameOrIDLabel.TabIndex = 18;
            nameOrIDLabel.Text = "Machine ID";
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(645, 432);
            Controls.Add(nameOrIDLabel);
            Controls.Add(minLabel);
            Controls.Add(maxLabel);
            Controls.Add(priceLabel);
            Controls.Add(inventoryLabel);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
            Controls.Add(cancelButton1);
            Controls.Add(saveButton1);
            Controls.Add(minTextBox);
            Controls.Add(inventoryTextBox);
            Controls.Add(idTextBox);
            Controls.Add(nameOrIDTextBox);
            Controls.Add(maxTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(radioOutsourced);
            Controls.Add(radioInHouse);
            Controls.Add(label1);
            Name = "AddPart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioInHouse;
        private RadioButton radioOutsourced;
        private TextBox nameTextBox;
        private TextBox priceTextBox;
        private TextBox maxTextBox;
        private TextBox nameOrIDTextBox;
        private TextBox idTextBox;
        private TextBox inventoryTextBox;
        private TextBox minTextBox;
        private Button saveButton1;
        private Button cancelButton1;
        private Label idLabel;
        private Label nameLabel;
        private Label inventoryLabel;
        private Label label5;
        private Label maxLabel;
        private Label minLabel;
        private Label nameOrIDLabel;
        private Label priceLabel;
    }
}
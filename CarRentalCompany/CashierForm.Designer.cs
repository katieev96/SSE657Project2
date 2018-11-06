namespace CarRentalCompany
{
    partial class CashierForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.fileDialogButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uploadInfoButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.userInfoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.userInfoTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.userInfoTableLayout, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.priceLabel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 529);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.filePathTextBox);
            this.flowLayoutPanel1.Controls.Add(this.fileDialogButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Input File:";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.filePathTextBox.Location = new System.Drawing.Point(181, 8);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(506, 31);
            this.filePathTextBox.TabIndex = 5;
            this.filePathTextBox.Text = "User File";
            // 
            // fileDialogButton
            // 
            this.fileDialogButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileDialogButton.Location = new System.Drawing.Point(693, 3);
            this.fileDialogButton.Name = "fileDialogButton";
            this.fileDialogButton.Size = new System.Drawing.Size(56, 41);
            this.fileDialogButton.TabIndex = 1;
            this.fileDialogButton.Text = "...";
            this.fileDialogButton.UseVisualStyleBackColor = true;
            this.fileDialogButton.Click += new System.EventHandler(this.fileDialogButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel2.Controls.Add(this.uploadInfoButton);
            this.flowLayoutPanel2.Controls.Add(this.resetButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(548, 103);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(353, 94);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // uploadInfoButton
            // 
            this.uploadInfoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uploadInfoButton.Location = new System.Drawing.Point(3, 3);
            this.uploadInfoButton.Name = "uploadInfoButton";
            this.uploadInfoButton.Size = new System.Drawing.Size(234, 69);
            this.uploadInfoButton.TabIndex = 0;
            this.uploadInfoButton.Text = "Upload Customer Information";
            this.uploadInfoButton.UseVisualStyleBackColor = true;
            this.uploadInfoButton.Click += new System.EventHandler(this.uploadButton_CLick);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Location = new System.Drawing.Point(243, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 64);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // userInfoTableLayout
            // 
            this.userInfoTableLayout.AutoSize = true;
            this.userInfoTableLayout.ColumnCount = 2;
            this.userInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userInfoTableLayout.Controls.Add(this.calculateButton, 1, 1);
            this.userInfoTableLayout.Controls.Add(this.userInfoLabel, 0, 0);
            this.userInfoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfoTableLayout.Location = new System.Drawing.Point(3, 203);
            this.userInfoTableLayout.Name = "userInfoTableLayout";
            this.userInfoTableLayout.RowCount = 2;
            this.userInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userInfoTableLayout.Size = new System.Drawing.Size(898, 257);
            this.userInfoTableLayout.TabIndex = 3;
            this.userInfoTableLayout.Visible = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.calculateButton.Location = new System.Drawing.Point(700, 167);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(195, 51);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoLabel.Location = new System.Drawing.Point(185, 49);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(79, 29);
            this.userInfoLabel.TabIndex = 1;
            this.userInfoLabel.Text = "label3";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(417, 483);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(70, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "label4";
            this.priceLabel.Visible = false;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(904, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(930, 1000);
            this.MinimumSize = new System.Drawing.Size(930, 600);
            this.Name = "CashierForm";
            this.Text = "KG Rentals";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.userInfoTableLayout.ResumeLayout(false);
            this.userInfoTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button fileDialogButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uploadInfoButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TableLayoutPanel userInfoTableLayout;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}
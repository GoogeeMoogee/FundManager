namespace FundManager.Desktop.Controls
{
    partial class SpendingsControl
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
            this.SpendingTable = new System.Windows.Forms.DataGridView();
            this.TopSpendingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.SpendingsTypeLabel = new System.Windows.Forms.Label();
            this.SpendingComboBox = new System.Windows.Forms.ComboBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpendingTable)).BeginInit();
            this.TopSpendingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpendingTable
            // 
            this.SpendingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpendingTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpendingTable.Location = new System.Drawing.Point(0, 0);
            this.SpendingTable.Name = "SpendingTable";
            this.SpendingTable.ReadOnly = true;
            this.SpendingTable.Size = new System.Drawing.Size(762, 438);
            this.SpendingTable.TabIndex = 1;
            // 
            // TopSpendingsPanel
            // 
            this.TopSpendingsPanel.ColumnCount = 4;
            this.TopSpendingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopSpendingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopSpendingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopSpendingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopSpendingsPanel.Controls.Add(this.NameLabel, 0, 0);
            this.TopSpendingsPanel.Controls.Add(this.NameTextBox, 0, 1);
            this.TopSpendingsPanel.Controls.Add(this.AmountLabel, 1, 0);
            this.TopSpendingsPanel.Controls.Add(this.AmountTextBox, 1, 1);
            this.TopSpendingsPanel.Controls.Add(this.SpendingsTypeLabel, 2, 0);
            this.TopSpendingsPanel.Controls.Add(this.SpendingComboBox, 2, 1);
            this.TopSpendingsPanel.Controls.Add(this.NotesLabel, 3, 0);
            this.TopSpendingsPanel.Controls.Add(this.NotesTextBox, 3, 1);
            this.TopSpendingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSpendingsPanel.Location = new System.Drawing.Point(0, 0);
            this.TopSpendingsPanel.Name = "TopSpendingsPanel";
            this.TopSpendingsPanel.RowCount = 2;
            this.TopSpendingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopSpendingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopSpendingsPanel.Size = new System.Drawing.Size(762, 75);
            this.TopSpendingsPanel.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(184, 19);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameTextBox.Location = new System.Drawing.Point(3, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(184, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AmountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(193, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(184, 19);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AmountTextBox.Location = new System.Drawing.Point(193, 40);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(184, 20);
            this.AmountTextBox.TabIndex = 3;
            // 
            // SpendingsTypeLabel
            // 
            this.SpendingsTypeLabel.AutoSize = true;
            this.SpendingsTypeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpendingsTypeLabel.Location = new System.Drawing.Point(383, 0);
            this.SpendingsTypeLabel.Name = "SpendingsTypeLabel";
            this.SpendingsTypeLabel.Size = new System.Drawing.Size(95, 19);
            this.SpendingsTypeLabel.TabIndex = 4;
            this.SpendingsTypeLabel.Text = "Spending type";
            // 
            // SpendingComboBox
            // 
            this.SpendingComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpendingComboBox.FormattingEnabled = true;
            this.SpendingComboBox.Location = new System.Drawing.Point(383, 40);
            this.SpendingComboBox.Name = "SpendingComboBox";
            this.SpendingComboBox.Size = new System.Drawing.Size(184, 21);
            this.SpendingComboBox.TabIndex = 5;
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(573, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(46, 19);
            this.NotesLabel.TabIndex = 6;
            this.NotesLabel.Text = "Notes";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesTextBox.Location = new System.Drawing.Point(573, 40);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(186, 32);
            this.NotesTextBox.TabIndex = 7;
            // 
            // SpendingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TopSpendingsPanel);
            this.Controls.Add(this.SpendingTable);
            this.Name = "SpendingsControl";
            this.Size = new System.Drawing.Size(762, 438);
            ((System.ComponentModel.ISupportInitialize)(this.SpendingTable)).EndInit();
            this.TopSpendingsPanel.ResumeLayout(false);
            this.TopSpendingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView SpendingTable;
        private System.Windows.Forms.TableLayoutPanel TopSpendingsPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label SpendingsTypeLabel;
        private System.Windows.Forms.ComboBox SpendingComboBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox NotesTextBox;
    }
}

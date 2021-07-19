
using System.Windows.Forms;

namespace ChromeExtensionIdentifier
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnExit = new System.Windows.Forms.Button();
            this.GroupInput = new System.Windows.Forms.GroupBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.GroupOutput = new System.Windows.Forms.GroupBox();
            this.DataOutput = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.BtnClear = new System.Windows.Forms.Button();
            this.CheckBoxShowID = new System.Windows.Forms.CheckBox();
            this.GroupInput.SuspendLayout();
            this.GroupOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Location = new System.Drawing.Point(1398, 540);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GroupInput
            // 
            this.GroupInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupInput.Controls.Add(this.TextBoxInput);
            this.GroupInput.Location = new System.Drawing.Point(12, 12);
            this.GroupInput.Name = "GroupInput";
            this.GroupInput.Size = new System.Drawing.Size(272, 510);
            this.GroupInput.TabIndex = 3;
            this.GroupInput.TabStop = false;
            this.GroupInput.Text = "I&nput";
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInput.Location = new System.Drawing.Point(6, 19);
            this.TextBoxInput.Multiline = true;
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxInput.Size = new System.Drawing.Size(260, 485);
            this.TextBoxInput.TabIndex = 4;
            this.TextBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // GroupOutput
            // 
            this.GroupOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupOutput.Controls.Add(this.DataOutput);
            this.GroupOutput.Location = new System.Drawing.Point(314, 12);
            this.GroupOutput.Name = "GroupOutput";
            this.GroupOutput.Size = new System.Drawing.Size(1159, 510);
            this.GroupOutput.TabIndex = 4;
            this.GroupOutput.TabStop = false;
            this.GroupOutput.Text = "O&utput";
            // 
            // DataOutput
            // 
            this.DataOutput.AllowUserToAddRows = false;
            this.DataOutput.AllowUserToDeleteRows = false;
            this.DataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnDescr,
            this.ColumnLink});
            this.DataOutput.Location = new System.Drawing.Point(6, 19);
            this.DataOutput.Name = "DataOutput";
            this.DataOutput.ReadOnly = true;
            this.DataOutput.RowHeadersVisible = false;
            this.DataOutput.Size = new System.Drawing.Size(1147, 485);
            this.DataOutput.TabIndex = 5;
            this.DataOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataOutput_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 43;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 60;
            // 
            // ColumnDescr
            // 
            this.ColumnDescr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnDescr.HeaderText = "Description";
            this.ColumnDescr.Name = "ColumnDescr";
            this.ColumnDescr.ReadOnly = true;
            this.ColumnDescr.Width = 85;
            // 
            // ColumnLink
            // 
            this.ColumnLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnLink.HeaderText = "Link";
            this.ColumnLink.Name = "ColumnLink";
            this.ColumnLink.ReadOnly = true;
            this.ColumnLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnLink.Width = 52;
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(203, 540);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clea&r";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // CheckBoxShowID
            // 
            this.CheckBoxShowID.AutoSize = true;
            this.CheckBoxShowID.Location = new System.Drawing.Point(320, 540);
            this.CheckBoxShowID.Name = "CheckBoxShowID";
            this.CheckBoxShowID.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxShowID.TabIndex = 6;
            this.CheckBoxShowID.Text = "&show ID";
            this.CheckBoxShowID.UseVisualStyleBackColor = true;
            this.CheckBoxShowID.CheckedChanged += new System.EventHandler(this.CheckBoxShowID_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 575);
            this.Controls.Add(this.CheckBoxShowID);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.GroupOutput);
            this.Controls.Add(this.GroupInput);
            this.Controls.Add(this.BtnExit);
            this.Name = "frmMain";
            this.Text = "Chrome Extension Identifier";
            this.GroupInput.ResumeLayout(false);
            this.GroupInput.PerformLayout();
            this.GroupOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GroupInput;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.GroupBox GroupOutput;
        private System.Windows.Forms.DataGridView DataOutput;
        private Button BtnClear;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnDescr;
        private DataGridViewLinkColumn ColumnLink;
        private CheckBox CheckBoxShowID;
    }
}


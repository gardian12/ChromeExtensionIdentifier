
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
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.DataOutput = new System.Windows.Forms.DataGridView();
            this.BtnClear = new System.Windows.Forms.Button();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupInput.SuspendLayout();
            this.groupOutput.SuspendLayout();
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
            // groupInput
            // 
            this.groupInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupInput.Controls.Add(this.TextBoxInput);
            this.groupInput.Location = new System.Drawing.Point(12, 12);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(272, 510);
            this.groupInput.TabIndex = 3;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "I&nput";
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
            // groupOutput
            // 
            this.groupOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOutput.Controls.Add(this.DataOutput);
            this.groupOutput.Location = new System.Drawing.Point(314, 12);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(1159, 510);
            this.groupOutput.TabIndex = 4;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "O&utput";
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
            this.columnName,
            this.columnDescr,
            this.columnLink});
            this.DataOutput.Location = new System.Drawing.Point(6, 19);
            this.DataOutput.Name = "DataOutput";
            this.DataOutput.ReadOnly = true;
            this.DataOutput.RowHeadersVisible = false;
            this.DataOutput.Size = new System.Drawing.Size(1147, 485);
            this.DataOutput.TabIndex = 5;
            this.DataOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataOutput_CellContentClick);
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
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Width = 60;
            // 
            // columnDescr
            // 
            this.columnDescr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnDescr.HeaderText = "Description";
            this.columnDescr.Name = "columnDescr";
            this.columnDescr.ReadOnly = true;
            this.columnDescr.Width = 85;
            // 
            // columnLink
            // 
            this.columnLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnLink.HeaderText = "Link";
            this.columnLink.Name = "columnLink";
            this.columnLink.ReadOnly = true;
            this.columnLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnLink.Width = 52;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 575);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.BtnExit);
            this.Name = "frmMain";
            this.Text = "Chrome Extension Identifier";
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.groupOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.DataGridView DataOutput;
        private Button BtnClear;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnDescr;
        private DataGridViewLinkColumn columnLink;
    }
}


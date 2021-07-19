
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
            this.btnExit = new System.Windows.Forms.Button();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.dataOutput = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupInput.SuspendLayout();
            this.groupOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1398, 540);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupInput
            // 
            this.groupInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupInput.Controls.Add(this.tbInput);
            this.groupInput.Location = new System.Drawing.Point(12, 12);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(272, 510);
            this.groupInput.TabIndex = 3;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "I&nput";
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(6, 19);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(260, 485);
            this.tbInput.TabIndex = 4;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // groupOutput
            // 
            this.groupOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOutput.Controls.Add(this.dataOutput);
            this.groupOutput.Location = new System.Drawing.Point(314, 12);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(1159, 510);
            this.groupOutput.TabIndex = 4;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "O&utput";
            // 
            // dataOutput
            // 
            this.dataOutput.AllowUserToAddRows = false;
            this.dataOutput.AllowUserToDeleteRows = false;
            this.dataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnDescr,
            this.columnLink});
            this.dataOutput.Location = new System.Drawing.Point(6, 19);
            this.dataOutput.Name = "dataOutput";
            this.dataOutput.ReadOnly = true;
            this.dataOutput.RowHeadersVisible = false;
            this.dataOutput.Size = new System.Drawing.Size(1147, 485);
            this.dataOutput.TabIndex = 5;
            this.dataOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOutput_CellContentClick);
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
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.Text = "Chrome Extension Identifier";
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.groupOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.DataGridView dataOutput;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnDescr;
        private DataGridViewLinkColumn columnLink;
    }
}


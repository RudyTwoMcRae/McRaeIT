namespace McRaeIT
{
    partial class frmPing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPing));
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.cmdStart = new System.Windows.Forms.Button();
            this.pbPing = new System.Windows.Forms.ProgressBar();
            this.cboType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(62, 22);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(160, 20);
            this.txtStart.TabIndex = 0;
            this.txtStart.Text = "192.168.1.1";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(15, 26);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(45, 13);
            this.lblRange.TabIndex = 1;
            this.lblRange.Text = "Range: ";
            this.lblRange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(245, 22);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(160, 20);
            this.txtEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // dgView
            // 
            this.dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(17, 62);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(833, 536);
            this.dgView.TabIndex = 4;
            // 
            // cmdStart
            // 
            this.cmdStart.BackColor = System.Drawing.Color.Chartreuse;
            this.cmdStart.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStart.Location = new System.Drawing.Point(416, 17);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(100, 30);
            this.cmdStart.TabIndex = 5;
            this.cmdStart.Text = "Ping";
            this.cmdStart.UseVisualStyleBackColor = false;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // pbPing
            // 
            this.pbPing.Location = new System.Drawing.Point(17, 602);
            this.pbPing.Name = "pbPing";
            this.pbPing.Size = new System.Drawing.Size(833, 16);
            this.pbPing.TabIndex = 6;
            this.pbPing.Visible = false;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Range",
            "Range(With Hosts)",
            "Single"});
            this.cboType.Location = new System.Drawing.Point(540, 22);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(160, 21);
            this.cboType.TabIndex = 7;
            this.cboType.Text = "Range";
            // 
            // frmPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 622);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.pbPing);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.txtStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.ProgressBar pbPing;
        private System.Windows.Forms.ComboBox cboType;
    }
}
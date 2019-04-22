namespace McRaeIT
{
    partial class frmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployees));
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.miTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.miIPAddresses = new System.Windows.Forms.ToolStripMenuItem();
            this.miAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.miTools = new System.Windows.Forms.ToolStripMenuItem();
            this.miHostToIP = new System.Windows.Forms.ToolStripMenuItem();
            this.miMACIP = new System.Windows.Forms.ToolStripMenuItem();
            this.miPing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdListAll = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.miConfigs = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToOrderColumns = true;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(9, 65);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(1007, 493);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miView,
            this.miTools});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1024, 24);
            this.msMain.TabIndex = 4;
            this.msMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.miSearch,
            this.miQuit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(140, 22);
            this.miSave.Text = "&Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSearch
            // 
            this.miSearch.Name = "miSearch";
            this.miSearch.Size = new System.Drawing.Size(140, 22);
            this.miSearch.Text = "Search";
            this.miSearch.Click += new System.EventHandler(this.miSearch_Click);
            // 
            // miQuit
            // 
            this.miQuit.Name = "miQuit";
            this.miQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.miQuit.Size = new System.Drawing.Size(140, 22);
            this.miQuit.Text = "&Quit";
            this.miQuit.Click += new System.EventHandler(this.miQuit_Click);
            // 
            // miView
            // 
            this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEmployees,
            this.miEditEmployees,
            this.miTickets,
            this.miIPAddresses,
            this.miAccounts,
            this.miConfigs});
            this.miView.Name = "miView";
            this.miView.Size = new System.Drawing.Size(44, 20);
            this.miView.Text = "View";
            // 
            // miEmployees
            // 
            this.miEmployees.Name = "miEmployees";
            this.miEmployees.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.miEmployees.Size = new System.Drawing.Size(226, 22);
            this.miEmployees.Text = "Employees";
            this.miEmployees.Click += new System.EventHandler(this.miEmployees_Click);
            // 
            // miEditEmployees
            // 
            this.miEditEmployees.Name = "miEditEmployees";
            this.miEditEmployees.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.miEditEmployees.Size = new System.Drawing.Size(226, 22);
            this.miEditEmployees.Text = "Edit Employees";
            this.miEditEmployees.Click += new System.EventHandler(this.miEditEmployees_Click);
            // 
            // miTickets
            // 
            this.miTickets.Name = "miTickets";
            this.miTickets.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.miTickets.Size = new System.Drawing.Size(226, 22);
            this.miTickets.Text = "Tickets";
            this.miTickets.Click += new System.EventHandler(this.miTickets_Click);
            // 
            // miIPAddresses
            // 
            this.miIPAddresses.Name = "miIPAddresses";
            this.miIPAddresses.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.miIPAddresses.Size = new System.Drawing.Size(226, 22);
            this.miIPAddresses.Text = "IP Addresses";
            this.miIPAddresses.Click += new System.EventHandler(this.miIPAddresses_Click);
            // 
            // miAccounts
            // 
            this.miAccounts.Name = "miAccounts";
            this.miAccounts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.miAccounts.Size = new System.Drawing.Size(226, 22);
            this.miAccounts.Text = "Accounts";
            this.miAccounts.Click += new System.EventHandler(this.miAccounts_Click);
            // 
            // miTools
            // 
            this.miTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHostToIP,
            this.miMACIP,
            this.miPing});
            this.miTools.Name = "miTools";
            this.miTools.Size = new System.Drawing.Size(47, 20);
            this.miTools.Text = "Tools";
            // 
            // miHostToIP
            // 
            this.miHostToIP.Name = "miHostToIP";
            this.miHostToIP.Size = new System.Drawing.Size(135, 22);
            this.miHostToIP.Text = "HostToIP...";
            this.miHostToIP.Click += new System.EventHandler(this.miHostToIP_Click);
            // 
            // miMACIP
            // 
            this.miMACIP.Name = "miMACIP";
            this.miMACIP.Size = new System.Drawing.Size(135, 22);
            this.miMACIP.Text = "Host Info...";
            this.miMACIP.Click += new System.EventHandler(this.miMACIP_Click);
            // 
            // miPing
            // 
            this.miPing.Name = "miPing";
            this.miPing.Size = new System.Drawing.Size(135, 22);
            this.miPing.Text = "Ping Scan...";
            this.miPing.Click += new System.EventHandler(this.miPing_Click);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSave,
            this.cmdListAll,
            this.txtSearch});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1024, 25);
            this.tsMain.TabIndex = 5;
            this.tsMain.Text = "toolStrip1";
            // 
            // cmdSave
            // 
            this.cmdSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(23, 22);
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdListAll
            // 
            this.cmdListAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdListAll.Image = ((System.Drawing.Image)(resources.GetObject("cmdListAll.Image")));
            this.cmdListAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdListAll.Name = "cmdListAll";
            this.cmdListAll.Size = new System.Drawing.Size(23, 22);
            this.cmdListAll.Text = "View All";
            this.cmdListAll.Click += new System.EventHandler(this.cmdListAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(700, 25);
            this.txtSearch.Text = "Name";
            this.txtSearch.ToolTipText = "Search";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // miConfigs
            // 
            this.miConfigs.Name = "miConfigs";
            this.miConfigs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.miConfigs.Size = new System.Drawing.Size(226, 22);
            this.miConfigs.Text = "Configs";
            this.miConfigs.Click += new System.EventHandler(this.MiConfigs_Click);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 566);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "frmEmployees";
            this.Text = "McRae IT - Employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmEmployees_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEmployees_FormClosed);
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSearch;
        private System.Windows.Forms.ToolStripMenuItem miQuit;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem miEmployees;
        private System.Windows.Forms.ToolStripMenuItem miTickets;
        private System.Windows.Forms.ToolStripMenuItem miIPAddresses;
        private System.Windows.Forms.ToolStripMenuItem miAccounts;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.ToolStripButton cmdListAll;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem miEditEmployees;
        private System.Windows.Forms.ToolStripMenuItem miTools;
        private System.Windows.Forms.ToolStripMenuItem miHostToIP;
        private System.Windows.Forms.ToolStripMenuItem miMACIP;
        private System.Windows.Forms.ToolStripMenuItem miPing;
        private System.Windows.Forms.ToolStripMenuItem miConfigs;
    }
}


namespace McRaeIT
{
    partial class frmConfigurations
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label deviceLabel;
            System.Windows.Forms.Label settingsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurations));
            this.configurationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.configurationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.configurationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.txtSettings = new System.Windows.Forms.TextBox();
            this.toolStripButtonViewAll = new System.Windows.Forms.ToolStripButton();
            deviceLabel = new System.Windows.Forms.Label();
            settingsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingNavigator)).BeginInit();
            this.configurationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceLabel
            // 
            deviceLabel.AutoSize = true;
            deviceLabel.Location = new System.Drawing.Point(15, 54);
            deviceLabel.Name = "deviceLabel";
            deviceLabel.Size = new System.Drawing.Size(44, 13);
            deviceLabel.TabIndex = 1;
            deviceLabel.Text = "Device:";
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Location = new System.Drawing.Point(11, 80);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new System.Drawing.Size(48, 13);
            settingsLabel.TabIndex = 3;
            settingsLabel.Text = "Settings:";
            // 
            // configurationsBindingNavigator
            // 
            this.configurationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.configurationsBindingNavigator.BindingSource = this.configurationsBindingSource;
            this.configurationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.configurationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.configurationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripButtonViewAll,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.configurationsBindingNavigatorSaveItem,
            this.toolStripTextBoxSearch});
            this.configurationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.configurationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.configurationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.configurationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.configurationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.configurationsBindingNavigator.Name = "configurationsBindingNavigator";
            this.configurationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.configurationsBindingNavigator.Size = new System.Drawing.Size(697, 25);
            this.configurationsBindingNavigator.TabIndex = 0;
            this.configurationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // configurationsBindingSource
            // 
            this.configurationsBindingSource.DataSource = typeof(McraeitContext.Configuration);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // configurationsBindingNavigatorSaveItem
            // 
            this.configurationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.configurationsBindingNavigatorSaveItem.Enabled = false;
            this.configurationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("configurationsBindingNavigatorSaveItem.Image")));
            this.configurationsBindingNavigatorSaveItem.Name = "configurationsBindingNavigatorSaveItem";
            this.configurationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.configurationsBindingNavigatorSaveItem.Text = "Save Data";
            this.configurationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.ConfigurationsBindingNavigatorSaveItem_Click);
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(350, 25);
            this.toolStripTextBoxSearch.Text = "Device";
            this.toolStripTextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolStripTextBoxSearch_KeyPress);
            this.toolStripTextBoxSearch.MouseEnter += new System.EventHandler(this.ToolStripTextBoxSearch_MouseEnter);
            this.toolStripTextBoxSearch.MouseLeave += new System.EventHandler(this.ToolStripTextBoxSearch_MouseLeave);
            // 
            // txtDevice
            // 
            this.txtDevice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationsBindingSource, "Device", true));
            this.txtDevice.Location = new System.Drawing.Point(65, 51);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(622, 20);
            this.txtDevice.TabIndex = 2;
            // 
            // txtSettings
            // 
            this.txtSettings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationsBindingSource, "Settings", true));
            this.txtSettings.Location = new System.Drawing.Point(65, 77);
            this.txtSettings.Multiline = true;
            this.txtSettings.Name = "txtSettings";
            this.txtSettings.Size = new System.Drawing.Size(622, 361);
            this.txtSettings.TabIndex = 4;
            // 
            // toolStripButtonViewAll
            // 
            this.toolStripButtonViewAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonViewAll.Image = global::McRaeIT.Properties.Resources.ListView_16x;
            this.toolStripButtonViewAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonViewAll.Name = "toolStripButtonViewAll";
            this.toolStripButtonViewAll.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonViewAll.Text = "View All";
            this.toolStripButtonViewAll.Click += new System.EventHandler(this.ToolStripButtonViewAll_Click);
            // 
            // frmConfigurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(settingsLabel);
            this.Controls.Add(this.txtSettings);
            this.Controls.Add(deviceLabel);
            this.Controls.Add(this.txtDevice);
            this.Controls.Add(this.configurationsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfigurations";
            this.Text = "Configurations";
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingNavigator)).EndInit();
            this.configurationsBindingNavigator.ResumeLayout(false);
            this.configurationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource configurationsBindingSource;
        private System.Windows.Forms.BindingNavigator configurationsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton configurationsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.TextBox txtSettings;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonViewAll;
    }
}
namespace PayrollSystem
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.RosterTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.AdButton = new System.Windows.Forms.Button();
            this.PaymentTab = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.RosterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PaymentTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tabs);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 361);
            this.panel1.TabIndex = 1;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.RosterTab);
            this.Tabs.Controls.Add(this.PaymentTab);
            this.Tabs.ItemSize = new System.Drawing.Size(70, 18);
            this.Tabs.Location = new System.Drawing.Point(23, 13);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(600, 315);
            this.Tabs.TabIndex = 0;
            // 
            // RosterTab
            // 
            this.RosterTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RosterTab.Controls.Add(this.dataGridView1);
            this.RosterTab.Controls.Add(this.UpdateButton);
            this.RosterTab.Controls.Add(this.buttonDelete);
            this.RosterTab.Controls.Add(this.AdButton);
            this.RosterTab.Location = new System.Drawing.Point(4, 22);
            this.RosterTab.Name = "RosterTab";
            this.RosterTab.Padding = new System.Windows.Forms.Padding(3);
            this.RosterTab.Size = new System.Drawing.Size(592, 289);
            this.RosterTab.TabIndex = 0;
            this.RosterTab.Text = "Roster";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 200);
            this.dataGridView1.TabIndex = 3;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(220, 6);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(85, 34);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(109, 6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(84, 34);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // AdButton
            // 
            this.AdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdButton.Enabled = false;
            this.AdButton.Location = new System.Drawing.Point(6, 6);
            this.AdButton.Name = "AdButton";
            this.AdButton.Size = new System.Drawing.Size(82, 34);
            this.AdButton.TabIndex = 0;
            this.AdButton.Text = "Add";
            this.AdButton.UseVisualStyleBackColor = true;
            // 
            // PaymentTab
            // 
            this.PaymentTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PaymentTab.Controls.Add(this.comboBox1);
            this.PaymentTab.Controls.Add(this.label1);
            this.PaymentTab.Location = new System.Drawing.Point(4, 22);
            this.PaymentTab.Name = "PaymentTab";
            this.PaymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentTab.Size = new System.Drawing.Size(592, 289);
            this.PaymentTab.TabIndex = 1;
            this.PaymentTab.Text = "Payment";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hourly",
            "Comission",
            "Salary",
            "Employees"});
            this.comboBox1.Location = new System.Drawing.Point(16, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Payment Type";
            this.comboBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.RosterTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PaymentTab.ResumeLayout(false);
            this.PaymentTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage RosterTab;
        private System.Windows.Forms.TabPage PaymentTab;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button AdButton;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
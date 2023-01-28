namespace EventBokning
{
    partial class PerformerWindow
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
            this.btnEventWindow = new System.Windows.Forms.Button();
            this.btnDeletePerformer = new System.Windows.Forms.Button();
            this.btnUpdatePerformer = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCustomerWindow = new System.Windows.Forms.Button();
            this.gridEvents = new System.Windows.Forms.DataGridView();
            this.gridPerformers = new System.Windows.Forms.DataGridView();
            this.btnSelectPerformers = new System.Windows.Forms.Button();
            this.btnInsertNewPerformer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerformers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEventWindow
            // 
            this.btnEventWindow.Location = new System.Drawing.Point(23, 521);
            this.btnEventWindow.Name = "btnEventWindow";
            this.btnEventWindow.Size = new System.Drawing.Size(216, 51);
            this.btnEventWindow.TabIndex = 30;
            this.btnEventWindow.Text = "Events";
            this.btnEventWindow.UseVisualStyleBackColor = true;
            this.btnEventWindow.Click += new System.EventHandler(this.btnEventWindow_Click);
            // 
            // btnDeletePerformer
            // 
            this.btnDeletePerformer.Enabled = false;
            this.btnDeletePerformer.Location = new System.Drawing.Point(377, 388);
            this.btnDeletePerformer.Name = "btnDeletePerformer";
            this.btnDeletePerformer.Size = new System.Drawing.Size(122, 37);
            this.btnDeletePerformer.TabIndex = 29;
            this.btnDeletePerformer.Text = "Delete";
            this.btnDeletePerformer.UseVisualStyleBackColor = true;
            this.btnDeletePerformer.Click += new System.EventHandler(this.btnDeletePerformer_Click);
            // 
            // btnUpdatePerformer
            // 
            this.btnUpdatePerformer.Enabled = false;
            this.btnUpdatePerformer.Location = new System.Drawing.Point(23, 388);
            this.btnUpdatePerformer.Name = "btnUpdatePerformer";
            this.btnUpdatePerformer.Size = new System.Drawing.Size(114, 37);
            this.btnUpdatePerformer.TabIndex = 28;
            this.btnUpdatePerformer.Text = "Update";
            this.btnUpdatePerformer.UseVisualStyleBackColor = true;
            this.btnUpdatePerformer.Click += new System.EventHandler(this.btnUpdatePerformer_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(197, 388);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 37);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search for name";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCustomerWindow
            // 
            this.btnCustomerWindow.Location = new System.Drawing.Point(262, 521);
            this.btnCustomerWindow.Name = "btnCustomerWindow";
            this.btnCustomerWindow.Size = new System.Drawing.Size(237, 51);
            this.btnCustomerWindow.TabIndex = 26;
            this.btnCustomerWindow.Text = "Customers";
            this.btnCustomerWindow.UseVisualStyleBackColor = true;
            this.btnCustomerWindow.Click += new System.EventHandler(this.btnCustomerWindow_Click);
            // 
            // gridEvents
            // 
            this.gridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEvents.Location = new System.Drawing.Point(521, 204);
            this.gridEvents.Name = "gridEvents";
            this.gridEvents.Size = new System.Drawing.Size(778, 152);
            this.gridEvents.TabIndex = 25;
            // 
            // gridPerformers
            // 
            this.gridPerformers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPerformers.Location = new System.Drawing.Point(23, 204);
            this.gridPerformers.Name = "gridPerformers";
            this.gridPerformers.Size = new System.Drawing.Size(476, 178);
            this.gridPerformers.TabIndex = 24;
            this.gridPerformers.SelectionChanged += new System.EventHandler(this.gridPerformers_SelectionChanged);
            // 
            // btnSelectPerformers
            // 
            this.btnSelectPerformers.Location = new System.Drawing.Point(197, 120);
            this.btnSelectPerformers.Name = "btnSelectPerformers";
            this.btnSelectPerformers.Size = new System.Drawing.Size(112, 37);
            this.btnSelectPerformers.TabIndex = 23;
            this.btnSelectPerformers.Text = "Select all performers";
            this.btnSelectPerformers.UseVisualStyleBackColor = true;
            this.btnSelectPerformers.Click += new System.EventHandler(this.btnSelectPerformers_Click);
            // 
            // btnInsertNewPerformer
            // 
            this.btnInsertNewPerformer.Location = new System.Drawing.Point(61, 120);
            this.btnInsertNewPerformer.Name = "btnInsertNewPerformer";
            this.btnInsertNewPerformer.Size = new System.Drawing.Size(112, 37);
            this.btnInsertNewPerformer.TabIndex = 22;
            this.btnInsertNewPerformer.Text = "Insert new performer";
            this.btnInsertNewPerformer.UseVisualStyleBackColor = true;
            this.btnInsertNewPerformer.Click += new System.EventHandler(this.btnInsertNewPerformer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "*Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "*Name";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(73, 50);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 17;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(73, 15);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 16;
            // 
            // PerformerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 621);
            this.Controls.Add(this.btnEventWindow);
            this.Controls.Add(this.btnDeletePerformer);
            this.Controls.Add(this.btnUpdatePerformer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCustomerWindow);
            this.Controls.Add(this.gridEvents);
            this.Controls.Add(this.gridPerformers);
            this.Controls.Add(this.btnSelectPerformers);
            this.Controls.Add(this.btnInsertNewPerformer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxName);
            this.Name = "PerformerWindow";
            this.Text = "PerformerWindow";
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerformers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventWindow;
        private System.Windows.Forms.Button btnDeletePerformer;
        private System.Windows.Forms.Button btnUpdatePerformer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCustomerWindow;
        private System.Windows.Forms.DataGridView gridEvents;
        private System.Windows.Forms.DataGridView gridPerformers;
        private System.Windows.Forms.Button btnSelectPerformers;
        private System.Windows.Forms.Button btnInsertNewPerformer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxName;
    }
}
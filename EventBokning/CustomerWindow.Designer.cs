namespace EventBokning
{
    partial class CustomerWindow
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertNewUser = new System.Windows.Forms.Button();
            this.btnSelectCustomers = new System.Windows.Forms.Button();
            this.gridOutput = new System.Windows.Forms.DataGridView();
            this.gridEventOutput = new System.Windows.Forms.DataGridView();
            this.btnPerformerWindow = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEventWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(84, 31);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(84, 66);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 1;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(84, 106);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 20);
            this.tbxAge.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "*Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Age";
            // 
            // btnInsertNewUser
            // 
            this.btnInsertNewUser.Location = new System.Drawing.Point(84, 157);
            this.btnInsertNewUser.Name = "btnInsertNewUser";
            this.btnInsertNewUser.Size = new System.Drawing.Size(112, 37);
            this.btnInsertNewUser.TabIndex = 6;
            this.btnInsertNewUser.Text = "Insert new user";
            this.btnInsertNewUser.UseVisualStyleBackColor = true;
            this.btnInsertNewUser.Click += new System.EventHandler(this.btnInsertNewUser_Click);
            // 
            // btnSelectCustomers
            // 
            this.btnSelectCustomers.Location = new System.Drawing.Point(218, 157);
            this.btnSelectCustomers.Name = "btnSelectCustomers";
            this.btnSelectCustomers.Size = new System.Drawing.Size(112, 37);
            this.btnSelectCustomers.TabIndex = 8;
            this.btnSelectCustomers.Text = "Select customers";
            this.btnSelectCustomers.UseVisualStyleBackColor = true;
            this.btnSelectCustomers.Click += new System.EventHandler(this.btnSelectCustomers_Click);
            // 
            // gridOutput
            // 
            this.gridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOutput.Location = new System.Drawing.Point(34, 220);
            this.gridOutput.Name = "gridOutput";
            this.gridOutput.Size = new System.Drawing.Size(476, 178);
            this.gridOutput.TabIndex = 9;
            this.gridOutput.SelectionChanged += new System.EventHandler(this.gridOutput_SelectionChanged);
            // 
            // gridEventOutput
            // 
            this.gridEventOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEventOutput.Location = new System.Drawing.Point(532, 220);
            this.gridEventOutput.Name = "gridEventOutput";
            this.gridEventOutput.Size = new System.Drawing.Size(778, 152);
            this.gridEventOutput.TabIndex = 10;
            // 
            // btnPerformerWindow
            // 
            this.btnPerformerWindow.Location = new System.Drawing.Point(273, 537);
            this.btnPerformerWindow.Name = "btnPerformerWindow";
            this.btnPerformerWindow.Size = new System.Drawing.Size(237, 51);
            this.btnPerformerWindow.TabIndex = 11;
            this.btnPerformerWindow.Text = "Performers";
            this.btnPerformerWindow.UseVisualStyleBackColor = true;
            this.btnPerformerWindow.Click += new System.EventHandler(this.btnPerformerWindow_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(208, 404);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 37);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search for name";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Enabled = false;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(34, 404);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(114, 37);
            this.btnUpdateCustomer.TabIndex = 13;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(388, 404);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(122, 37);
            this.btnDeleteCustomer.TabIndex = 14;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnEventWindow
            // 
            this.btnEventWindow.Location = new System.Drawing.Point(34, 537);
            this.btnEventWindow.Name = "btnEventWindow";
            this.btnEventWindow.Size = new System.Drawing.Size(216, 51);
            this.btnEventWindow.TabIndex = 15;
            this.btnEventWindow.Text = "Events";
            this.btnEventWindow.UseVisualStyleBackColor = true;
            this.btnEventWindow.Click += new System.EventHandler(this.btnEventWindow_Click);
            // 
            // CustomerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 600);
            this.Controls.Add(this.btnEventWindow);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPerformerWindow);
            this.Controls.Add(this.gridEventOutput);
            this.Controls.Add(this.gridOutput);
            this.Controls.Add(this.btnSelectCustomers);
            this.Controls.Add(this.btnInsertNewUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxName);
            this.Name = "CustomerWindow";
            this.Text = "CustomerWindow";
            ((System.ComponentModel.ISupportInitialize)(this.gridOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertNewUser;
        private System.Windows.Forms.Button btnSelectCustomers;
        private System.Windows.Forms.DataGridView gridOutput;
        private System.Windows.Forms.DataGridView gridEventOutput;
        private System.Windows.Forms.Button btnPerformerWindow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEventWindow;
    }
}


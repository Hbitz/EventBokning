namespace EventBokning
{
    partial class EventWindow
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
            this.btnCustomerWindow = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnSearchEvent = new System.Windows.Forms.Button();
            this.btnPerformerWindow = new System.Windows.Forms.Button();
            this.gridPerformers = new System.Windows.Forms.DataGridView();
            this.gridEvents = new System.Windows.Forms.DataGridView();
            this.btnGetEvents = new System.Windows.Forms.Button();
            this.btnCreateNewEvent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAgeRequirement = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.gridUnrelatedCustomers = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBookCustomerToEvent = new System.Windows.Forms.Button();
            this.btnRemoveCustomerEventBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerformers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnrelatedCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomerWindow
            // 
            this.btnCustomerWindow.Location = new System.Drawing.Point(34, 523);
            this.btnCustomerWindow.Name = "btnCustomerWindow";
            this.btnCustomerWindow.Size = new System.Drawing.Size(192, 51);
            this.btnCustomerWindow.TabIndex = 30;
            this.btnCustomerWindow.Text = "Customers";
            this.btnCustomerWindow.UseVisualStyleBackColor = true;
            this.btnCustomerWindow.Click += new System.EventHandler(this.btnCustomerWindow_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Enabled = false;
            this.btnDeleteEvent.Location = new System.Drawing.Point(387, 411);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(98, 37);
            this.btnDeleteEvent.TabIndex = 29;
            this.btnDeleteEvent.Text = "Delete";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.Enabled = false;
            this.btnUpdateEvent.Location = new System.Drawing.Point(33, 411);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(90, 37);
            this.btnUpdateEvent.TabIndex = 28;
            this.btnUpdateEvent.Text = "Update";
            this.btnUpdateEvent.UseVisualStyleBackColor = true;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // btnSearchEvent
            // 
            this.btnSearchEvent.Location = new System.Drawing.Point(207, 411);
            this.btnSearchEvent.Name = "btnSearchEvent";
            this.btnSearchEvent.Size = new System.Drawing.Size(116, 37);
            this.btnSearchEvent.TabIndex = 27;
            this.btnSearchEvent.Text = "Search for name";
            this.btnSearchEvent.UseVisualStyleBackColor = true;
            this.btnSearchEvent.Click += new System.EventHandler(this.btnSearchEvent_Click);
            // 
            // btnPerformerWindow
            // 
            this.btnPerformerWindow.Location = new System.Drawing.Point(273, 523);
            this.btnPerformerWindow.Name = "btnPerformerWindow";
            this.btnPerformerWindow.Size = new System.Drawing.Size(213, 51);
            this.btnPerformerWindow.TabIndex = 26;
            this.btnPerformerWindow.Text = "Performers";
            this.btnPerformerWindow.UseVisualStyleBackColor = true;
            this.btnPerformerWindow.Click += new System.EventHandler(this.btnPerformerWindow_Click);
            // 
            // gridPerformers
            // 
            this.gridPerformers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPerformers.Location = new System.Drawing.Point(630, 32);
            this.gridPerformers.Name = "gridPerformers";
            this.gridPerformers.Size = new System.Drawing.Size(575, 77);
            this.gridPerformers.TabIndex = 25;
            // 
            // gridEvents
            // 
            this.gridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEvents.Location = new System.Drawing.Point(33, 227);
            this.gridEvents.Name = "gridEvents";
            this.gridEvents.Size = new System.Drawing.Size(452, 178);
            this.gridEvents.TabIndex = 24;
            this.gridEvents.SelectionChanged += new System.EventHandler(this.gridEvents_SelectionChanged);
            // 
            // btnGetEvents
            // 
            this.btnGetEvents.Location = new System.Drawing.Point(218, 128);
            this.btnGetEvents.Name = "btnGetEvents";
            this.btnGetEvents.Size = new System.Drawing.Size(88, 37);
            this.btnGetEvents.TabIndex = 23;
            this.btnGetEvents.Text = "Get all events";
            this.btnGetEvents.UseVisualStyleBackColor = true;
            this.btnGetEvents.Click += new System.EventHandler(this.btnGetEvents_Click);
            // 
            // btnCreateNewEvent
            // 
            this.btnCreateNewEvent.Location = new System.Drawing.Point(84, 128);
            this.btnCreateNewEvent.Name = "btnCreateNewEvent";
            this.btnCreateNewEvent.Size = new System.Drawing.Size(112, 37);
            this.btnCreateNewEvent.TabIndex = 22;
            this.btnCreateNewEvent.Text = "Create new event";
            this.btnCreateNewEvent.UseVisualStyleBackColor = true;
            this.btnCreateNewEvent.Click += new System.EventHandler(this.btnCreateNewEvent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Age requirement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // tbxAgeRequirement
            // 
            this.tbxAgeRequirement.Location = new System.Drawing.Point(120, 89);
            this.tbxAgeRequirement.Name = "tbxAgeRequirement";
            this.tbxAgeRequirement.Size = new System.Drawing.Size(76, 20);
            this.tbxAgeRequirement.TabIndex = 18;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(120, 49);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(76, 20);
            this.tbxPrice.TabIndex = 17;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(120, 14);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(76, 20);
            this.tbxName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Events";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(853, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Performers of event";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(854, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Customers of event";
            // 
            // gridCustomers
            // 
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Location = new System.Drawing.Point(577, 160);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(657, 118);
            this.gridCustomers.TabIndex = 34;
            this.gridCustomers.SelectionChanged += new System.EventHandler(this.gridCustomers_SelectionChanged);
            // 
            // gridUnrelatedCustomers
            // 
            this.gridUnrelatedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUnrelatedCustomers.Location = new System.Drawing.Point(577, 411);
            this.gridUnrelatedCustomers.Name = "gridUnrelatedCustomers";
            this.gridUnrelatedCustomers.Size = new System.Drawing.Size(698, 180);
            this.gridUnrelatedCustomers.TabIndex = 35;
            this.gridUnrelatedCustomers.SelectionChanged += new System.EventHandler(this.gridUnrelatedCustomers_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(769, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Customer list that does not have ticket to event";
            // 
            // btnBookCustomerToEvent
            // 
            this.btnBookCustomerToEvent.Enabled = false;
            this.btnBookCustomerToEvent.Location = new System.Drawing.Point(729, 610);
            this.btnBookCustomerToEvent.Name = "btnBookCustomerToEvent";
            this.btnBookCustomerToEvent.Size = new System.Drawing.Size(189, 30);
            this.btnBookCustomerToEvent.TabIndex = 37;
            this.btnBookCustomerToEvent.Text = "Book event for selected customer";
            this.btnBookCustomerToEvent.UseVisualStyleBackColor = true;
            this.btnBookCustomerToEvent.Click += new System.EventHandler(this.btnBookCustomerToEvent_Click);
            // 
            // btnRemoveCustomerEventBooking
            // 
            this.btnRemoveCustomerEventBooking.Enabled = false;
            this.btnRemoveCustomerEventBooking.Location = new System.Drawing.Point(804, 286);
            this.btnRemoveCustomerEventBooking.Name = "btnRemoveCustomerEventBooking";
            this.btnRemoveCustomerEventBooking.Size = new System.Drawing.Size(235, 31);
            this.btnRemoveCustomerEventBooking.TabIndex = 38;
            this.btnRemoveCustomerEventBooking.Text = "Remove booking for selected customer";
            this.btnRemoveCustomerEventBooking.UseVisualStyleBackColor = true;
            this.btnRemoveCustomerEventBooking.Click += new System.EventHandler(this.btnRemoveCustomerEventBooking_Click);
            // 
            // EventWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 650);
            this.Controls.Add(this.btnRemoveCustomerEventBooking);
            this.Controls.Add(this.btnBookCustomerToEvent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridUnrelatedCustomers);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCustomerWindow);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnSearchEvent);
            this.Controls.Add(this.btnPerformerWindow);
            this.Controls.Add(this.gridPerformers);
            this.Controls.Add(this.gridEvents);
            this.Controls.Add(this.btnGetEvents);
            this.Controls.Add(this.btnCreateNewEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAgeRequirement);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxName);
            this.Name = "EventWindow";
            this.Text = "EventWindow";
            ((System.ComponentModel.ISupportInitialize)(this.gridPerformers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnrelatedCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerWindow;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnSearchEvent;
        private System.Windows.Forms.Button btnPerformerWindow;
        private System.Windows.Forms.DataGridView gridPerformers;
        private System.Windows.Forms.DataGridView gridEvents;
        private System.Windows.Forms.Button btnGetEvents;
        private System.Windows.Forms.Button btnCreateNewEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAgeRequirement;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.DataGridView gridUnrelatedCustomers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBookCustomerToEvent;
        private System.Windows.Forms.Button btnRemoveCustomerEventBooking;
    }
}
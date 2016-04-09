namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.reservationsBtn = new System.Windows.Forms.Button();
            this.roomManagementBtn = new System.Windows.Forms.Button();
            this.billingBtn = new System.Windows.Forms.Button();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.employeeSectionBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.dropBtn1 = new System.Windows.Forms.Button();
            this.dropBtn2 = new System.Windows.Forms.Button();
            this.dropBtn3 = new System.Windows.Forms.Button();
            this.dropBtn4 = new System.Windows.Forms.Button();
            this.dropBtn5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservationsBtn
            // 
            this.reservationsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsBtn.Image = global::WindowsFormsApplication1.Properties.Resources.reservations_icon_300x241;
            this.reservationsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reservationsBtn.Location = new System.Drawing.Point(16, 15);
            this.reservationsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reservationsBtn.Name = "reservationsBtn";
            this.reservationsBtn.Size = new System.Drawing.Size(213, 86);
            this.reservationsBtn.TabIndex = 0;
            this.reservationsBtn.UseVisualStyleBackColor = true;
            this.reservationsBtn.Click += new System.EventHandler(this.reservationsBtn_Click);
            // 
            // roomManagementBtn
            // 
            this.roomManagementBtn.Location = new System.Drawing.Point(237, 15);
            this.roomManagementBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomManagementBtn.Name = "roomManagementBtn";
            this.roomManagementBtn.Size = new System.Drawing.Size(213, 86);
            this.roomManagementBtn.TabIndex = 1;
            this.roomManagementBtn.Text = "Room Management";
            this.roomManagementBtn.UseVisualStyleBackColor = true;
            this.roomManagementBtn.Click += new System.EventHandler(this.roomManagementBtn_Click);
            // 
            // billingBtn
            // 
            this.billingBtn.Location = new System.Drawing.Point(459, 15);
            this.billingBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.billingBtn.Name = "billingBtn";
            this.billingBtn.Size = new System.Drawing.Size(213, 86);
            this.billingBtn.TabIndex = 2;
            this.billingBtn.Text = "Billing";
            this.billingBtn.UseVisualStyleBackColor = true;
            this.billingBtn.Click += new System.EventHandler(this.billingBtn_Click);
            // 
            // clientsBtn
            // 
            this.clientsBtn.Location = new System.Drawing.Point(680, 15);
            this.clientsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(213, 86);
            this.clientsBtn.TabIndex = 3;
            this.clientsBtn.Text = "Clients";
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // employeeSectionBtn
            // 
            this.employeeSectionBtn.Location = new System.Drawing.Point(901, 15);
            this.employeeSectionBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeSectionBtn.Name = "employeeSectionBtn";
            this.employeeSectionBtn.Size = new System.Drawing.Size(213, 86);
            this.employeeSectionBtn.TabIndex = 4;
            this.employeeSectionBtn.Text = "Employee Section";
            this.employeeSectionBtn.UseVisualStyleBackColor = true;
            this.employeeSectionBtn.Click += new System.EventHandler(this.employeeSectionBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1123, 15);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(213, 86);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dropBtn1
            // 
            this.dropBtn1.Location = new System.Drawing.Point(16, 144);
            this.dropBtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropBtn1.Name = "dropBtn1";
            this.dropBtn1.Size = new System.Drawing.Size(213, 86);
            this.dropBtn1.TabIndex = 6;
            this.dropBtn1.Text = "New Reservation";
            this.dropBtn1.UseVisualStyleBackColor = true;
            this.dropBtn1.Visible = false;
            // 
            // dropBtn2
            // 
            this.dropBtn2.Location = new System.Drawing.Point(16, 238);
            this.dropBtn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropBtn2.Name = "dropBtn2";
            this.dropBtn2.Size = new System.Drawing.Size(213, 86);
            this.dropBtn2.TabIndex = 7;
            this.dropBtn2.Text = "Edit Reservation";
            this.dropBtn2.UseVisualStyleBackColor = true;
            this.dropBtn2.Visible = false;
            // 
            // dropBtn3
            // 
            this.dropBtn3.Location = new System.Drawing.Point(16, 331);
            this.dropBtn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropBtn3.Name = "dropBtn3";
            this.dropBtn3.Size = new System.Drawing.Size(213, 86);
            this.dropBtn3.TabIndex = 8;
            this.dropBtn3.Text = "Cancel Reservation";
            this.dropBtn3.UseVisualStyleBackColor = true;
            this.dropBtn3.Visible = false;
            // 
            // dropBtn4
            // 
            this.dropBtn4.Location = new System.Drawing.Point(16, 425);
            this.dropBtn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropBtn4.Name = "dropBtn4";
            this.dropBtn4.Size = new System.Drawing.Size(213, 86);
            this.dropBtn4.TabIndex = 9;
            this.dropBtn4.Text = "*No Use*";
            this.dropBtn4.UseVisualStyleBackColor = true;
            this.dropBtn4.Visible = false;
            // 
            // dropBtn5
            // 
            this.dropBtn5.Location = new System.Drawing.Point(16, 518);
            this.dropBtn5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropBtn5.Name = "dropBtn5";
            this.dropBtn5.Size = new System.Drawing.Size(213, 86);
            this.dropBtn5.TabIndex = 10;
            this.dropBtn5.Text = "*No Use*";
            this.dropBtn5.UseVisualStyleBackColor = true;
            this.dropBtn5.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 620);
            this.Controls.Add(this.dropBtn5);
            this.Controls.Add(this.dropBtn4);
            this.Controls.Add(this.dropBtn3);
            this.Controls.Add(this.dropBtn2);
            this.Controls.Add(this.dropBtn1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.employeeSectionBtn);
            this.Controls.Add(this.clientsBtn);
            this.Controls.Add(this.billingBtn);
            this.Controls.Add(this.roomManagementBtn);
            this.Controls.Add(this.reservationsBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Hotel Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reservationsBtn;
        private System.Windows.Forms.Button roomManagementBtn;
        private System.Windows.Forms.Button billingBtn;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button employeeSectionBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button dropBtn1;
        private System.Windows.Forms.Button dropBtn2;
        private System.Windows.Forms.Button dropBtn3;
        private System.Windows.Forms.Button dropBtn4;
        private System.Windows.Forms.Button dropBtn5;
    }
}


namespace Test1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_contact = new System.Windows.Forms.Button();
            this.btn_calendar = new System.Windows.Forms.Button();
            this.btn_analytics = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_contact);
            this.panel1.Controls.Add(this.btn_calendar);
            this.panel1.Controls.Add(this.btn_analytics);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 162);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(2, 81);
            this.pnlNav.TabIndex = 2;
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.Location = new System.Drawing.Point(0, 530);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(186, 47);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            this.btn_settings.Leave += new System.EventHandler(this.btn_settings_Leave);
            // 
            // btn_contact
            // 
            this.btn_contact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_contact.FlatAppearance.BorderSize = 0;
            this.btn_contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contact.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_contact.Image = ((System.Drawing.Image)(resources.GetObject("btn_contact.Image")));
            this.btn_contact.Location = new System.Drawing.Point(0, 318);
            this.btn_contact.Name = "btn_contact";
            this.btn_contact.Size = new System.Drawing.Size(186, 58);
            this.btn_contact.TabIndex = 1;
            this.btn_contact.Text = "Contact us";
            this.btn_contact.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_contact.UseVisualStyleBackColor = true;
            this.btn_contact.Click += new System.EventHandler(this.btn_contact_Click);
            this.btn_contact.Leave += new System.EventHandler(this.btn_contact_Leave);
            // 
            // btn_calendar
            // 
            this.btn_calendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_calendar.FlatAppearance.BorderSize = 0;
            this.btn_calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calendar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_calendar.Image = ((System.Drawing.Image)(resources.GetObject("btn_calendar.Image")));
            this.btn_calendar.Location = new System.Drawing.Point(0, 260);
            this.btn_calendar.Name = "btn_calendar";
            this.btn_calendar.Size = new System.Drawing.Size(186, 58);
            this.btn_calendar.TabIndex = 1;
            this.btn_calendar.Text = "Calendar";
            this.btn_calendar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_calendar.UseVisualStyleBackColor = true;
            this.btn_calendar.Click += new System.EventHandler(this.btn_calendar_Click);
            this.btn_calendar.Leave += new System.EventHandler(this.btn_calendar_Leave);
            // 
            // btn_analytics
            // 
            this.btn_analytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_analytics.FlatAppearance.BorderSize = 0;
            this.btn_analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analytics.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_analytics.Image = ((System.Drawing.Image)(resources.GetObject("btn_analytics.Image")));
            this.btn_analytics.Location = new System.Drawing.Point(0, 202);
            this.btn_analytics.Name = "btn_analytics";
            this.btn_analytics.Size = new System.Drawing.Size(186, 58);
            this.btn_analytics.TabIndex = 1;
            this.btn_analytics.Text = "Analytics";
            this.btn_analytics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_analytics.UseVisualStyleBackColor = true;
            this.btn_analytics.Click += new System.EventHandler(this.btn_analytics_Click);
            this.btn_analytics.Leave += new System.EventHandler(this.btn_analytics_Leave);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Image")));
            this.btn_dashboard.Location = new System.Drawing.Point(0, 144);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(186, 58);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            this.btn_dashboard.Leave += new System.EventHandler(this.btn_dashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lb_role);
            this.panel2.Controls.Add(this.lb_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lb_role.Location = new System.Drawing.Point(58, 113);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(70, 13);
            this.lb_role.TabIndex = 2;
            this.lb_role.Text = "Admin Role";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lb_username.Location = new System.Drawing.Point(52, 95);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(82, 16);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "User name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_contact;
        private System.Windows.Forms.Button btn_calendar;
        private System.Windows.Forms.Button btn_analytics;
        private System.Windows.Forms.FlowLayoutPanel pnlNav;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
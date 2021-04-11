
namespace Dashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlUserMail = new System.Windows.Forms.Panel();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbladmin = new System.Windows.Forms.Label();
            this.pnlManu = new System.Windows.Forms.Panel();
            this.btnChart = new System.Windows.Forms.Button();
            this.pictureBoxchart = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBoxDashboard = new System.Windows.Forms.PictureBox();
            this.pnlHomeDashboard = new System.Windows.Forms.Panel();
            this.lblDashbordHome = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pictureBoxTables = new System.Windows.Forms.PictureBox();
            this.pnlUserMail.SuspendLayout();
            this.pnlManu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).BeginInit();
            this.pnlHomeDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTables)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserMail
            // 
            this.pnlUserMail.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlUserMail.Controls.Add(this.btnMail);
            this.pnlUserMail.Controls.Add(this.btnUser);
            this.pnlUserMail.Controls.Add(this.button1);
            this.pnlUserMail.Controls.Add(this.lbladmin);
            this.pnlUserMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserMail.Location = new System.Drawing.Point(0, 0);
            this.pnlUserMail.Name = "pnlUserMail";
            this.pnlUserMail.Size = new System.Drawing.Size(981, 53);
            this.pnlUserMail.TabIndex = 0;
            // 
            // btnMail
            // 
            this.btnMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMail.BackgroundImage")));
            this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMail.FlatAppearance.BorderSize = 0;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Location = new System.Drawing.Point(878, 12);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(39, 35);
            this.btnMail.TabIndex = 3;
            this.btnMail.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUser.BackgroundImage")));
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Location = new System.Drawing.Point(933, 10);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(36, 37);
            this.btnUser.TabIndex = 2;
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(170, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbladmin.ForeColor = System.Drawing.Color.White;
            this.lbladmin.Location = new System.Drawing.Point(12, 18);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(136, 20);
            this.lbladmin.TabIndex = 0;
            this.lbladmin.Text = "Admin Dashboard";
            // 
            // pnlManu
            // 
            this.pnlManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlManu.Controls.Add(this.pictureBoxTables);
            this.pnlManu.Controls.Add(this.btnChart);
            this.pnlManu.Controls.Add(this.pictureBoxchart);
            this.pnlManu.Controls.Add(this.btnDashboard);
            this.pnlManu.Controls.Add(this.pictureBoxDashboard);
            this.pnlManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlManu.Location = new System.Drawing.Point(0, 53);
            this.pnlManu.Name = "pnlManu";
            this.pnlManu.Size = new System.Drawing.Size(202, 529);
            this.pnlManu.TabIndex = 1;
            // 
            // btnChart
            // 
            this.btnChart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChart.BackgroundImage")));
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChart.ForeColor = System.Drawing.Color.White;
            this.btnChart.Location = new System.Drawing.Point(56, 71);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(131, 47);
            this.btnChart.TabIndex = 3;
            this.btnChart.Text = "Chart";
            this.btnChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChart.UseVisualStyleBackColor = true;
            // 
            // pictureBoxchart
            // 
            this.pictureBoxchart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxchart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxchart.Image")));
            this.pictureBoxchart.Location = new System.Drawing.Point(12, 71);
            this.pictureBoxchart.Name = "pictureBoxchart";
            this.pictureBoxchart.Size = new System.Drawing.Size(47, 47);
            this.pictureBoxchart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxchart.TabIndex = 2;
            this.pictureBoxchart.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(56, 18);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(131, 47);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dahsboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDashboard
            // 
            this.pictureBoxDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDashboard.Image")));
            this.pictureBoxDashboard.Location = new System.Drawing.Point(12, 18);
            this.pictureBoxDashboard.Name = "pictureBoxDashboard";
            this.pictureBoxDashboard.Size = new System.Drawing.Size(47, 47);
            this.pictureBoxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDashboard.TabIndex = 0;
            this.pictureBoxDashboard.TabStop = false;
            // 
            // pnlHomeDashboard
            // 
            this.pnlHomeDashboard.BackColor = System.Drawing.Color.White;
            this.pnlHomeDashboard.Controls.Add(this.lblDashbordHome);
            this.pnlHomeDashboard.Controls.Add(this.lblDashboard);
            this.pnlHomeDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomeDashboard.Location = new System.Drawing.Point(202, 53);
            this.pnlHomeDashboard.Name = "pnlHomeDashboard";
            this.pnlHomeDashboard.Size = new System.Drawing.Size(779, 42);
            this.pnlHomeDashboard.TabIndex = 2;
            // 
            // lblDashbordHome
            // 
            this.lblDashbordHome.AutoSize = true;
            this.lblDashbordHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDashbordHome.Location = new System.Drawing.Point(600, 7);
            this.lblDashbordHome.Name = "lblDashbordHome";
            this.lblDashbordHome.Size = new System.Drawing.Size(171, 25);
            this.lblDashbordHome.TabIndex = 1;
            this.lblDashbordHome.Text = "Dashboard / Home";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDashboard.Location = new System.Drawing.Point(16, 7);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(109, 25);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // pictureBoxTables
            // 
            this.pictureBoxTables.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTables.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTables.Image")));
            this.pictureBoxTables.Location = new System.Drawing.Point(12, 124);
            this.pictureBoxTables.Name = "pictureBoxTables";
            this.pictureBoxTables.Size = new System.Drawing.Size(47, 47);
            this.pictureBoxTables.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTables.TabIndex = 4;
            this.pictureBoxTables.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(981, 582);
            this.Controls.Add(this.pnlHomeDashboard);
            this.Controls.Add(this.pnlManu);
            this.Controls.Add(this.pnlUserMail);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlUserMail.ResumeLayout(false);
            this.pnlUserMail.PerformLayout();
            this.pnlManu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDashboard)).EndInit();
            this.pnlHomeDashboard.ResumeLayout(false);
            this.pnlHomeDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBunner;
        private System.Windows.Forms.Label dsfdsfdsfsdf;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.PictureBox pictureBoxDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblDashbordHome;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Panel pnlUserMail;
        private System.Windows.Forms.Panel pnlManu;
        private System.Windows.Forms.Panel pnlHomeDashboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBoxchart;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxTables;
    }
}


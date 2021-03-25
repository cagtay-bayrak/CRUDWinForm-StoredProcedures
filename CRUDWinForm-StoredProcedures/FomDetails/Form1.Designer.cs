namespace FomDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnInvoice);
            this.panel1.Controls.Add(this.btnRegistration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 121);
            this.panel1.TabIndex = 0;
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Red;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistration.Image")));
            this.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.Location = new System.Drawing.Point(12, 12);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(188, 82);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistration.UseVisualStyleBackColor = false;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Red;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoice.Image")));
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.Location = new System.Drawing.Point(215, 12);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(135, 82);
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoice.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnRegistration;
    }
}


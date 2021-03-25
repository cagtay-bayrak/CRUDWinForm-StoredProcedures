namespace CRUDWinForm_StoredProcedures
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
            this.lblheader = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtProductid = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.cbocolor = new System.Windows.Forms.ComboBox();
            this.rdoStatus = new System.Windows.Forms.RadioButton();
            this.rdoRunning = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.grptransactions = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grptransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblheader.Location = new System.Drawing.Point(181, 20);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(469, 37);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "CRUD Operation-StoredProcedures";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductID.Location = new System.Drawing.Point(74, 71);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(91, 23);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "ProductID";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemName.Location = new System.Drawing.Point(66, 133);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(99, 23);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(112, 189);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(53, 23);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(81, 258);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 23);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // txtProductid
            // 
            this.txtProductid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductid.Location = new System.Drawing.Point(218, 62);
            this.txtProductid.Name = "txtProductid";
            this.txtProductid.Size = new System.Drawing.Size(323, 32);
            this.txtProductid.TabIndex = 2;
            // 
            // txtitemname
            // 
            this.txtitemname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtitemname.Location = new System.Drawing.Point(218, 124);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(323, 32);
            this.txtitemname.TabIndex = 3;
            // 
            // cbocolor
            // 
            this.cbocolor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbocolor.FormattingEnabled = true;
            this.cbocolor.Items.AddRange(new object[] {
            "Red",
            "Yellow"});
            this.cbocolor.Location = new System.Drawing.Point(218, 179);
            this.cbocolor.Name = "cbocolor";
            this.cbocolor.Size = new System.Drawing.Size(323, 33);
            this.cbocolor.TabIndex = 4;
            // 
            // rdoStatus
            // 
            this.rdoStatus.AutoSize = true;
            this.rdoStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoStatus.Location = new System.Drawing.Point(219, 237);
            this.rdoStatus.Name = "rdoStatus";
            this.rdoStatus.Size = new System.Drawing.Size(83, 29);
            this.rdoStatus.TabIndex = 5;
            this.rdoStatus.TabStop = true;
            this.rdoStatus.Text = "Status";
            this.rdoStatus.UseVisualStyleBackColor = true;
            // 
            // rdoRunning
            // 
            this.rdoRunning.AutoSize = true;
            this.rdoRunning.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoRunning.Location = new System.Drawing.Point(218, 272);
            this.rdoRunning.Name = "rdoRunning";
            this.rdoRunning.Size = new System.Drawing.Size(104, 29);
            this.rdoRunning.TabIndex = 6;
            this.rdoRunning.TabStop = true;
            this.rdoRunning.Text = "Running";
            this.rdoRunning.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(218, 466);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(114, 45);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // grptransactions
            // 
            this.grptransactions.Controls.Add(this.btnSearch);
            this.grptransactions.Controls.Add(this.btndelete);
            this.grptransactions.Controls.Add(this.btnupdate);
            this.grptransactions.Controls.Add(this.txtAddress);
            this.grptransactions.Controls.Add(this.lblAddress);
            this.grptransactions.Controls.Add(this.dataGridView1);
            this.grptransactions.Controls.Add(this.lblProductID);
            this.grptransactions.Controls.Add(this.btnInsert);
            this.grptransactions.Controls.Add(this.txtProductid);
            this.grptransactions.Controls.Add(this.rdoRunning);
            this.grptransactions.Controls.Add(this.txtitemname);
            this.grptransactions.Controls.Add(this.rdoStatus);
            this.grptransactions.Controls.Add(this.lblItemName);
            this.grptransactions.Controls.Add(this.cbocolor);
            this.grptransactions.Controls.Add(this.lblCategory);
            this.grptransactions.Controls.Add(this.lblColor);
            this.grptransactions.Location = new System.Drawing.Point(12, 74);
            this.grptransactions.Name = "grptransactions";
            this.grptransactions.Size = new System.Drawing.Size(895, 956);
            this.grptransactions.TabIndex = 9;
            this.grptransactions.TabStop = false;
            this.grptransactions.Text = "Transactions";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(486, 466);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(114, 45);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Navy;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(350, 466);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(114, 45);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(218, 330);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(471, 119);
            this.txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(92, 317);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 25);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Adres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 549);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(756, 313);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(558, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 45);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 1055);
            this.Controls.Add(this.grptransactions);
            this.Controls.Add(this.lblheader);
            this.Name = "Form1";
            this.Text = "CRUD FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grptransactions.ResumeLayout(false);
            this.grptransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductid;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.ComboBox cbocolor;
        private System.Windows.Forms.RadioButton rdoStatus;
        private System.Windows.Forms.RadioButton rdoRunning;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox grptransactions;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnSearch;
    }
}


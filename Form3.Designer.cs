namespace DBrecords
{
    partial class frmViewDoctor
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
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.txtCpNum = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblCpNum = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.lblSpec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(71, 157);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(63, 16);
            this.lblDoctorID.TabIndex = 41;
            this.lblDoctorID.Text = "Doctor ID";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(161, 151);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(181, 22);
            this.txtDoctorID.TabIndex = 40;
            // 
            // txtCpNum
            // 
            this.txtCpNum.Location = new System.Drawing.Point(459, 175);
            this.txtCpNum.Name = "txtCpNum";
            this.txtCpNum.Size = new System.Drawing.Size(181, 22);
            this.txtCpNum.TabIndex = 39;
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(459, 216);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(181, 22);
            this.txtSpec.TabIndex = 38;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(459, 130);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(181, 22);
            this.txtSex.TabIndex = 37;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(459, 98);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(181, 22);
            this.txtAge.TabIndex = 36;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(459, 60);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(181, 22);
            this.txtLname.TabIndex = 35;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(459, 28);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(181, 22);
            this.txtFname.TabIndex = 34;
            // 
            // lblCpNum
            // 
            this.lblCpNum.AutoSize = true;
            this.lblCpNum.Location = new System.Drawing.Point(361, 181);
            this.lblCpNum.Name = "lblCpNum";
            this.lblCpNum.Size = new System.Drawing.Size(32, 16);
            this.lblCpNum.TabIndex = 33;
            this.lblCpNum.Text = "CP#";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(361, 139);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(30, 16);
            this.lblSex.TabIndex = 31;
            this.lblSex.Text = "Sex";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(361, 98);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 30;
            this.lblAge.Text = "Age";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(361, 60);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(72, 16);
            this.lblLname.TabIndex = 29;
            this.lblLname.Text = "Last Name";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(361, 27);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(72, 16);
            this.lblFname.TabIndex = 28;
            this.lblFname.Text = "First Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(161, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 22);
            this.txtSearch.TabIndex = 27;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(68, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(149, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(149, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(68, 71);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(68, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(68, 244);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 24;
            this.dgvShow.Size = new System.Drawing.Size(698, 263);
            this.dgvShow.TabIndex = 21;
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(361, 219);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(91, 16);
            this.lblSpec.TabIndex = 42;
            this.lblSpec.Text = "Specialization";
            // 
            // frmViewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 535);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.txtCpNum);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblCpNum);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvShow);
            this.Name = "frmViewDoctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.frmViewDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.TextBox txtCpNum;
        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblCpNum;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Label lblSpec;
    }
}
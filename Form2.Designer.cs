namespace DBrecords
{
    partial class frmViewPatients
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
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBday = new System.Windows.Forms.Label();
            this.lblCpNum = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCpNum = new System.Windows.Forms.TextBox();
            this.txtBday = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(30, 239);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 24;
            this.dgvShow.Size = new System.Drawing.Size(698, 263);
            this.dgvShow.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(111, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(111, 90);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(192, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(192, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(111, 129);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(323, 22);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(72, 16);
            this.lblFname.TabIndex = 7;
            this.lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(323, 55);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(72, 16);
            this.lblLname.TabIndex = 8;
            this.lblLname.Text = "Last Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(323, 93);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(323, 134);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(30, 16);
            this.lblSex.TabIndex = 10;
            this.lblSex.Text = "Sex";
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Location = new System.Drawing.Point(323, 169);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(56, 16);
            this.lblBday.TabIndex = 11;
            this.lblBday.Text = "Birthday";
            // 
            // lblCpNum
            // 
            this.lblCpNum.AutoSize = true;
            this.lblCpNum.Location = new System.Drawing.Point(323, 198);
            this.lblCpNum.Name = "lblCpNum";
            this.lblCpNum.Size = new System.Drawing.Size(32, 16);
            this.lblCpNum.TabIndex = 12;
            this.lblCpNum.Text = "CP#";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(421, 23);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(181, 22);
            this.txtFname.TabIndex = 13;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(421, 55);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(181, 22);
            this.txtLname.TabIndex = 14;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(421, 125);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(181, 22);
            this.txtSex.TabIndex = 16;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(421, 93);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(181, 22);
            this.txtAge.TabIndex = 15;
            // 
            // txtCpNum
            // 
            this.txtCpNum.Location = new System.Drawing.Point(421, 201);
            this.txtCpNum.Name = "txtCpNum";
            this.txtCpNum.Size = new System.Drawing.Size(181, 22);
            this.txtCpNum.TabIndex = 18;
            // 
            // txtBday
            // 
            this.txtBday.Location = new System.Drawing.Point(421, 169);
            this.txtBday.Name = "txtBday";
            this.txtBday.Size = new System.Drawing.Size(181, 22);
            this.txtBday.TabIndex = 17;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(111, 23);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(181, 22);
            this.txtPatientID.TabIndex = 19;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(41, 29);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(64, 16);
            this.lblPatientID.TabIndex = 20;
            this.lblPatientID.Text = "Patient ID";
            // 
            // frmViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 535);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.txtCpNum);
            this.Controls.Add(this.txtBday);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblCpNum);
            this.Controls.Add(this.lblBday);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvShow);
            this.Name = "frmViewPatients";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.frmViewPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.Label lblCpNum;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCpNum;
        private System.Windows.Forms.TextBox txtBday;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblPatientID;
    }
}
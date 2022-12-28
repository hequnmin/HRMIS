namespace AntsUI
{
    partial class frmDatabase
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTesting = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOnline);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.lblDatabase);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.txtHost);
            this.groupBox1.Controls.Add(this.lblHost);
            this.groupBox1.Location = new System.Drawing.Point(21, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(381, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkOnline
            // 
            this.chkOnline.AutoSize = true;
            this.chkOnline.Checked = true;
            this.chkOnline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnline.Location = new System.Drawing.Point(155, 214);
            this.chkOnline.Name = "chkOnline";
            this.chkOnline.Size = new System.Drawing.Size(78, 24);
            this.chkOnline.TabIndex = 8;
            this.chkOnline.Text = "Online";
            this.chkOnline.UseVisualStyleBackColor = true;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(153, 106);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(180, 27);
            this.txtDatabase.TabIndex = 5;
            this.txtDatabase.Text = "ate2020";
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(27, 106);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(120, 20);
            this.lblDatabase.TabIndex = 10;
            this.lblDatabase.Text = "Database";
            this.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(153, 178);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(180, 27);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Blueway123456";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(27, 178);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 20);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(27, 142);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(120, 20);
            this.lblUserID.TabIndex = 7;
            this.lblUserID.Text = "User Name";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(153, 142);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(180, 27);
            this.txtUserID.TabIndex = 6;
            this.txtUserID.Text = "postgres";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(153, 70);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(180, 27);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "5432";
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(27, 70);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(120, 20);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(153, 34);
            this.txtHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(180, 27);
            this.txtHost.TabIndex = 3;
            this.txtHost.Text = "10.15.2.98";
            // 
            // lblHost
            // 
            this.lblHost.Location = new System.Drawing.Point(27, 34);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(120, 20);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Server Name / IP";
            this.lblHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(236, 279);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(322, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTesting
            // 
            this.btnTesting.Location = new System.Drawing.Point(21, 279);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(80, 35);
            this.btnTesting.TabIndex = 1;
            this.btnTesting.Text = "Testing";
            this.btnTesting.UseVisualStyleBackColor = true;
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 330);
            this.Controls.Add(this.btnTesting);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDatabase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.Load += new System.EventHandler(this.frmDatabase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.CheckBox chkOnline;
    }
}
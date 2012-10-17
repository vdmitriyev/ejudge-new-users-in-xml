namespace CreateXMLWithNewEjudgeUsers
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
            this.btnGenerateNewUsers = new System.Windows.Forms.Button();
            this.grbUsersConfigs = new System.Windows.Forms.GroupBox();
            this.txtEjudgeLoginStartNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEjudgeLoginPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEjudgeStartID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPathToPrintFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPathToXML = new System.Windows.Forms.TextBox();
            this.txtPathToCSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbUsersConfigs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateNewUsers
            // 
            this.btnGenerateNewUsers.Location = new System.Drawing.Point(12, 284);
            this.btnGenerateNewUsers.Name = "btnGenerateNewUsers";
            this.btnGenerateNewUsers.Size = new System.Drawing.Size(551, 30);
            this.btnGenerateNewUsers.TabIndex = 4;
            this.btnGenerateNewUsers.Text = "Generate logins";
            this.btnGenerateNewUsers.UseVisualStyleBackColor = true;
            this.btnGenerateNewUsers.Click += new System.EventHandler(this.btnGenerateNewUsers_Click);
            // 
            // grbUsersConfigs
            // 
            this.grbUsersConfigs.Controls.Add(this.txtEjudgeLoginStartNumber);
            this.grbUsersConfigs.Controls.Add(this.label5);
            this.grbUsersConfigs.Controls.Add(this.txtEjudgeLoginPrefix);
            this.grbUsersConfigs.Controls.Add(this.label4);
            this.grbUsersConfigs.Controls.Add(this.txtEjudgeStartID);
            this.grbUsersConfigs.Controls.Add(this.label3);
            this.grbUsersConfigs.Location = new System.Drawing.Point(12, 150);
            this.grbUsersConfigs.Name = "grbUsersConfigs";
            this.grbUsersConfigs.Size = new System.Drawing.Size(551, 115);
            this.grbUsersConfigs.TabIndex = 5;
            this.grbUsersConfigs.TabStop = false;
            this.grbUsersConfigs.Text = "User configs";
            // 
            // txtEjudgeLoginStartNumber
            // 
            this.txtEjudgeLoginStartNumber.Location = new System.Drawing.Point(145, 83);
            this.txtEjudgeLoginStartNumber.Name = "txtEjudgeLoginStartNumber";
            this.txtEjudgeLoginStartNumber.Size = new System.Drawing.Size(240, 20);
            this.txtEjudgeLoginStartNumber.TabIndex = 12;
            this.txtEjudgeLoginStartNumber.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start number(Ejudge login)";
            // 
            // txtEjudgeLoginPrefix
            // 
            this.txtEjudgeLoginPrefix.Location = new System.Drawing.Point(145, 55);
            this.txtEjudgeLoginPrefix.Name = "txtEjudgeLoginPrefix";
            this.txtEjudgeLoginPrefix.Size = new System.Drawing.Size(240, 20);
            this.txtEjudgeLoginPrefix.TabIndex = 10;
            this.txtEjudgeLoginPrefix.Text = "K";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ejudge login prefix";
            // 
            // txtEjudgeStartID
            // 
            this.txtEjudgeStartID.Location = new System.Drawing.Point(146, 26);
            this.txtEjudgeStartID.Name = "txtEjudgeStartID";
            this.txtEjudgeStartID.Size = new System.Drawing.Size(240, 20);
            this.txtEjudgeStartID.TabIndex = 8;
            this.txtEjudgeStartID.Text = "2001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ejudge start id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPathToPrintFile);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPathToXML);
            this.groupBox1.Controls.Add(this.txtPathToCSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File paths";
            // 
            // txtPathToPrintFile
            // 
            this.txtPathToPrintFile.Location = new System.Drawing.Point(146, 74);
            this.txtPathToPrintFile.Name = "txtPathToPrintFile";
            this.txtPathToPrintFile.Size = new System.Drawing.Size(399, 20);
            this.txtPathToPrintFile.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Path to print file";
            // 
            // txtPathToXML
            // 
            this.txtPathToXML.Location = new System.Drawing.Point(146, 44);
            this.txtPathToXML.Name = "txtPathToXML";
            this.txtPathToXML.Size = new System.Drawing.Size(399, 20);
            this.txtPathToXML.TabIndex = 7;
            // 
            // txtPathToCSV
            // 
            this.txtPathToCSV.Location = new System.Drawing.Point(146, 18);
            this.txtPathToCSV.Name = "txtPathToCSV";
            this.txtPathToCSV.Size = new System.Drawing.Size(399, 20);
            this.txtPathToCSV.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path to XML (output)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path to CSV";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbUsersConfigs);
            this.Controls.Add(this.btnGenerateNewUsers);
            this.Name = "MainForm";
            this.Text = "Create XML with New Ejudge Users and Logins";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbUsersConfigs.ResumeLayout(false);
            this.grbUsersConfigs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateNewUsers;
        private System.Windows.Forms.GroupBox grbUsersConfigs;
        private System.Windows.Forms.TextBox txtEjudgeLoginStartNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEjudgeLoginPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEjudgeStartID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPathToXML;
        private System.Windows.Forms.TextBox txtPathToCSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathToPrintFile;
        private System.Windows.Forms.Label label6;

    }
}


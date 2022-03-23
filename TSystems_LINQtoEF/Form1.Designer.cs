namespace TSystems_LINQtoEF
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.textDesignation = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(582, 153);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 38;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(582, 112);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(437, 315);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 36;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(294, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(294, 230);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(100, 20);
            this.textSalary.TabIndex = 33;
            // 
            // textDesignation
            // 
            this.textDesignation.Location = new System.Drawing.Point(294, 194);
            this.textDesignation.Name = "textDesignation";
            this.textDesignation.Size = new System.Drawing.Size(100, 20);
            this.textDesignation.TabIndex = 32;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(294, 158);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 31;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(294, 122);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 30;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(143, 237);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 29;
            this.lblSalary.Text = "Salary";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(143, 194);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 28;
            this.lblDesignation.Text = "Designation";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(143, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(143, 122);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 26;
            this.lblId.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.textDesignation);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.TextBox textDesignation;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
    }
}


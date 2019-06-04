namespace DemoProject.ChildForms
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSettingsTable = new System.Windows.Forms.Panel();
            this.lblStepRepeatPassword = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblStepPassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblStepLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSettingsTable.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelSettingsTable, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 543);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelSettingsTable
            // 
            this.panelSettingsTable.Controls.Add(this.lblStepRepeatPassword);
            this.panelSettingsTable.Controls.Add(this.label7);
            this.panelSettingsTable.Controls.Add(this.tbRepeatPassword);
            this.panelSettingsTable.Controls.Add(this.lblStepPassword);
            this.panelSettingsTable.Controls.Add(this.label5);
            this.panelSettingsTable.Controls.Add(this.tbPassword);
            this.panelSettingsTable.Controls.Add(this.lblStepLogin);
            this.panelSettingsTable.Controls.Add(this.label2);
            this.panelSettingsTable.Controls.Add(this.tbLogin);
            this.panelSettingsTable.Controls.Add(this.label1);
            this.panelSettingsTable.Location = new System.Drawing.Point(332, 3);
            this.panelSettingsTable.Name = "panelSettingsTable";
            this.panelSettingsTable.Size = new System.Drawing.Size(474, 434);
            this.panelSettingsTable.TabIndex = 0;
            // 
            // lblStepRepeatPassword
            // 
            this.lblStepRepeatPassword.AutoSize = true;
            this.lblStepRepeatPassword.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblStepRepeatPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStepRepeatPassword.Location = new System.Drawing.Point(66, 370);
            this.lblStepRepeatPassword.Name = "lblStepRepeatPassword";
            this.lblStepRepeatPassword.Size = new System.Drawing.Size(55, 39);
            this.lblStepRepeatPassword.TabIndex = 9;
            this.lblStepRepeatPassword.Text = ">>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label7.Location = new System.Drawing.Point(19, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 39);
            this.label7.TabIndex = 8;
            this.label7.Text = "Repeat password";
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbRepeatPassword.Location = new System.Drawing.Point(147, 367);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.PasswordChar = '*';
            this.tbRepeatPassword.Size = new System.Drawing.Size(255, 47);
            this.tbRepeatPassword.TabIndex = 7;
            this.tbRepeatPassword.TextChanged += new System.EventHandler(this.TbRepeatPassword_TextChanged);
            // 
            // lblStepPassword
            // 
            this.lblStepPassword.AutoSize = true;
            this.lblStepPassword.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblStepPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStepPassword.Location = new System.Drawing.Point(66, 264);
            this.lblStepPassword.Name = "lblStepPassword";
            this.lblStepPassword.Size = new System.Drawing.Size(55, 39);
            this.lblStepPassword.TabIndex = 6;
            this.lblStepPassword.Text = ">>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label5.Location = new System.Drawing.Point(19, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbPassword.Location = new System.Drawing.Point(147, 261);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(255, 47);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TextChanged += new System.EventHandler(this.TbPassword_TextChanged);
            // 
            // lblStepLogin
            // 
            this.lblStepLogin.AutoSize = true;
            this.lblStepLogin.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.lblStepLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStepLogin.Location = new System.Drawing.Point(66, 150);
            this.lblStepLogin.Name = "lblStepLogin";
            this.lblStepLogin.Size = new System.Drawing.Size(55, 39);
            this.lblStepLogin.TabIndex = 3;
            this.lblStepLogin.Text = ">>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.tbLogin.Location = new System.Drawing.Point(147, 147);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(255, 47);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.TextChanged += new System.EventHandler(this.TbLogin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(100, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.59145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.40855F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 443);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1139, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Location = new System.Drawing.Point(268, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 83);
            this.panel2.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRegister.Image = global::DemoProject.Properties.Resources.like;
            this.btnRegister.Location = new System.Drawing.Point(174, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(227, 77);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 543);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormRegister";
            this.Text = "Registration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelSettingsTable.ResumeLayout(false);
            this.panelSettingsTable.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelSettingsTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblStepRepeatPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRepeatPassword;
        private System.Windows.Forms.Label lblStepPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblStepLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label1;
    }
}
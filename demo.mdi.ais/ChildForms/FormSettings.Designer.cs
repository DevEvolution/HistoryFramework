namespace DemoProject.ChildForms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSettingsTable = new System.Windows.Forms.Panel();
            this.btnErrorColor = new System.Windows.Forms.Button();
            this.btnMessageColor = new System.Windows.Forms.Button();
            this.btnHighlightColor = new System.Windows.Forms.Button();
            this.btnStaticColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDecline = new System.Windows.Forms.Button();
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
            this.panelSettingsTable.Controls.Add(this.btnErrorColor);
            this.panelSettingsTable.Controls.Add(this.btnMessageColor);
            this.panelSettingsTable.Controls.Add(this.btnHighlightColor);
            this.panelSettingsTable.Controls.Add(this.btnStaticColor);
            this.panelSettingsTable.Controls.Add(this.label5);
            this.panelSettingsTable.Controls.Add(this.label4);
            this.panelSettingsTable.Controls.Add(this.label3);
            this.panelSettingsTable.Controls.Add(this.label2);
            this.panelSettingsTable.Controls.Add(this.label1);
            this.panelSettingsTable.Location = new System.Drawing.Point(166, 3);
            this.panelSettingsTable.Name = "panelSettingsTable";
            this.panelSettingsTable.Size = new System.Drawing.Size(806, 434);
            this.panelSettingsTable.TabIndex = 0;
            // 
            // btnErrorColor
            // 
            this.btnErrorColor.BackColor = System.Drawing.Color.Red;
            this.btnErrorColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorColor.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnErrorColor.Location = new System.Drawing.Point(571, 275);
            this.btnErrorColor.Name = "btnErrorColor";
            this.btnErrorColor.Size = new System.Drawing.Size(193, 55);
            this.btnErrorColor.TabIndex = 12;
            this.btnErrorColor.UseVisualStyleBackColor = false;
            this.btnErrorColor.Click += new System.EventHandler(this.BtnErrorColor_Click);
            // 
            // btnMessageColor
            // 
            this.btnMessageColor.BackColor = System.Drawing.Color.Black;
            this.btnMessageColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageColor.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMessageColor.Location = new System.Drawing.Point(571, 212);
            this.btnMessageColor.Name = "btnMessageColor";
            this.btnMessageColor.Size = new System.Drawing.Size(193, 55);
            this.btnMessageColor.TabIndex = 11;
            this.btnMessageColor.UseVisualStyleBackColor = false;
            this.btnMessageColor.Click += new System.EventHandler(this.BtnMessageColor_Click);
            // 
            // btnHighlightColor
            // 
            this.btnHighlightColor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHighlightColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighlightColor.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHighlightColor.Location = new System.Drawing.Point(571, 151);
            this.btnHighlightColor.Name = "btnHighlightColor";
            this.btnHighlightColor.Size = new System.Drawing.Size(193, 55);
            this.btnHighlightColor.TabIndex = 10;
            this.btnHighlightColor.UseVisualStyleBackColor = false;
            this.btnHighlightColor.Click += new System.EventHandler(this.BtnHighlightColor_Click);
            // 
            // btnStaticColor
            // 
            this.btnStaticColor.BackColor = System.Drawing.Color.Black;
            this.btnStaticColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaticColor.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStaticColor.Location = new System.Drawing.Point(571, 87);
            this.btnStaticColor.Name = "btnStaticColor";
            this.btnStaticColor.Size = new System.Drawing.Size(193, 55);
            this.btnStaticColor.TabIndex = 9;
            this.btnStaticColor.UseVisualStyleBackColor = false;
            this.btnStaticColor.Click += new System.EventHandler(this.BtnStaticColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "Error color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Highlight color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "Static color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(296, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAccept.Image = global::DemoProject.Properties.Resources.like;
            this.btnAccept.Location = new System.Drawing.Point(316, 0);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(236, 77);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.59145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.40855F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
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
            this.panel2.Controls.Add(this.btnDecline);
            this.panel2.Controls.Add(this.btnAccept);
            this.panel2.Location = new System.Drawing.Point(268, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 83);
            this.panel2.TabIndex = 0;
            // 
            // btnDecline
            // 
            this.btnDecline.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecline.ForeColor = System.Drawing.Color.Red;
            this.btnDecline.Image = global::DemoProject.Properties.Resources.user;
            this.btnDecline.Location = new System.Drawing.Point(24, 0);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(236, 77);
            this.btnDecline.TabIndex = 3;
            this.btnDecline.Text = "Decline";
            this.btnDecline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.BtnDecline_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 543);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormSettings";
            this.Text = "Settings";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnErrorColor;
        private System.Windows.Forms.Button btnMessageColor;
        private System.Windows.Forms.Button btnHighlightColor;
        private System.Windows.Forms.Button btnStaticColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDecline;
    }
}
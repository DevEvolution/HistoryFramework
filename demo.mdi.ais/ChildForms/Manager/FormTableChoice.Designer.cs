namespace demo.mdi.ais.ChildForms.Manager
{
    partial class FormTableChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableChoice));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDistances = new System.Windows.Forms.Button();
            this.btnDistricts = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1319, 639);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(427, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 633);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDistances);
            this.flowLayoutPanel1.Controls.Add(this.btnDistricts);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(464, 633);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDistances
            // 
            this.btnDistances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistances.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDistances.Image = global::demo.mdi.ais.Properties.Resources.networking;
            this.btnDistances.Location = new System.Drawing.Point(3, 40);
            this.btnDistances.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.btnDistances.Name = "btnDistances";
            this.btnDistances.Size = new System.Drawing.Size(461, 130);
            this.btnDistances.TabIndex = 8;
            this.btnDistances.Text = "Изменение данных о расстояниях между торговыми точками";
            this.btnDistances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDistances.UseVisualStyleBackColor = true;
            this.btnDistances.Click += new System.EventHandler(this.btnDistances_Click);
            // 
            // btnDistricts
            // 
            this.btnDistricts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistricts.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDistricts.Image = global::demo.mdi.ais.Properties.Resources.compass;
            this.btnDistricts.Location = new System.Drawing.Point(3, 213);
            this.btnDistricts.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.btnDistricts.Name = "btnDistricts";
            this.btnDistricts.Size = new System.Drawing.Size(461, 110);
            this.btnDistricts.TabIndex = 7;
            this.btnDistricts.Text = "Изменение данных о районах доставки";
            this.btnDistricts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDistricts.UseVisualStyleBackColor = true;
            this.btnDistricts.Click += new System.EventHandler(this.btnDistricts_Click);
            // 
            // FormTableChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 639);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormTableChoice";
            this.Text = "Пожалуйста, выберите таблицу для изменения";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDistances;
        private System.Windows.Forms.Button btnDistricts;
    }
}
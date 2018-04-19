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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDistricts = new System.Windows.Forms.Button();
            this.btnDistances = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDistricts
            // 
            this.btnDistricts.Location = new System.Drawing.Point(566, 76);
            this.btnDistricts.Name = "btnDistricts";
            this.btnDistricts.Size = new System.Drawing.Size(323, 44);
            this.btnDistricts.TabIndex = 1;
            this.btnDistricts.Text = "Изменение данных о районах доставки";
            this.btnDistricts.UseVisualStyleBackColor = true;
            this.btnDistricts.Click += new System.EventHandler(this.btnDistricts_Click);
            // 
            // btnDistances
            // 
            this.btnDistances.Location = new System.Drawing.Point(566, 144);
            this.btnDistances.Name = "btnDistances";
            this.btnDistances.Size = new System.Drawing.Size(356, 83);
            this.btnDistances.TabIndex = 2;
            this.btnDistances.Text = "Изменение данных о расстояниях между торговыми точками";
            this.btnDistances.UseVisualStyleBackColor = true;
            this.btnDistances.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пожалуйста, выберите таблицу для изменения.";
            // 
            // FormTableChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDistances);
            this.Controls.Add(this.btnDistricts);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormTableChoice";
            this.Text = "FormTableChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDistricts;
        private System.Windows.Forms.Button btnDistances;
        private System.Windows.Forms.Label label1;
    }
}
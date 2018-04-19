namespace demo.mdi.ais.ChildForms.Manager
{
    partial class FormUpdateDelete
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
            this.btnUpdateDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateDelete
            // 
            this.btnUpdateDelete.Location = new System.Drawing.Point(266, 94);
            this.btnUpdateDelete.Name = "btnUpdateDelete";
            this.btnUpdateDelete.Size = new System.Drawing.Size(259, 104);
            this.btnUpdateDelete.TabIndex = 0;
            this.btnUpdateDelete.Text = "Изменить";
            this.btnUpdateDelete.UseVisualStyleBackColor = true;
            // 
            // FormUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 575);
            this.Controls.Add(this.btnUpdateDelete);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormUpdateDelete";
            this.Text = "FormUpdateDelete";
            this.Load += new System.EventHandler(this.FormUpdateDelete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateDelete;
    }
}
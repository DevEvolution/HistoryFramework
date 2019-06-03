namespace HistoryFramework
{
    partial class HistoryToolstrip
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblFormArticle = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward,
            this.toolStripSeparator1,
            this.lblFormArticle});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(893, 72);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Image = global::HistoryFramework.Properties.Resources.back64;
            this.btnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 69);
            this.btnBack.Text = "Назад";
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward.Image = global::HistoryFramework.Properties.Resources.next64;
            this.btnForward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(68, 69);
            this.btnForward.Text = "Вперед";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // lblFormArticle
            // 
            this.lblFormArticle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblFormArticle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormArticle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFormArticle.Image = global::HistoryFramework.Properties.Resources.compass;
            this.lblFormArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFormArticle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lblFormArticle.Name = "lblFormArticle";
            this.lblFormArticle.Size = new System.Drawing.Size(285, 69);
            this.lblFormArticle.Text = "Article Name";
            this.lblFormArticle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // HistoryToolstrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip);
            this.Name = "HistoryToolstrip";
            this.Size = new System.Drawing.Size(893, 72);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        public System.Windows.Forms.ToolStripButton btnBack;
        public System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblFormArticle;
    }
}

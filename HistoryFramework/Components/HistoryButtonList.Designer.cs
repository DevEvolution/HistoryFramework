namespace HistoryFramework
{
    partial class HistoryButtonList
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
            this.flowLayoutHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutHistory
            // 
            this.flowLayoutHistory.AutoScroll = true;
            this.flowLayoutHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutHistory.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutHistory.Name = "flowLayoutHistory";
            this.flowLayoutHistory.Size = new System.Drawing.Size(231, 492);
            this.flowLayoutHistory.TabIndex = 7;
            // 
            // HistoryButtonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutHistory);
            this.Name = "HistoryButtonList";
            this.Size = new System.Drawing.Size(231, 492);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutHistory;
    }
}

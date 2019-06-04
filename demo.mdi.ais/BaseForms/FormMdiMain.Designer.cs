namespace DemoProject
{
    partial class FormMdiMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMdiMain));
            this.historyToolstrip = new HistoryFramework.HistoryToolstrip();
            this.historyController = new HistoryFramework.HistoryController(this.components);
            this.historyButtonList = new HistoryFramework.HistoryButtonList();
            this.historyStatus = new HistoryFramework.HistoryStatusStrip();
            this.historyFrameworkLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.historyFrameworkLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // historyToolstrip
            // 
            this.historyToolstrip.Background = System.Drawing.Color.White;
            this.historyToolstrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.historyToolstrip.Foreground = System.Drawing.SystemColors.ControlText;
            this.historyToolstrip.HistoryController = this.historyController;
            this.historyToolstrip.Location = new System.Drawing.Point(0, 0);
            this.historyToolstrip.Margin = new System.Windows.Forms.Padding(5);
            this.historyToolstrip.Name = "historyToolstrip";
            this.historyToolstrip.Size = new System.Drawing.Size(1414, 73);
            this.historyToolstrip.TabIndex = 8;
            // 
            // historyController
            // 
            this.historyController.BaseForm = this;
            this.historyController.HistoryButtonList = this.historyButtonList;
            this.historyController.HistoryStatusStrip = this.historyStatus;
            this.historyController.HistoryToolstrip = this.historyToolstrip;
            // 
            // historyButtonList
            // 
            this.historyButtonList.Background = System.Drawing.SystemColors.Window;
            this.historyButtonList.ButtonSize = new System.Drawing.Size(215, 60);
            this.historyButtonList.Dock = System.Windows.Forms.DockStyle.Left;
            this.historyButtonList.HighlightedColor = System.Drawing.SystemColors.Highlight;
            this.historyButtonList.HistoryController = this.historyController;
            this.historyButtonList.Location = new System.Drawing.Point(0, 73);
            this.historyButtonList.Margin = new System.Windows.Forms.Padding(5);
            this.historyButtonList.Name = "historyButtonList";
            this.historyButtonList.Size = new System.Drawing.Size(231, 632);
            this.historyButtonList.StaticColor = System.Drawing.SystemColors.ControlText;
            this.historyButtonList.TabIndex = 12;
            // 
            // historyStatus
            // 
            this.historyStatus.Background = System.Drawing.Color.White;
            this.historyStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.historyStatus.ErrorColor = System.Drawing.Color.Red;
            this.historyStatus.Foreground = System.Drawing.SystemColors.ControlText;
            this.historyStatus.HistoryController = this.historyController;
            this.historyStatus.Location = new System.Drawing.Point(0, 705);
            this.historyStatus.Margin = new System.Windows.Forms.Padding(5);
            this.historyStatus.MessageColor = System.Drawing.Color.Black;
            this.historyStatus.Name = "historyStatus";
            this.historyStatus.Size = new System.Drawing.Size(1414, 43);
            this.historyStatus.TabIndex = 11;
            // 
            // historyFrameworkLogo
            // 
            this.historyFrameworkLogo.Image = global::DemoProject.Properties.Resources.historyFramework;
            this.historyFrameworkLogo.Location = new System.Drawing.Point(171, 0);
            this.historyFrameworkLogo.Name = "historyFrameworkLogo";
            this.historyFrameworkLogo.Size = new System.Drawing.Size(174, 71);
            this.historyFrameworkLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.historyFrameworkLogo.TabIndex = 4;
            this.historyFrameworkLogo.TabStop = false;
            // 
            // FormMdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1414, 748);
            this.Controls.Add(this.historyButtonList);
            this.Controls.Add(this.historyStatus);
            this.Controls.Add(this.historyFrameworkLogo);
            this.Controls.Add(this.historyToolstrip);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMdiMain";
            this.Text = "MDI Main";
            this.Load += new System.EventHandler(this.FormMdiMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyFrameworkLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox historyFrameworkLogo;
        public HistoryFramework.HistoryToolstrip historyToolstrip;
        private HistoryFramework.HistoryButtonList historyButtonList;
        public HistoryFramework.HistoryStatusStrip historyStatus;
        private HistoryFramework.HistoryController historyController;
    }
}


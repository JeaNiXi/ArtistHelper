namespace ArtistHelper
{
    partial class ImageScreen
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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.remainingSecondsTextBox = new System.Windows.Forms.TextBox();
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.doneText = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.infoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainFolderBrowsingDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.buttonFlowLayoutPanel.SuspendLayout();
            this.infoFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.mainPictureBox, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.buttonFlowLayoutPanel, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.infoFlowLayoutPanel, 0, 2);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(424, 541);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.InitialImage = null;
            this.mainPictureBox.Location = new System.Drawing.Point(3, 3);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(418, 459);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // buttonFlowLayoutPanel
            // 
            this.buttonFlowLayoutPanel.Controls.Add(this.buttonOpenFolder);
            this.buttonFlowLayoutPanel.Controls.Add(this.remainingSecondsTextBox);
            this.buttonFlowLayoutPanel.Controls.Add(this.timeRemainingLabel);
            this.buttonFlowLayoutPanel.Controls.Add(this.timeLabel);
            this.buttonFlowLayoutPanel.Controls.Add(this.doneText);
            this.buttonFlowLayoutPanel.Controls.Add(this.countLabel);
            this.buttonFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFlowLayoutPanel.Location = new System.Drawing.Point(3, 468);
            this.buttonFlowLayoutPanel.Name = "buttonFlowLayoutPanel";
            this.buttonFlowLayoutPanel.Size = new System.Drawing.Size(418, 31);
            this.buttonFlowLayoutPanel.TabIndex = 3;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.AutoSize = true;
            this.buttonOpenFolder.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolder.TabIndex = 0;
            this.buttonOpenFolder.Text = "OpenFolder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // remainingSecondsTextBox
            // 
            this.remainingSecondsTextBox.AcceptsReturn = true;
            this.remainingSecondsTextBox.Location = new System.Drawing.Point(84, 3);
            this.remainingSecondsTextBox.Name = "remainingSecondsTextBox";
            this.remainingSecondsTextBox.Size = new System.Drawing.Size(36, 20);
            this.remainingSecondsTextBox.TabIndex = 5;
            this.remainingSecondsTextBox.Text = "60";
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeRemainingLabel.AutoSize = true;
            this.timeRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeRemainingLabel.Location = new System.Drawing.Point(126, 4);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(123, 20);
            this.timeRemainingLabel.TabIndex = 4;
            this.timeRemainingLabel.Text = "Time Remaining";
            this.timeRemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(255, 3);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(68, 23);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doneText
            // 
            this.doneText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.doneText.AutoSize = true;
            this.doneText.Location = new System.Drawing.Point(329, 8);
            this.doneText.Name = "doneText";
            this.doneText.Size = new System.Drawing.Size(33, 13);
            this.doneText.TabIndex = 6;
            this.doneText.Text = "Done";
            // 
            // countLabel
            // 
            this.countLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(368, 8);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(25, 13);
            this.countLabel.TabIndex = 7;
            this.countLabel.Text = "000";
            // 
            // infoFlowLayoutPanel
            // 
            this.infoFlowLayoutPanel.Controls.Add(this.textBox1);
            this.infoFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoFlowLayoutPanel.Location = new System.Drawing.Point(3, 505);
            this.infoFlowLayoutPanel.Name = "infoFlowLayoutPanel";
            this.infoFlowLayoutPanel.Size = new System.Drawing.Size(418, 33);
            this.infoFlowLayoutPanel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 0;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // ImageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(424, 541);
            this.Controls.Add(this.mainLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(430, 580);
            this.Name = "ImageScreen";
            this.Text = "Artist Helper";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ImageScreen_Load);
            this.mainLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.buttonFlowLayoutPanel.ResumeLayout(false);
            this.buttonFlowLayoutPanel.PerformLayout();
            this.infoFlowLayoutPanel.ResumeLayout(false);
            this.infoFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.FolderBrowserDialog mainFolderBrowsingDialogue;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayoutPanel;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.FlowLayoutPanel infoFlowLayoutPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeRemainingLabel;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.TextBox remainingSecondsTextBox;
        private System.Windows.Forms.Label doneText;
        private System.Windows.Forms.Label countLabel;
    }
}


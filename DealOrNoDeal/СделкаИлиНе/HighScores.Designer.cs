
namespace СделкаИлиНе
{
    partial class HighScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScores));
            this.btnClose = new System.Windows.Forms.Button();
            this.rtbSelectedPlayerInfo = new System.Windows.Forms.RichTextBox();
            this.lbHighScores = new System.Windows.Forms.ListBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCloseHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(12, 243);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Към менюто";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtbSelectedPlayerInfo
            // 
            this.rtbSelectedPlayerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSelectedPlayerInfo.Location = new System.Drawing.Point(12, 295);
            this.rtbSelectedPlayerInfo.Name = "rtbSelectedPlayerInfo";
            this.rtbSelectedPlayerInfo.ReadOnly = true;
            this.rtbSelectedPlayerInfo.Size = new System.Drawing.Size(211, 197);
            this.rtbSelectedPlayerInfo.TabIndex = 3;
            this.rtbSelectedPlayerInfo.Text = "";
            this.rtbSelectedPlayerInfo.Visible = false;
            // 
            // lbHighScores
            // 
            this.lbHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHighScores.FormattingEnabled = true;
            this.lbHighScores.ItemHeight = 16;
            this.lbHighScores.Location = new System.Drawing.Point(12, 12);
            this.lbHighScores.Name = "lbHighScores";
            this.lbHighScores.Size = new System.Drawing.Size(211, 212);
            this.lbHighScores.TabIndex = 4;
            this.lbHighScores.SelectedIndexChanged += new System.EventHandler(this.lbHighScores_SelectedIndexChanged);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHistory.Location = new System.Drawing.Point(131, 243);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(92, 30);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "История";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // btnCloseHistory
            // 
            this.btnCloseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseHistory.Location = new System.Drawing.Point(229, 423);
            this.btnCloseHistory.Name = "btnCloseHistory";
            this.btnCloseHistory.Size = new System.Drawing.Size(88, 69);
            this.btnCloseHistory.TabIndex = 6;
            this.btnCloseHistory.Text = "Затвори историята";
            this.btnCloseHistory.UseVisualStyleBackColor = true;
            this.btnCloseHistory.Click += new System.EventHandler(this.btnCloseHistory_Click);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::СделкаИлиНе.Properties.Resources.следващият_може_да_си_ти_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 570);
            this.Controls.Add(this.btnCloseHistory);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lbHighScores);
            this.Controls.Add(this.rtbSelectedPlayerInfo);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighScores";
            this.Text = "Топ печалби";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HighScores_FormClosing_1);
            this.Load += new System.EventHandler(this.HighScores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtbSelectedPlayerInfo;
        private System.Windows.Forms.ListBox lbHighScores;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnCloseHistory;
    }
}
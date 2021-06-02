
namespace СделкаИлиНе
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.btnClose = new System.Windows.Forms.Button();
            this.rtbAboutTheGame = new System.Windows.Forms.RichTextBox();
            this.rtbStudentInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(42, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Към менюто";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtbAboutTheGame
            // 
            this.rtbAboutTheGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbAboutTheGame.Location = new System.Drawing.Point(12, 12);
            this.rtbAboutTheGame.Name = "rtbAboutTheGame";
            this.rtbAboutTheGame.ReadOnly = true;
            this.rtbAboutTheGame.Size = new System.Drawing.Size(200, 149);
            this.rtbAboutTheGame.TabIndex = 1;
            this.rtbAboutTheGame.Text = "Участникът отваря кутии. На всеки 2 кутии получва оферта на банката - сума или см" +
    "яна на кутията. Играта приключва при приета оферта на банката или отваряне на вс" +
    "ички кутии.";
            // 
            // rtbStudentInfo
            // 
            this.rtbStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbStudentInfo.Location = new System.Drawing.Point(12, 178);
            this.rtbStudentInfo.Name = "rtbStudentInfo";
            this.rtbStudentInfo.ReadOnly = true;
            this.rtbStudentInfo.Size = new System.Drawing.Size(200, 126);
            this.rtbStudentInfo.TabIndex = 2;
            this.rtbStudentInfo.Text = "";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::СделкаИлиНе.Properties.Resources.за_играта;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 354);
            this.Controls.Add(this.rtbStudentInfo);
            this.Controls.Add(this.rtbAboutTheGame);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "За играта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.About_FormClosing);
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtbAboutTheGame;
        private System.Windows.Forms.RichTextBox rtbStudentInfo;
    }
}
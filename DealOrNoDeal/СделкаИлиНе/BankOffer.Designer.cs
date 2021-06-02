
namespace СделкаИлиНе
{
    partial class BankOffer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankOffer));
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnNoDeal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDeal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeal.Location = new System.Drawing.Point(20, 202);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(90, 52);
            this.btnDeal.TabIndex = 0;
            this.btnDeal.Text = "Има сделка";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnNoDeal
            // 
            this.btnNoDeal.BackColor = System.Drawing.Color.DarkRed;
            this.btnNoDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNoDeal.Location = new System.Drawing.Point(169, 202);
            this.btnNoDeal.Name = "btnNoDeal";
            this.btnNoDeal.Size = new System.Drawing.Size(90, 52);
            this.btnNoDeal.TabIndex = 1;
            this.btnNoDeal.Text = "Няма сделка";
            this.btnNoDeal.UseVisualStyleBackColor = false;
            this.btnNoDeal.Click += new System.EventHandler(this.btnNoDeal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оферта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сделка или не ?";
            // 
            // lblDeal
            // 
            this.lblDeal.AutoSize = true;
            this.lblDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeal.Location = new System.Drawing.Point(91, 29);
            this.lblDeal.Name = "lblDeal";
            this.lblDeal.Size = new System.Drawing.Size(46, 18);
            this.lblDeal.TabIndex = 4;
            this.lblDeal.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::СделкаИлиНе.Properties.Resources.сделка_или_не;
            this.pictureBox1.Location = new System.Drawing.Point(279, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BankOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 279);
            this.Controls.Add(this.lblDeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoDeal);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankOffer";
            this.Text = "Оферта на банката";
            this.Load += new System.EventHandler(this.BankOffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnNoDeal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDeal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
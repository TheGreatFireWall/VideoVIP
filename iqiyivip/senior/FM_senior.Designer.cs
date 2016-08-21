namespace iqiyivip
{
    partial class FM_senior
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
            this.btn_ad = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_supply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ad
            // 
            this.btn_ad.Location = new System.Drawing.Point(13, 13);
            this.btn_ad.Name = "btn_ad";
            this.btn_ad.Size = new System.Drawing.Size(75, 23);
            this.btn_ad.TabIndex = 0;
            this.btn_ad.Text = "去广告";
            this.btn_ad.UseVisualStyleBackColor = true;
            this.btn_ad.Click += new System.EventHandler(this.btn_ad_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(107, 13);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "更新";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_supply
            // 
            this.btn_supply.Location = new System.Drawing.Point(202, 13);
            this.btn_supply.Name = "btn_supply";
            this.btn_supply.Size = new System.Drawing.Size(75, 23);
            this.btn_supply.TabIndex = 2;
            this.btn_supply.Text = "赞助作者";
            this.btn_supply.UseVisualStyleBackColor = true;
            this.btn_supply.Click += new System.EventHandler(this.btn_supply_Click);
            // 
            // FM_senior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.btn_supply);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FM_senior";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高级";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ad;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_supply;
    }
}
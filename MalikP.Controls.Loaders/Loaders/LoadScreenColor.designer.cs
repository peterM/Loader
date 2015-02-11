namespace MalikP.Controls.Loaders
{
    partial class LoadScreenColor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._loaderContainer1 = new System.Windows.Forms.Panel();
            this._loaderPic = new System.Windows.Forms.PictureBox();
            this._loaderLbl = new System.Windows.Forms.Label();
            this._loaderContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._loaderPic)).BeginInit();
            this.SuspendLayout();
            // 
            // _loaderContainer1
            // 
            this._loaderContainer1.BackColor = System.Drawing.Color.White;
            this._loaderContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._loaderContainer1.Controls.Add(this._loaderLbl);
            this._loaderContainer1.Controls.Add(this._loaderPic);
            this._loaderContainer1.Location = new System.Drawing.Point(0, 0);
            this._loaderContainer1.Name = "_loaderContainer1";
            this._loaderContainer1.Size = new System.Drawing.Size(232, 130);
            this._loaderContainer1.TabIndex = 29;
            // 
            // _loaderPic
            // 
            this._loaderPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._loaderPic.Image = global::MalikP.Controls.Properties.Resources.loader0;
            this._loaderPic.Location = new System.Drawing.Point(87, 26);
            this._loaderPic.Name = "_loaderPic";
            this._loaderPic.Size = new System.Drawing.Size(56, 69);
            this._loaderPic.TabIndex = 23;
            this._loaderPic.TabStop = false;
            // 
            // _loaderLbl
            // 
            this._loaderLbl.AutoSize = true;
            this._loaderLbl.Location = new System.Drawing.Point(77, 105);
            this._loaderLbl.Name = "_loaderLbl";
            this._loaderLbl.Size = new System.Drawing.Size(55, 13);
            this._loaderLbl.TabIndex = 24;
            this._loaderLbl.Text = "                ";
            // 
            // LoadScreenColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._loaderContainer1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(232, 130);
            this.MinimumSize = new System.Drawing.Size(232, 130);
            this.Name = "LoadScreenColor";
            this.Size = new System.Drawing.Size(232, 130);
            this._loaderContainer1.ResumeLayout(false);
            this._loaderContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._loaderPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _loaderContainer1;
        private System.Windows.Forms.PictureBox _loaderPic;
        private System.Windows.Forms.Label _loaderLbl;

    }
}

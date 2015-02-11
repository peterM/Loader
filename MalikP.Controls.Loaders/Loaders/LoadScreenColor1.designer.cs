namespace MalikP.Controls.Loaders
{
    partial class LoadScreenColor1
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
            this._loaderContainer1.Size = new System.Drawing.Size(400, 300);
            this._loaderContainer1.TabIndex = 29;
            // 
            // _loaderPic
            // 
            this._loaderPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._loaderPic.Image = global::MalikP.Controls.Properties.Resources.color1Loader;
            this._loaderPic.Location = new System.Drawing.Point(-1, -1);
            this._loaderPic.Name = "_loaderPic";
            this._loaderPic.Size = new System.Drawing.Size(400, 300);
            this._loaderPic.TabIndex = 23;
            this._loaderPic.TabStop = false;
            // 
            // _loaderLbl
            // 
            this._loaderLbl.AutoSize = true;
            this._loaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loaderLbl.Location = new System.Drawing.Point(142, 256);
            this._loaderLbl.Name = "_loaderLbl";
            this._loaderLbl.Size = new System.Drawing.Size(114, 20);
            this._loaderLbl.TabIndex = 25;
            this._loaderLbl.Text = "Loading data...";
            // 
            // LoadScreenColor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._loaderContainer1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "LoadScreenColor1";
            this.Size = new System.Drawing.Size(400, 300);
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

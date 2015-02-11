namespace MalikP.Controls.Loaders
{
    partial class LoadScreenDragon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadScreenDragon));
            this._loaderPb = new System.Windows.Forms.PictureBox();
            this._loaderLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._loaderPb)).BeginInit();
            this.SuspendLayout();
            // 
            // _loaderPb
            // 
            this._loaderPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._loaderPb.Image = ((System.Drawing.Image)(resources.GetObject("_loaderPb.Image")));
            this._loaderPb.Location = new System.Drawing.Point(0, 0);
            this._loaderPb.Name = "_loaderPb";
            this._loaderPb.Size = new System.Drawing.Size(202, 124);
            this._loaderPb.TabIndex = 23;
            this._loaderPb.TabStop = false;
            // 
            // _loaderLbl
            // 
            this._loaderLbl.AutoSize = true;
            this._loaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loaderLbl.Location = new System.Drawing.Point(41, 131);
            this._loaderLbl.Name = "_loaderLbl";
            this._loaderLbl.Size = new System.Drawing.Size(114, 20);
            this._loaderLbl.TabIndex = 25;
            this._loaderLbl.Text = "Loading data...";
            // 
            // LoadScreenDragon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._loaderLbl);
            this.Controls.Add(this._loaderPb);
            this.Name = "LoadScreenDragon";
            this.Size = new System.Drawing.Size(202, 158);
            ((System.ComponentModel.ISupportInitialize)(this._loaderPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _loaderPb;
        private System.Windows.Forms.Label _loaderLbl;
    }
}

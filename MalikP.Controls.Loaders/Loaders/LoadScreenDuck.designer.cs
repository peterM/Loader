namespace MalikP.Controls.Loaders
{
    partial class LoadScreenDuck
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
            this._loaderLbl = new System.Windows.Forms.Label();
            this._loaderPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._loaderPb)).BeginInit();
            this.SuspendLayout();
            // 
            // _loaderLbl
            // 
            this._loaderLbl.AutoSize = true;
            this._loaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loaderLbl.Location = new System.Drawing.Point(8, 90);
            this._loaderLbl.Name = "_loaderLbl";
            this._loaderLbl.Size = new System.Drawing.Size(114, 20);
            this._loaderLbl.TabIndex = 24;
            this._loaderLbl.Text = "Loading data...";
            // 
            // _loaderPb
            // 
            this._loaderPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._loaderPb.Image = global::MalikP.Controls.Properties.Resources.LoaderDuck;
            this._loaderPb.Location = new System.Drawing.Point(0, 0);
            this._loaderPb.Name = "_loaderPb";
            this._loaderPb.Size = new System.Drawing.Size(128, 87);
            this._loaderPb.TabIndex = 25;
            this._loaderPb.TabStop = false;
            // 
            // LoadScreenDuck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._loaderPb);
            this.Controls.Add(this._loaderLbl);
            this.Name = "LoadScreenDuck";
            this.Size = new System.Drawing.Size(128, 114);
            ((System.ComponentModel.ISupportInitialize)(this._loaderPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _loaderLbl;
        private System.Windows.Forms.PictureBox _loaderPb;

    }
}

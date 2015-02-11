namespace MalikP.Controls.Loaders
{
    partial class LoadScreenCat
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
            this._loaderContainer = new System.Windows.Forms.Panel();
            this._loaderLbl = new System.Windows.Forms.Label();
            this._loaderPb = new System.Windows.Forms.PictureBox();
            this._loaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._loaderPb)).BeginInit();
            this.SuspendLayout();
            // 
            // _loaderContainer
            // 
            this._loaderContainer.BackColor = System.Drawing.Color.Transparent;
            this._loaderContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._loaderContainer.Controls.Add(this._loaderLbl);
            this._loaderContainer.Controls.Add(this._loaderPb);
            this._loaderContainer.Location = new System.Drawing.Point(0, 0);
            this._loaderContainer.Name = "_loaderContainer";
            this._loaderContainer.Size = new System.Drawing.Size(147, 137);
            this._loaderContainer.TabIndex = 28;
            // 
            // _loaderLbl
            // 
            this._loaderLbl.AutoSize = true;
            this._loaderLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this._loaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loaderLbl.Location = new System.Drawing.Point(15, 109);
            this._loaderLbl.Name = "_loaderLbl";
            this._loaderLbl.Size = new System.Drawing.Size(114, 20);
            this._loaderLbl.TabIndex = 24;
            this._loaderLbl.Text = "Loading data...";
            // 
            // _loaderPb
            // 
            this._loaderPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._loaderPb.Image = global::MalikP.Controls.Properties.Resources.catLoader;
            this._loaderPb.Location = new System.Drawing.Point(-1, -1);
            this._loaderPb.Name = "_loaderPb";
            this._loaderPb.Size = new System.Drawing.Size(147, 137);
            this._loaderPb.TabIndex = 23;
            this._loaderPb.TabStop = false;
            // 
            // LoadScreenCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._loaderContainer);
            this.MaximumSize = new System.Drawing.Size(147, 137);
            this.MinimumSize = new System.Drawing.Size(147, 137);
            this.Name = "LoadScreenCat";
            this.Size = new System.Drawing.Size(147, 137);
            this._loaderContainer.ResumeLayout(false);
            this._loaderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._loaderPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _loaderContainer;
        private System.Windows.Forms.PictureBox _loaderPb;
        private System.Windows.Forms.Label _loaderLbl;


    }
}

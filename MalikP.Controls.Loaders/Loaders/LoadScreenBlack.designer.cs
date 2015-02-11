namespace MalikP.Controls.Loaders
{
    partial class LoadScreenBlack
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
            this._loaderPb = new System.Windows.Forms.PictureBox();
            this._loaderLbl = new System.Windows.Forms.Label();
            this._loaderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._loaderPb)).BeginInit();
            this.SuspendLayout();
            // 
            // _loaderContainer
            // 
            this._loaderContainer.BackColor = System.Drawing.Color.Transparent;
            this._loaderContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._loaderContainer.Controls.Add(this._loaderPb);
            this._loaderContainer.Controls.Add(this._loaderLbl);
            this._loaderContainer.Location = new System.Drawing.Point(0, 0);
            this._loaderContainer.Name = "_loaderContainer";
            this._loaderContainer.Size = new System.Drawing.Size(232, 130);
            this._loaderContainer.TabIndex = 28;
            // 
            // _loaderPb
            // 
            this._loaderPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._loaderPb.Image = global::MalikP.Controls.Properties.Resources.loader1;
            this._loaderPb.Location = new System.Drawing.Point(94, 39);
            this._loaderPb.Name = "_loaderPb";
            this._loaderPb.Size = new System.Drawing.Size(42, 42);
            this._loaderPb.TabIndex = 23;
            this._loaderPb.TabStop = false;
            // 
            // _loaderLbl
            // 
            this._loaderLbl.AutoSize = true;
            this._loaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loaderLbl.Location = new System.Drawing.Point(59, 94);
            this._loaderLbl.Name = "_loaderLbl";
            this._loaderLbl.Size = new System.Drawing.Size(114, 20);
            this._loaderLbl.TabIndex = 24;
            this._loaderLbl.Text = "Loading data...";
            // 
            // LoadScreenBlack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._loaderContainer);
            this.MaximumSize = new System.Drawing.Size(232, 130);
            this.MinimumSize = new System.Drawing.Size(232, 130);
            this.Name = "LoadScreenBlack";
            this.Size = new System.Drawing.Size(232, 130);
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

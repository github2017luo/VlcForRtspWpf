namespace VlcForRtspWpf
{
    partial class VLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VLC));
            this.axVLCPlugin210 = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin210)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin210
            // 
            this.axVLCPlugin210.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axVLCPlugin210.Enabled = true;
            this.axVLCPlugin210.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin210.Name = "axVLCPlugin210";
            this.axVLCPlugin210.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin210.OcxState")));
            this.axVLCPlugin210.Size = new System.Drawing.Size(483, 396);
            this.axVLCPlugin210.TabIndex = 0;
            // 
            // VLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axVLCPlugin210);
            this.Name = "VLC";
            this.Size = new System.Drawing.Size(483, 396);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin210)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin210;
    }
}

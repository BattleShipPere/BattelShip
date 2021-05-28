
namespace BattelShip
{
    partial class EndGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.FinishVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.TiempoVideo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FinishVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // FinishVideo
            // 
            this.FinishVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinishVideo.Enabled = true;
            this.FinishVideo.Location = new System.Drawing.Point(0, 0);
            this.FinishVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FinishVideo.Name = "FinishVideo";
            this.FinishVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("FinishVideo.OcxState")));
            this.FinishVideo.Size = new System.Drawing.Size(1200, 675);
            this.FinishVideo.TabIndex = 0;
            // 
            // TiempoVideo
            // 
            this.TiempoVideo.Enabled = true;
            this.TiempoVideo.Interval = 500;
            this.TiempoVideo.Tick += new System.EventHandler(this.TiempoVideo_Tick);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.ControlBox = false;
            this.Controls.Add(this.FinishVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EndGame";
            ((System.ComponentModel.ISupportInitialize)(this.FinishVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer FinishVideo;
        private System.Windows.Forms.Timer TiempoVideo;
    }
}

namespace BattelShip
{
    partial class FormLoad1
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
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.pic_Box_Load = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Box_Load)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // pic_Box_Load
            // 
            this.pic_Box_Load.BackgroundImage = global::BattelShip.Properties.Resources.load1;
            this.pic_Box_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Box_Load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Box_Load.Image = global::BattelShip.Properties.Resources.load1;
            this.pic_Box_Load.Location = new System.Drawing.Point(0, 0);
            this.pic_Box_Load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_Box_Load.Name = "pic_Box_Load";
            this.pic_Box_Load.Size = new System.Drawing.Size(803, 646);
            this.pic_Box_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Box_Load.TabIndex = 0;
            this.pic_Box_Load.TabStop = false;
            // 
            // FormLoad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 646);
            this.ControlBox = false;
            this.Controls.Add(this.pic_Box_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormLoad1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoad1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pic_Box_Load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Box_Load;
        private System.Windows.Forms.Timer timerLoad;
    }
}
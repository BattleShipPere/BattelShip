﻿
namespace BattelShip
{
    partial class Form2_PantallaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_PantallaInicial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BattelShip.Properties.Resources.Img_Tituto;
            this.pictureBox1.Location = new System.Drawing.Point(294, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.Color.Transparent;
            this.Button_Start.BackgroundImage = global::BattelShip.Properties.Resources.Boton_Start;
            this.Button_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Start.FlatAppearance.BorderSize = 0;
            this.Button_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Start.Location = new System.Drawing.Point(531, 477);
            this.Button_Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(327, 165);
            this.Button_Start.TabIndex = 1;
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            this.Button_Start.MouseLeave += new System.EventHandler(this.Button_Start_MouseLeave);
            this.Button_Start.MouseHover += new System.EventHandler(this.Button_Start_MouseHover);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.BackgroundImage = global::BattelShip.Properties.Resources.Boton_Exit;
            this.Button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.FlatAppearance.BorderSize = 0;
            this.Button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Exit.Location = new System.Drawing.Point(531, 651);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(327, 165);
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            this.Button_Exit.MouseLeave += new System.EventHandler(this.Button_Exit_MouseLeave);
            this.Button_Exit.MouseHover += new System.EventHandler(this.Button_Exit_MouseHover);
            // 
            // Form2_PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BattelShip.Properties.Resources.Inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 837);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2_PantallaInicial";
            this.Text = "Welcome to the BattleShilp!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_Exit;
    }
}
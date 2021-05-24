
namespace BattelShip
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.table_tablero = new System.Windows.Forms.TableLayoutPanel();
            this.labPortaviones = new System.Windows.Forms.Label();
            this.labSubmarino = new System.Windows.Forms.Label();
            this.labDestructor = new System.Windows.Forms.Label();
            this.labPatrullero = new System.Windows.Forms.Label();
            this.butContinue = new System.Windows.Forms.Button();
            this.Button_Rotar = new System.Windows.Forms.Button();
            this.pic_Submarine = new System.Windows.Forms.PictureBox();
            this.pic_Patrol = new System.Windows.Forms.PictureBox();
            this.pic_Destroyer = new System.Windows.Forms.PictureBox();
            this.pic_Carrier = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Submarine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Patrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Destroyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carrier)).BeginInit();
            this.SuspendLayout();
            // 
            // table_tablero
            // 
            this.table_tablero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_tablero.BackColor = System.Drawing.Color.Beige;
            this.table_tablero.ColumnCount = 10;
            this.table_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.table_tablero.Location = new System.Drawing.Point(61, 146);
            this.table_tablero.Name = "table_tablero";
            this.table_tablero.RowCount = 10;
            this.table_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.table_tablero.Size = new System.Drawing.Size(473, 401);
            this.table_tablero.TabIndex = 0;
            // 
            // labPortaviones
            // 
            this.labPortaviones.AutoSize = true;
            this.labPortaviones.BackColor = System.Drawing.Color.Transparent;
            this.labPortaviones.Font = new System.Drawing.Font("Mistral", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPortaviones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPortaviones.Location = new System.Drawing.Point(723, 51);
            this.labPortaviones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPortaviones.Name = "labPortaviones";
            this.labPortaviones.Size = new System.Drawing.Size(38, 27);
            this.labPortaviones.TabIndex = 8;
            this.labPortaviones.Text = "x 1";
            // 
            // labSubmarino
            // 
            this.labSubmarino.AutoSize = true;
            this.labSubmarino.BackColor = System.Drawing.Color.Transparent;
            this.labSubmarino.Font = new System.Drawing.Font("Mistral", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSubmarino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labSubmarino.Location = new System.Drawing.Point(722, 139);
            this.labSubmarino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSubmarino.Name = "labSubmarino";
            this.labSubmarino.Size = new System.Drawing.Size(38, 27);
            this.labSubmarino.TabIndex = 9;
            this.labSubmarino.Text = "x 2";
            // 
            // labDestructor
            // 
            this.labDestructor.AutoSize = true;
            this.labDestructor.BackColor = System.Drawing.Color.Transparent;
            this.labDestructor.Font = new System.Drawing.Font("Mistral", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDestructor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labDestructor.Location = new System.Drawing.Point(723, 229);
            this.labDestructor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDestructor.Name = "labDestructor";
            this.labDestructor.Size = new System.Drawing.Size(38, 27);
            this.labDestructor.TabIndex = 10;
            this.labDestructor.Text = "x 3";
            // 
            // labPatrullero
            // 
            this.labPatrullero.AutoSize = true;
            this.labPatrullero.BackColor = System.Drawing.Color.Transparent;
            this.labPatrullero.Font = new System.Drawing.Font("Mistral", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatrullero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPatrullero.Location = new System.Drawing.Point(723, 320);
            this.labPatrullero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPatrullero.Name = "labPatrullero";
            this.labPatrullero.Size = new System.Drawing.Size(38, 27);
            this.labPatrullero.TabIndex = 11;
            this.labPatrullero.Text = "x 4";
            // 
            // butContinue
            // 
            this.butContinue.BackColor = System.Drawing.Color.Transparent;
            this.butContinue.BackgroundImage = global::BattelShip.Properties.Resources.Boton_Continue_Disabled;
            this.butContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butContinue.Enabled = false;
            this.butContinue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butContinue.FlatAppearance.BorderSize = 0;
            this.butContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butContinue.Location = new System.Drawing.Point(550, 465);
            this.butContinue.Name = "butContinue";
            this.butContinue.Size = new System.Drawing.Size(207, 82);
            this.butContinue.TabIndex = 12;
            this.butContinue.UseVisualStyleBackColor = false;
            this.butContinue.MouseLeave += new System.EventHandler(this.butContinue_MouseLeave);
            this.butContinue.MouseHover += new System.EventHandler(this.butContinue_MouseHover);
            // 
            // Button_Rotar
            // 
            this.Button_Rotar.BackColor = System.Drawing.Color.Transparent;
            this.Button_Rotar.BackgroundImage = global::BattelShip.Properties.Resources.Eje_X;
            this.Button_Rotar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Rotar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Rotar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Rotar.FlatAppearance.BorderSize = 0;
            this.Button_Rotar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Rotar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Rotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Rotar.Location = new System.Drawing.Point(145, 12);
            this.Button_Rotar.Name = "Button_Rotar";
            this.Button_Rotar.Size = new System.Drawing.Size(207, 94);
            this.Button_Rotar.TabIndex = 7;
            this.Button_Rotar.UseVisualStyleBackColor = false;
            this.Button_Rotar.Click += new System.EventHandler(this.Button_Rotar_Click);
            this.Button_Rotar.MouseLeave += new System.EventHandler(this.Button_Rotar_MouseLeave);
            this.Button_Rotar.MouseHover += new System.EventHandler(this.Button_Rotar_MouseHover);
            // 
            // pic_Submarine
            // 
            this.pic_Submarine.BackColor = System.Drawing.Color.Transparent;
            this.pic_Submarine.BackgroundImage = global::BattelShip.Properties.Resources.submarine;
            this.pic_Submarine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Submarine.Location = new System.Drawing.Point(550, 126);
            this.pic_Submarine.Name = "pic_Submarine";
            this.pic_Submarine.Size = new System.Drawing.Size(150, 50);
            this.pic_Submarine.TabIndex = 4;
            this.pic_Submarine.TabStop = false;
            this.pic_Submarine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Submarine_MouseDown);
            // 
            // pic_Patrol
            // 
            this.pic_Patrol.BackColor = System.Drawing.Color.Transparent;
            this.pic_Patrol.BackgroundImage = global::BattelShip.Properties.Resources.patrol;
            this.pic_Patrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Patrol.Location = new System.Drawing.Point(641, 311);
            this.pic_Patrol.Name = "pic_Patrol";
            this.pic_Patrol.Size = new System.Drawing.Size(59, 43);
            this.pic_Patrol.TabIndex = 3;
            this.pic_Patrol.TabStop = false;
            this.pic_Patrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Patrol_MouseDown);
            // 
            // pic_Destroyer
            // 
            this.pic_Destroyer.BackColor = System.Drawing.Color.Transparent;
            this.pic_Destroyer.BackgroundImage = global::BattelShip.Properties.Resources.destroyer;
            this.pic_Destroyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Destroyer.Location = new System.Drawing.Point(600, 215);
            this.pic_Destroyer.Name = "pic_Destroyer";
            this.pic_Destroyer.Size = new System.Drawing.Size(100, 50);
            this.pic_Destroyer.TabIndex = 2;
            this.pic_Destroyer.TabStop = false;
            this.pic_Destroyer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Destroyer_MouseDown);
            // 
            // pic_Carrier
            // 
            this.pic_Carrier.BackColor = System.Drawing.Color.Transparent;
            this.pic_Carrier.BackgroundImage = global::BattelShip.Properties.Resources.carrier;
            this.pic_Carrier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Carrier.Location = new System.Drawing.Point(500, 36);
            this.pic_Carrier.Name = "pic_Carrier";
            this.pic_Carrier.Size = new System.Drawing.Size(200, 50);
            this.pic_Carrier.TabIndex = 1;
            this.pic_Carrier.TabStop = false;
            this.pic_Carrier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Carrier_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattelShip.Properties.Resources.fondoMar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 570);
            this.Controls.Add(this.butContinue);
            this.Controls.Add(this.labPatrullero);
            this.Controls.Add(this.labDestructor);
            this.Controls.Add(this.labSubmarino);
            this.Controls.Add(this.labPortaviones);
            this.Controls.Add(this.Button_Rotar);
            this.Controls.Add(this.pic_Submarine);
            this.Controls.Add(this.pic_Patrol);
            this.Controls.Add(this.pic_Destroyer);
            this.Controls.Add(this.pic_Carrier);
            this.Controls.Add(this.table_tablero);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(796, 448);
            this.Name = "Form1";
            this.Text = "Coloca los barcos";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.pic_Submarine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Patrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Destroyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carrier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table_tablero;
        private System.Windows.Forms.PictureBox pic_Carrier;
        private System.Windows.Forms.PictureBox pic_Destroyer;
        private System.Windows.Forms.PictureBox pic_Patrol;
        private System.Windows.Forms.PictureBox pic_Submarine;
        private System.Windows.Forms.Button Button_Rotar;
        private System.Windows.Forms.Label labPortaviones;
        private System.Windows.Forms.Label labSubmarino;
        private System.Windows.Forms.Label labDestructor;
        private System.Windows.Forms.Label labPatrullero;
        private System.Windows.Forms.Button butContinue;
    }
}


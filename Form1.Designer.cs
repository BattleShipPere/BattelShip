
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
            this.pic_Submarine = new System.Windows.Forms.PictureBox();
            this.pic_Patrol = new System.Windows.Forms.PictureBox();
            this.pic_Destroyer = new System.Windows.Forms.PictureBox();
            this.pic_Carrier = new System.Windows.Forms.PictureBox();
            this.butSiguiente = new System.Windows.Forms.Button();
            this.butRotar = new System.Windows.Forms.Button();
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
            this.table_tablero.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
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
            this.table_tablero.Location = new System.Drawing.Point(35, 54);
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
            this.table_tablero.Size = new System.Drawing.Size(485, 440);
            this.table_tablero.TabIndex = 0;
            // 
            // pic_Submarine
            // 
            this.pic_Submarine.BackgroundImage = global::BattelShip.Properties.Resources.submarine;
            this.pic_Submarine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Submarine.Location = new System.Drawing.Point(622, 144);
            this.pic_Submarine.Name = "pic_Submarine";
            this.pic_Submarine.Size = new System.Drawing.Size(150, 50);
            this.pic_Submarine.TabIndex = 4;
            this.pic_Submarine.TabStop = false;
            this.pic_Submarine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Submarine_MouseDown);
            // 
            // pic_Patrol
            // 
            this.pic_Patrol.BackgroundImage = global::BattelShip.Properties.Resources.patrol;
            this.pic_Patrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Patrol.Location = new System.Drawing.Point(722, 263);
            this.pic_Patrol.Name = "pic_Patrol";
            this.pic_Patrol.Size = new System.Drawing.Size(50, 50);
            this.pic_Patrol.TabIndex = 3;
            this.pic_Patrol.TabStop = false;
            this.pic_Patrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Patrol_MouseDown);
            // 
            // pic_Destroyer
            // 
            this.pic_Destroyer.BackgroundImage = global::BattelShip.Properties.Resources.destroyer;
            this.pic_Destroyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Destroyer.Location = new System.Drawing.Point(672, 200);
            this.pic_Destroyer.Name = "pic_Destroyer";
            this.pic_Destroyer.Size = new System.Drawing.Size(100, 50);
            this.pic_Destroyer.TabIndex = 2;
            this.pic_Destroyer.TabStop = false;
            this.pic_Destroyer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Destroyer_MouseDown);
            // 
            // pic_Carrier
            // 
            this.pic_Carrier.BackgroundImage = global::BattelShip.Properties.Resources.carrier;
            this.pic_Carrier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Carrier.Location = new System.Drawing.Point(572, 88);
            this.pic_Carrier.Name = "pic_Carrier";
            this.pic_Carrier.Size = new System.Drawing.Size(200, 50);
            this.pic_Carrier.TabIndex = 1;
            this.pic_Carrier.TabStop = false;
            this.pic_Carrier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_Carrier_MouseDown);
            // 
            // butSiguiente
            // 
            this.butSiguiente.Enabled = false;
            this.butSiguiente.Location = new System.Drawing.Point(578, 367);
            this.butSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.butSiguiente.Name = "butSiguiente";
            this.butSiguiente.Size = new System.Drawing.Size(143, 51);
            this.butSiguiente.TabIndex = 5;
            this.butSiguiente.Text = "Continuar";
            this.butSiguiente.UseVisualStyleBackColor = true;
            this.butSiguiente.Click += new System.EventHandler(this.butSiguiente_Click);
            // 
            // butRotar
            // 
            this.butRotar.Location = new System.Drawing.Point(193, 12);
            this.butRotar.Name = "butRotar";
            this.butRotar.Size = new System.Drawing.Size(168, 35);
            this.butRotar.TabIndex = 6;
            this.butRotar.Text = "Eje X";
            this.butRotar.UseVisualStyleBackColor = true;
            this.butRotar.Click += new System.EventHandler(this.butRotar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 506);
            this.Controls.Add(this.butRotar);
            this.Controls.Add(this.butSiguiente);
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
            this.MinimumSize = new System.Drawing.Size(798, 454);
            this.Name = "Form1";
            this.Text = "Coloca los barcos";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.pic_Submarine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Patrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Destroyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carrier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table_tablero;
        private System.Windows.Forms.PictureBox pic_Carrier;
        private System.Windows.Forms.PictureBox pic_Destroyer;
        private System.Windows.Forms.PictureBox pic_Patrol;
        private System.Windows.Forms.PictureBox pic_Submarine;
        private System.Windows.Forms.Button butSiguiente;
        private System.Windows.Forms.Button butRotar;
    }
}


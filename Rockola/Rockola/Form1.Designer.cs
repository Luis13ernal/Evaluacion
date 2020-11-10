namespace Rockola
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reprodutor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.mtrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.mtrackStatus = new XComponent.SliderBar.MACTrackBar();
            this.lblCancion = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnAdjuntar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Reprodutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            this.SuspendLayout();
            // 
            // Reprodutor
            // 
            this.Reprodutor.Enabled = true;
            this.Reprodutor.Location = new System.Drawing.Point(12, 12);
            this.Reprodutor.Name = "Reprodutor";
            this.Reprodutor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reprodutor.OcxState")));
            this.Reprodutor.Size = new System.Drawing.Size(219, 158);
            this.Reprodutor.TabIndex = 0;
            this.Reprodutor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reprodutor_PlayStateChange);
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.Location = new System.Drawing.Point(12, 209);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(183, 225);
            this.lstCanciones.TabIndex = 1;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // mtrackVolumen
            // 
            this.mtrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mtrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackVolumen.IndentHeight = 6;
            this.mtrackVolumen.Location = new System.Drawing.Point(270, 243);
            this.mtrackVolumen.Maximum = 100;
            this.mtrackVolumen.Minimum = 0;
            this.mtrackVolumen.Name = "mtrackVolumen";
            this.mtrackVolumen.Size = new System.Drawing.Size(74, 22);
            this.mtrackVolumen.TabIndex = 7;
            this.mtrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TickColor = System.Drawing.Color.Red;
            this.mtrackVolumen.TickHeight = 4;
            this.mtrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TrackerColor = System.Drawing.Color.Red;
            this.mtrackVolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtrackVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtrackVolumen.TrackLineHeight = 3;
            this.mtrackVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackVolumen.Value = 0;
            // 
            // mtrackStatus
            // 
            this.mtrackStatus.BackColor = System.Drawing.Color.Transparent;
            this.mtrackStatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackStatus.IndentHeight = 6;
            this.mtrackStatus.Location = new System.Drawing.Point(237, 412);
            this.mtrackStatus.Maximum = 10;
            this.mtrackStatus.Minimum = 0;
            this.mtrackStatus.Name = "mtrackStatus";
            this.mtrackStatus.Size = new System.Drawing.Size(294, 22);
            this.mtrackStatus.TabIndex = 8;
            this.mtrackStatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackStatus.TickColor = System.Drawing.Color.Red;
            this.mtrackStatus.TickHeight = 4;
            this.mtrackStatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackStatus.TrackerColor = System.Drawing.Color.Red;
            this.mtrackStatus.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtrackStatus.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtrackStatus.TrackLineHeight = 3;
            this.mtrackStatus.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackStatus.Value = 0;
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Location = new System.Drawing.Point(212, 376);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(10, 13);
            this.lblCancion.TabIndex = 9;
            this.lblCancion.Text = "-";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.BackgroundImage = global::Rockola.Properties.Resources.speaker;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(237, 235);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 30);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Rockola.Properties.Resources.rockola;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(350, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(210, 225);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Rockola.Properties.Resources.play3;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(323, 282);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(121, 78);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::Rockola.Properties.Resources.stop2;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Image = global::Rockola.Properties.Resources.pause2;
            this.btnStop.Location = new System.Drawing.Point(237, 282);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 78);
            this.btnStop.TabIndex = 3;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BackColor = System.Drawing.Color.Black;
            this.btnAdjuntar.BackgroundImage = global::Rockola.Properties.Resources.plus2;
            this.btnAdjuntar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdjuntar.Location = new System.Drawing.Point(450, 282);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(81, 78);
            this.btnAdjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdjuntar.TabIndex = 2;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(592, 448);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.mtrackStatus);
            this.Controls.Add(this.mtrackVolumen);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.Reprodutor);
            this.Name = "Form1";
            this.Text = "Rockola";
            ((System.ComponentModel.ISupportInitialize)(this.Reprodutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reprodutor;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.PictureBox btnAdjuntar;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private XComponent.SliderBar.MACTrackBar mtrackVolumen;
        private XComponent.SliderBar.MACTrackBar mtrackStatus;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Timer timer1;
    }
}


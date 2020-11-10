using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rockola
{
    public partial class Form1 : Form
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaArchivos = new OpenFileDialog();
            CajaDeBusquedaArchivos.Multiselect = true;
            if (CajaDeBusquedaArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = CajaDeBusquedaArchivos.FileNames;
                rutasArchivosMP3 = CajaDeBusquedaArchivos.FileNames;

                foreach(var ArchivoMP3 in ArchivosMP3)
                {
                    lstCanciones.Items.Add(ArchivoMP3);
                }
                Reprodutor.URL = rutasArchivosMP3[0];
                lstCanciones.SelectedIndex = 0;
                btnPlay.Image = Properties.Resources.pause4;
                btnPlay.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reprodutor.URL = rutasArchivosMP3[lstCanciones.SelectedIndex];
            lblCancion.Text = ArchivosMP3[lstCanciones.SelectedIndex];
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
                case true:
                    Reprodutor.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.play3;
                    btnPlay.SizeMode = PictureBoxSizeMode.StretchImage;
                    Play = false;
                    break;
                case false:
                    Reprodutor.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.pause4;
                    btnPlay.SizeMode = PictureBoxSizeMode.StretchImage;
                    Play = true;
                    break;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Reprodutor.Ctlcontrols.stop();
            btnPlay.Image = Properties.Resources.play3;
            btnPlay.SizeMode = PictureBoxSizeMode.StretchImage;
            Play = false;
        }
        public void ActualizarDatosTrack()
        {
            if(Reprodutor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            { //control del tiempo maximo del mp3
                mtrackStatus.Maximum = (int)Reprodutor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if(Reprodutor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if(Reprodutor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                mtrackStatus.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            mtrackStatus.Value = (int)Reprodutor.Ctlcontrols.currentPosition;
            mtrackVolumen.Value = Reprodutor.settings.volume;

        }

        private void Reprodutor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }
    }
}

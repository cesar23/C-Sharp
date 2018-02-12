using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading;
using System.Windows.Forms;



namespace Notificacion_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnClientSizeChanged(EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) { changedSize(e); }
           // base.OnClientSizeChanged(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        protected void changedSize(EventArgs e)
        {
            //MessageBox.Show("Minimizado");
            notificacion.ShowBalloonTip(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //notificacion.Visible = true;
            Console.WriteLine(notificacion.Visible);

            notificacion.ShowBalloonTip(0);
            WindowState = FormWindowState.Minimized;
            notificacion.Visible = true;
             this.Hide();
            /*
            int i=1;
            while (true)
            {
                Thread.Sleep(9000);
                if (i==4)
                {
                    break;
                }
                i++;
                Console.WriteLine(i);
                //notificacion.ShowBalloonTip(0);
            }
            */

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
           // this.notificacion.Visible = !this.Visible;


            WindowState = FormWindowState.Normal;
           
           
           // this.Visible = !this.Visible;  
           // this.notificacion.Visible = !this.Visible;
        }

        private void minimixarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void notificacion_BalloonTipClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void notificacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OLAAA");
        }


    }
}

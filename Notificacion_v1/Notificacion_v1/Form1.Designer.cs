namespace Notificacion_v1
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
            this.button1 = new System.Windows.Forms.Button();
            this.notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimixarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_alert = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 111);
            this.button1.TabIndex = 0;
            this.button1.Text = "MINIMIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notificacion
            // 
            this.notificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificacion.BalloonTipText = "Informacion has un click para volverlo  a maximizar";
            this.notificacion.BalloonTipTitle = "Notificacion demo";
            this.notificacion.ContextMenuStrip = this.menuStrip;
            this.notificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("notificacion.Icon")));
            this.notificacion.Text = "solucionesystem.com";
            this.notificacion.Visible = true;
            this.notificacion.BalloonTipClicked += new System.EventHandler(this.notificacion_BalloonTipClicked);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.minimixarToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // minimixarToolStripMenuItem
            // 
            this.minimixarToolStripMenuItem.Name = "minimixarToolStripMenuItem";
            this.minimixarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minimixarToolStripMenuItem.Text = "Maximizar";
            this.minimixarToolStripMenuItem.Click += new System.EventHandler(this.minimixarToolStripMenuItem_Click);
            // 
            // timer_alert
            // 
            this.timer_alert.Enabled = true;
            this.timer_alert.Interval = 3000;
            this.timer_alert.Tick += new System.EventHandler(this.timer_alert_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 176);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notificacion;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimixarToolStripMenuItem;
        private System.Windows.Forms.Timer timer_alert;
    }
}


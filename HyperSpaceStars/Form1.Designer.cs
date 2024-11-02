namespace HyperSpaceStars
{
    partial class Form1
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.skglCanvas = new SkiaSharp.Views.Desktop.SKGLControl();
            this.timerCanvas = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // skglCanvas
            // 
            this.skglCanvas.BackColor = System.Drawing.Color.Black;
            this.skglCanvas.Location = new System.Drawing.Point(0, -1);
            this.skglCanvas.Name = "skglCanvas";
            this.skglCanvas.Size = new System.Drawing.Size(917, 603);
            this.skglCanvas.TabIndex = 0;
            this.skglCanvas.VSync = false;
            this.skglCanvas.PaintSurface += new System.EventHandler<SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs>(this.skglCanvas_PaintSurface);
            // 
            // timerCanvas
            // 
            this.timerCanvas.Interval = 20;
            this.timerCanvas.Tick += new System.EventHandler(this.timerCanvas_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 600);
            this.Controls.Add(this.skglCanvas);
            this.Name = "Form1";
            this.Text = "Hyperspace Stars Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private SkiaSharp.Views.Desktop.SKGLControl skglCanvas;
        private System.Windows.Forms.Timer timerCanvas;
    }
}


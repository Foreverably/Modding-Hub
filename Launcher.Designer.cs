
namespace ModdingHub
{
    partial class Launcher
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
            this.siticoneToolTip1 = new Siticone.UI.WinForms.SiticoneToolTip();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.siticoneTileButton1 = new Siticone.UI.WinForms.SiticoneTileButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneToolTip1
            // 
            this.siticoneToolTip1.AllowLinksHandling = true;
            this.siticoneToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(755, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 43);
            this.siticoneControlBox1.TabIndex = 0;
            this.siticoneToolTip1.SetToolTip(this.siticoneControlBox1, "Close");
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.siticoneControlBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 43);
            this.panel2.TabIndex = 3;
            // 
            // siticoneTileButton1
            // 
            this.siticoneTileButton1.BorderRadius = 6;
            this.siticoneTileButton1.CheckedState.Parent = this.siticoneTileButton1;
            this.siticoneTileButton1.CustomImages.Parent = this.siticoneTileButton1;
            this.siticoneTileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.siticoneTileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTileButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneTileButton1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTileButton1.HoveredState.Parent = this.siticoneTileButton1;
            this.siticoneTileButton1.Image = global::ModdingHub.Properties.Resources.icons8_audio_channels_32;
            this.siticoneTileButton1.Location = new System.Drawing.Point(47, 117);
            this.siticoneTileButton1.Name = "siticoneTileButton1";
            this.siticoneTileButton1.ShadowDecoration.Parent = this.siticoneTileButton1;
            this.siticoneTileButton1.Size = new System.Drawing.Size(195, 224);
            this.siticoneTileButton1.TabIndex = 4;
            this.siticoneTileButton1.Text = "SoundBoard";
            this.siticoneTileButton1.Click += new System.EventHandler(this.siticoneTileButton1_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siticoneTileButton1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launcher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneToolTip siticoneToolTip1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.Panel panel2;
        private Siticone.UI.WinForms.SiticoneTileButton siticoneTileButton1;
    }
}
namespace Spotify_Small
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lb_CurrentSongHolder = new System.Windows.Forms.Label();
            this.lb_CurrentSong = new System.Windows.Forms.Label();
            this.pb_Next = new System.Windows.Forms.PictureBox();
            this.pb_Pause = new System.Windows.Forms.PictureBox();
            this.pb_Prev = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Prev)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CurrentSongHolder
            // 
            this.lb_CurrentSongHolder.AutoSize = true;
            this.lb_CurrentSongHolder.BackColor = System.Drawing.Color.Transparent;
            this.lb_CurrentSongHolder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurrentSongHolder.ForeColor = System.Drawing.Color.White;
            this.lb_CurrentSongHolder.Location = new System.Drawing.Point(158, 9);
            this.lb_CurrentSongHolder.Name = "lb_CurrentSongHolder";
            this.lb_CurrentSongHolder.Size = new System.Drawing.Size(148, 25);
            this.lb_CurrentSongHolder.TabIndex = 0;
            this.lb_CurrentSongHolder.Text = "Current song:";
            // 
            // lb_CurrentSong
            // 
            this.lb_CurrentSong.BackColor = System.Drawing.Color.Transparent;
            this.lb_CurrentSong.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurrentSong.ForeColor = System.Drawing.Color.White;
            this.lb_CurrentSong.Location = new System.Drawing.Point(12, 34);
            this.lb_CurrentSong.Name = "lb_CurrentSong";
            this.lb_CurrentSong.Size = new System.Drawing.Size(441, 25);
            this.lb_CurrentSong.TabIndex = 1;
            this.lb_CurrentSong.Text = "No song";
            this.lb_CurrentSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Next
            // 
            this.pb_Next.BackColor = System.Drawing.Color.Transparent;
            this.pb_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Next.BackgroundImage")));
            this.pb_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Next.Location = new System.Drawing.Point(263, 62);
            this.pb_Next.Name = "pb_Next";
            this.pb_Next.Size = new System.Drawing.Size(50, 50);
            this.pb_Next.TabIndex = 2;
            this.pb_Next.TabStop = false;
            this.pb_Next.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NextSong);
            // 
            // pb_Pause
            // 
            this.pb_Pause.BackColor = System.Drawing.Color.Transparent;
            this.pb_Pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Pause.BackgroundImage")));
            this.pb_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Pause.Location = new System.Drawing.Point(207, 63);
            this.pb_Pause.Name = "pb_Pause";
            this.pb_Pause.Size = new System.Drawing.Size(50, 50);
            this.pb_Pause.TabIndex = 3;
            this.pb_Pause.TabStop = false;
            this.pb_Pause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PauseSong);
            // 
            // pb_Prev
            // 
            this.pb_Prev.BackColor = System.Drawing.Color.Transparent;
            this.pb_Prev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Prev.BackgroundImage")));
            this.pb_Prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Prev.Location = new System.Drawing.Point(151, 62);
            this.pb_Prev.Name = "pb_Prev";
            this.pb_Prev.Size = new System.Drawing.Size(50, 50);
            this.pb_Prev.TabIndex = 4;
            this.pb_Prev.TabStop = false;
            this.pb_Prev.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrevSong);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(465, 125);
            this.Controls.Add(this.pb_Prev);
            this.Controls.Add(this.pb_Pause);
            this.Controls.Add(this.pb_Next);
            this.Controls.Add(this.lb_CurrentSong);
            this.Controls.Add(this.lb_CurrentSongHolder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Spotify song";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Prev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CurrentSongHolder;
        private System.Windows.Forms.Label lb_CurrentSong;
        private System.Windows.Forms.PictureBox pb_Next;
        private System.Windows.Forms.PictureBox pb_Pause;
        private System.Windows.Forms.PictureBox pb_Prev;
    }
}
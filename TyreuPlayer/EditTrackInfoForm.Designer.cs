namespace TyreuPlayer
{
    partial class EditTrackInfoForm
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
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.ArtistTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.AlbumTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.TitleTextBox = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F);
            this.radButton1.Location = new System.Drawing.Point(331, 98);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(134, 24);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Сохранить";
            this.radButton1.Click += new System.EventHandler(this.Close);
            // 
            // radTextBox1
            // 
            this.ArtistTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtistTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ArtistTextBox.Location = new System.Drawing.Point(12, 12);
            this.ArtistTextBox.Name = "radTextBox1";
            this.ArtistTextBox.NullText = "Исполнитель";
            this.ArtistTextBox.Size = new System.Drawing.Size(453, 25);
            this.ArtistTextBox.TabIndex = 1;
            this.ArtistTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radTextBox2
            // 
            this.AlbumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AlbumTextBox.Location = new System.Drawing.Point(12, 38);
            this.AlbumTextBox.Name = "radTextBox2";
            this.AlbumTextBox.NullText = "Альбом";
            this.AlbumTextBox.Size = new System.Drawing.Size(453, 25);
            this.AlbumTextBox.TabIndex = 2;
            this.AlbumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radTextBox3
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TitleTextBox.Location = new System.Drawing.Point(12, 64);
            this.TitleTextBox.Name = "radTextBox3";
            this.TitleTextBox.NullText = "Название";
            this.TitleTextBox.Size = new System.Drawing.Size(453, 25);
            this.TitleTextBox.TabIndex = 3;
            this.TitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditTrackInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 134);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.AlbumTextBox);
            this.Controls.Add(this.ArtistTextBox);
            this.Controls.Add(this.radButton1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTrackInfoForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTrackInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox ArtistTextBox;
        private Telerik.WinControls.UI.RadTextBox AlbumTextBox;
        private Telerik.WinControls.UI.RadTextBox TitleTextBox;
    }
}

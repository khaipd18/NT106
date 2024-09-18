namespace PictureViewer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelThumbnails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.flowLayoutPanelThumbnails = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();

            // pictureBoxMain
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;

            // btnOpenFolder
            this.btnOpenFolder.Location = new System.Drawing.Point(12, 420);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(100, 23);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);

            // flowLayoutPanelThumbnails
            this.flowLayoutPanelThumbnails.Location = new System.Drawing.Point(420, 12);
            this.flowLayoutPanelThumbnails.Name = "flowLayoutPanelThumbnails";
            this.flowLayoutPanelThumbnails.Size = new System.Drawing.Size(200, 400);
            this.flowLayoutPanelThumbnails.TabIndex = 2;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.flowLayoutPanelThumbnails);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.pictureBoxMain);
            this.KeyPreview = true; // Đảm bảo bắt sự kiện KeyDown
            this.Name = "Form1";
            this.Text = "Picture Viewer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

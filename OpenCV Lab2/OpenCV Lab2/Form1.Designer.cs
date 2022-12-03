using System.Windows.Forms;

namespace OpenCV_Lab2
{
    partial class LWForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoImageFile = new System.Windows.Forms.RadioButton();
            this.rdoWebcam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImageScene = new System.Windows.Forms.TextBox();
            this.btnImageScene = new System.Windows.Forms.Button();
            this.btnImageToFind = new System.Windows.Forms.Button();
            this.txtImageToFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.ofdImageScene = new System.Windows.Forms.OpenFileDialog();
            this.ofdImageToFind = new System.Windows.Forms.OpenFileDialog();
            this.ImageBoxResult = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(448, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Источник изображения";
            // 
            // rdoImageFile
            // 
            this.rdoImageFile.AutoSize = true;
            this.rdoImageFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoImageFile.Location = new System.Drawing.Point(448, 435);
            this.rdoImageFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoImageFile.Name = "rdoImageFile";
            this.rdoImageFile.Size = new System.Drawing.Size(156, 19);
            this.rdoImageFile.TabIndex = 1;
            this.rdoImageFile.TabStop = true;
            this.rdoImageFile.Text = "Загрузить изображение";
            this.rdoImageFile.UseVisualStyleBackColor = true;
            this.rdoImageFile.CheckedChanged += new System.EventHandler(this.rdoImageFile_CheckedChanged);
            // 
            // rdoWebcam
            // 
            this.rdoWebcam.AutoSize = true;
            this.rdoWebcam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoWebcam.Location = new System.Drawing.Point(448, 457);
            this.rdoWebcam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoWebcam.Name = "rdoWebcam";
            this.rdoWebcam.Size = new System.Drawing.Size(147, 19);
            this.rdoWebcam.TabIndex = 2;
            this.rdoWebcam.TabStop = true;
            this.rdoWebcam.Text = "Включить веб-камеру";
            this.rdoWebcam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(749, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Изображение сцены";
            this.label2.Visible = false;
            // 
            // txtImageScene
            // 
            this.txtImageScene.Location = new System.Drawing.Point(754, 442);
            this.txtImageScene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageScene.Name = "txtImageScene";
            this.txtImageScene.PlaceholderText = "Адрес ";
            this.txtImageScene.ReadOnly = true;
            this.txtImageScene.Size = new System.Drawing.Size(110, 23);
            this.txtImageScene.TabIndex = 5;
            this.txtImageScene.Visible = false;
            // 
            // btnImageScene
            // 
            this.btnImageScene.Location = new System.Drawing.Point(869, 441);
            this.btnImageScene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImageScene.Name = "btnImageScene";
            this.btnImageScene.Size = new System.Drawing.Size(37, 22);
            this.btnImageScene.TabIndex = 6;
            this.btnImageScene.Text = "...";
            this.btnImageScene.UseVisualStyleBackColor = true;
            this.btnImageScene.Visible = false;
            this.btnImageScene.Click += new System.EventHandler(this.btnImageScene_Click);
            // 
            // btnImageToFind
            // 
            this.btnImageToFind.Location = new System.Drawing.Point(312, 440);
            this.btnImageToFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImageToFind.Name = "btnImageToFind";
            this.btnImageToFind.Size = new System.Drawing.Size(37, 22);
            this.btnImageToFind.TabIndex = 9;
            this.btnImageToFind.Text = "...";
            this.btnImageToFind.UseVisualStyleBackColor = true;
            this.btnImageToFind.Click += new System.EventHandler(this.btnImageToFind_Click);
            // 
            // txtImageToFind
            // 
            this.txtImageToFind.Location = new System.Drawing.Point(197, 442);
            this.txtImageToFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageToFind.Name = "txtImageToFind";
            this.txtImageToFind.PlaceholderText = "Адрес ";
            this.txtImageToFind.ReadOnly = true;
            this.txtImageToFind.Size = new System.Drawing.Size(110, 23);
            this.txtImageToFind.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(192, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Изображение объекта";
            // 
            // buttonVideo
            // 
            this.buttonVideo.Location = new System.Drawing.Point(872, 544);
            this.buttonVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(192, 45);
            this.buttonVideo.TabIndex = 12;
            this.buttonVideo.Text = "Поиск";
            this.buttonVideo.UseVisualStyleBackColor = true;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // ofdImageScene
            // 
            this.ofdImageScene.FileName = "openFileDialog1";
            // 
            // ofdImageToFind
            // 
            this.ofdImageToFind.FileName = "openFileDialog2";
            // 
            // ImageBoxResult
            // 
            this.ImageBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageBoxResult.Location = new System.Drawing.Point(197, 1);
            this.ImageBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageBoxResult.Name = "ImageBoxResult";
            this.ImageBoxResult.Size = new System.Drawing.Size(710, 393);
            this.ImageBoxResult.TabIndex = 2;
            this.ImageBoxResult.TabStop = false;
            // 
            // LWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 600);
            this.Controls.Add(this.ImageBoxResult);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.btnImageToFind);
            this.Controls.Add(this.txtImageToFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImageScene);
            this.Controls.Add(this.txtImageScene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdoWebcam);
            this.Controls.Add(this.rdoImageFile);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LWForm";
            this.Text = "Lab2";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton rdoImageFile;
        private RadioButton rdoWebcam;
        private Label label2;
        private TextBox txtImageScene;
        private Button btnImageScene;
        private Button btnImageToFind;
        private TextBox txtImageToFind;
        private Label label3;
        private Button buttonVideo;
        private OpenFileDialog ofdImageScene;
        private OpenFileDialog ofdImageToFind;
        private Emgu.CV.UI.ImageBox ImageBoxResult;
    }
}
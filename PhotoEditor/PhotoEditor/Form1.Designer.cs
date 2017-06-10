namespace PhotoEditor
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
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_brushSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_filter1 = new System.Windows.Forms.Button();
            this.btn_filter2 = new System.Windows.Forms.Button();
            this.btn_filter3 = new System.Windows.Forms.Button();
            this.bar_red = new System.Windows.Forms.TrackBar();
            this.bar_green = new System.Windows.Forms.TrackBar();
            this.bar_blue = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_blue)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(13, 13);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(103, 33);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(123, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(102, 33);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brush size:";
            // 
            // text_brushSize
            // 
            this.text_brushSize.Location = new System.Drawing.Point(12, 21);
            this.text_brushSize.Name = "text_brushSize";
            this.text_brushSize.Size = new System.Drawing.Size(100, 20);
            this.text_brushSize.TabIndex = 4;
            this.text_brushSize.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brush color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filters:";
            // 
            // btn_filter1
            // 
            this.btn_filter1.Location = new System.Drawing.Point(18, 333);
            this.btn_filter1.Name = "btn_filter1";
            this.btn_filter1.Size = new System.Drawing.Size(153, 36);
            this.btn_filter1.TabIndex = 7;
            this.btn_filter1.Text = "Oil Painting";
            this.btn_filter1.UseVisualStyleBackColor = true;
            this.btn_filter1.Click += new System.EventHandler(this.btn_filter1_Click);
            // 
            // btn_filter2
            // 
            this.btn_filter2.Location = new System.Drawing.Point(18, 375);
            this.btn_filter2.Name = "btn_filter2";
            this.btn_filter2.Size = new System.Drawing.Size(153, 36);
            this.btn_filter2.TabIndex = 8;
            this.btn_filter2.Text = "Posterization";
            this.btn_filter2.UseVisualStyleBackColor = true;
            this.btn_filter2.Click += new System.EventHandler(this.btn_filter2_Click);
            // 
            // btn_filter3
            // 
            this.btn_filter3.Location = new System.Drawing.Point(18, 417);
            this.btn_filter3.Name = "btn_filter3";
            this.btn_filter3.Size = new System.Drawing.Size(153, 36);
            this.btn_filter3.TabIndex = 9;
            this.btn_filter3.Text = "Water wave";
            this.btn_filter3.UseVisualStyleBackColor = true;
            this.btn_filter3.Click += new System.EventHandler(this.btn_filter3_Click);
            // 
            // bar_red
            // 
            this.bar_red.Location = new System.Drawing.Point(18, 91);
            this.bar_red.Maximum = 255;
            this.bar_red.Name = "bar_red";
            this.bar_red.Size = new System.Drawing.Size(153, 45);
            this.bar_red.TabIndex = 10;
            this.bar_red.Scroll += new System.EventHandler(this.bar_red_Scroll);
            // 
            // bar_green
            // 
            this.bar_green.Location = new System.Drawing.Point(18, 128);
            this.bar_green.Maximum = 255;
            this.bar_green.Name = "bar_green";
            this.bar_green.Size = new System.Drawing.Size(153, 45);
            this.bar_green.TabIndex = 11;
            this.bar_green.Scroll += new System.EventHandler(this.bar_green_Scroll);
            // 
            // bar_blue
            // 
            this.bar_blue.Location = new System.Drawing.Point(18, 166);
            this.bar_blue.Maximum = 255;
            this.bar_blue.Name = "bar_blue";
            this.bar_blue.Size = new System.Drawing.Size(153, 45);
            this.bar_blue.TabIndex = 12;
            this.bar_blue.Scroll += new System.EventHandler(this.bar_blue_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_filter1);
            this.panel1.Controls.Add(this.bar_blue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bar_green);
            this.panel1.Controls.Add(this.text_brushSize);
            this.panel1.Controls.Add(this.bar_red);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_filter3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_filter2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(526, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 525);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_blue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_brushSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_filter1;
        private System.Windows.Forms.Button btn_filter2;
        private System.Windows.Forms.Button btn_filter3;
        private System.Windows.Forms.TrackBar bar_red;
        private System.Windows.Forms.TrackBar bar_green;
        private System.Windows.Forms.TrackBar bar_blue;
        private System.Windows.Forms.Panel panel1;
    }
}


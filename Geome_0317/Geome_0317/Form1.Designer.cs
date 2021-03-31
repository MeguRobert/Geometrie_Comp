
namespace Geome_0317
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Jarvis = new System.Windows.Forms.Button();
            this.button_Graham = new System.Windows.Forms.Button();
            this.draw_polygon = new System.Windows.Forms.Button();
            this.btn_addPoint = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(979, 626);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Jarvis);
            this.panel1.Controls.Add(this.button_Graham);
            this.panel1.Controls.Add(this.draw_polygon);
            this.panel1.Controls.Add(this.btn_addPoint);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Location = new System.Drawing.Point(1008, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 626);
            this.panel1.TabIndex = 2;
            // 
            // button_Jarvis
            // 
            this.button_Jarvis.Location = new System.Drawing.Point(119, 148);
            this.button_Jarvis.Name = "button_Jarvis";
            this.button_Jarvis.Size = new System.Drawing.Size(97, 49);
            this.button_Jarvis.TabIndex = 8;
            this.button_Jarvis.Text = "Jarvis";
            this.button_Jarvis.UseVisualStyleBackColor = true;
            this.button_Jarvis.Click += new System.EventHandler(this.button_Jarvis_Click);
            // 
            // button_Graham
            // 
            this.button_Graham.Location = new System.Drawing.Point(3, 148);
            this.button_Graham.Name = "button_Graham";
            this.button_Graham.Size = new System.Drawing.Size(99, 49);
            this.button_Graham.TabIndex = 7;
            this.button_Graham.Text = "Graham";
            this.button_Graham.UseVisualStyleBackColor = true;
            this.button_Graham.Click += new System.EventHandler(this.button_Graham_Click);
            // 
            // draw_polygon
            // 
            this.draw_polygon.Location = new System.Drawing.Point(3, 474);
            this.draw_polygon.Name = "draw_polygon";
            this.draw_polygon.Size = new System.Drawing.Size(117, 55);
            this.draw_polygon.TabIndex = 6;
            this.draw_polygon.Text = "Draw Random Polygon";
            this.draw_polygon.UseVisualStyleBackColor = true;
            this.draw_polygon.Click += new System.EventHandler(this.draw_polygon_Click);
            // 
            // btn_addPoint
            // 
            this.btn_addPoint.Location = new System.Drawing.Point(119, 80);
            this.btn_addPoint.Name = "btn_addPoint";
            this.btn_addPoint.Size = new System.Drawing.Size(97, 36);
            this.btn_addPoint.TabIndex = 2;
            this.btn_addPoint.Text = "Add point(s)";
            this.btn_addPoint.UseVisualStyleBackColor = true;
            this.btn_addPoint.Click += new System.EventHandler(this.btn_addPoint_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 40);
            this.textBox1.TabIndex = 2;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(3, 80);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(99, 36);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addPoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button draw_polygon;
        private System.Windows.Forms.Button button_Graham;
        private System.Windows.Forms.Button button_Jarvis;
    }
}


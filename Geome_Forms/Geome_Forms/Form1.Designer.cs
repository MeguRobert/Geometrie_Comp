
namespace ClaseForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Draw = new System.Windows.Forms.Button();
            this.button_DrawPoligon = new System.Windows.Forms.Button();
            this.button_DrawMedians = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(26, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Input";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1031, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1028, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coordonatele\r\npunctelor:\r\n";
            // 
            // button_Draw
            // 
            this.button_Draw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Draw.Location = new System.Drawing.Point(1031, 152);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(114, 31);
            this.button_Draw.TabIndex = 8;
            this.button_Draw.Text = "Draw";
            this.button_Draw.UseVisualStyleBackColor = false;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // button_DrawPoligon
            // 
            this.button_DrawPoligon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_DrawPoligon.Location = new System.Drawing.Point(1031, 189);
            this.button_DrawPoligon.Name = "button_DrawPoligon";
            this.button_DrawPoligon.Size = new System.Drawing.Size(114, 46);
            this.button_DrawPoligon.TabIndex = 9;
            this.button_DrawPoligon.Text = "Draw Polygon";
            this.button_DrawPoligon.UseVisualStyleBackColor = false;
            this.button_DrawPoligon.Click += new System.EventHandler(this.button_DrawPoligon_Click);
            // 
            // button_DrawMedians
            // 
            this.button_DrawMedians.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_DrawMedians.Location = new System.Drawing.Point(1031, 241);
            this.button_DrawMedians.Name = "button_DrawMedians";
            this.button_DrawMedians.Size = new System.Drawing.Size(114, 46);
            this.button_DrawMedians.TabIndex = 10;
            this.button_DrawMedians.Text = "Draw Medians";
            this.button_DrawMedians.UseVisualStyleBackColor = false;
            this.button_DrawMedians.Click += new System.EventHandler(this.button_DrawMedians_Click);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_message.ForeColor = System.Drawing.Color.Red;
            this.label_message.Location = new System.Drawing.Point(1028, 24);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(169, 34);
            this.label_message.TabIndex = 11;
            this.label_message.Text = "Deja exista un punct\r\ncu aceste coordonate!";
            this.label_message.Visible = false;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Clear.Location = new System.Drawing.Point(1143, 445);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(81, 46);
            this.button_Clear.TabIndex = 12;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Back.Location = new System.Drawing.Point(1031, 445);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(88, 46);
            this.Button_Back.TabIndex = 13;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = false;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 529);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.button_DrawMedians);
            this.Controls.Add(this.button_DrawPoligon);
            this.Controls.Add(this.button_Draw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.Button button_DrawPoligon;
        private System.Windows.Forms.Button button_DrawMedians;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button Button_Back;
    }
}


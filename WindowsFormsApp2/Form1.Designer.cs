
namespace WindowsFormsApp2
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
            this.CenterLine = new System.Windows.Forms.PictureBox();
            this.Circle = new System.Windows.Forms.PictureBox();
            this.Rectangle_2 = new System.Windows.Forms.PictureBox();
            this.Rectangle_1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CenterLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle_1)).BeginInit();
            this.SuspendLayout();
            // 
            // CenterLine
            // 
            this.CenterLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CenterLine.Image = global::WindowsFormsApp2.Properties.Resources._106_1061890_vertical_line_08_08_statistical_graphics_removebg_preview;
            this.CenterLine.Location = new System.Drawing.Point(371, 0);
            this.CenterLine.Name = "CenterLine";
            this.CenterLine.Size = new System.Drawing.Size(56, 451);
            this.CenterLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CenterLine.TabIndex = 5;
            this.CenterLine.TabStop = false;
            // 
            // Circle
            // 
            this.Circle.Image = global::WindowsFormsApp2.Properties.Resources.Белый_квадрат;
            this.Circle.Location = new System.Drawing.Point(391, 210);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(17, 20);
            this.Circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Circle.TabIndex = 4;
            this.Circle.TabStop = false;
            // 
            // Rectangle_2
            // 
            this.Rectangle_2.Image = global::WindowsFormsApp2.Properties.Resources.Белый_квадрат;
            this.Rectangle_2.Location = new System.Drawing.Point(776, 183);
            this.Rectangle_2.Name = "Rectangle_2";
            this.Rectangle_2.Size = new System.Drawing.Size(12, 84);
            this.Rectangle_2.TabIndex = 3;
            this.Rectangle_2.TabStop = false;
            // 
            // Rectangle_1
            // 
            this.Rectangle_1.Image = global::WindowsFormsApp2.Properties.Resources.Белый_квадрат;
            this.Rectangle_1.Location = new System.Drawing.Point(12, 173);
            this.Rectangle_1.Name = "Rectangle_1";
            this.Rectangle_1.Size = new System.Drawing.Size(12, 84);
            this.Rectangle_1.TabIndex = 2;
            this.Rectangle_1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(159, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(616, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.CenterLine);
            this.Controls.Add(this.Rectangle_2);
            this.Controls.Add(this.Rectangle_1);
            this.Name = "Form1";
            this.Text = "pingpong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CenterLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Rectangle_1;
        private System.Windows.Forms.PictureBox Rectangle_2;
        private System.Windows.Forms.PictureBox Circle;
        private System.Windows.Forms.PictureBox CenterLine;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


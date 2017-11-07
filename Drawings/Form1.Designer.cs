namespace Drawings
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
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.buttonElement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSelectedColor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelDrawing
            // 
            this.panelDrawing.BackColor = System.Drawing.SystemColors.Window;
            this.panelDrawing.Location = new System.Drawing.Point(61, 12);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(313, 314);
            this.panelDrawing.TabIndex = 0;
            this.panelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawing_Paint);
            this.panelDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseDown);
            this.panelDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseMove);
            this.panelDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseUp);
            // 
            // buttonElement
            // 
            this.buttonElement.Location = new System.Drawing.Point(13, 13);
            this.buttonElement.Name = "buttonElement";
            this.buttonElement.Size = new System.Drawing.Size(42, 23);
            this.buttonElement.TabIndex = 1;
            this.buttonElement.Text = "Rect";
            this.buttonElement.UseVisualStyleBackColor = true;
            this.buttonElement.Click += new System.EventHandler(this.buttonElement_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Circ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonElement_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(61, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 16);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panelSelectColor);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(91, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 16);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panelSelectColor);
            // 
            // panelSelectedColor
            // 
            this.panelSelectedColor.BackColor = System.Drawing.SystemColors.Window;
            this.panelSelectedColor.Location = new System.Drawing.Point(13, 288);
            this.panelSelectedColor.Name = "panelSelectedColor";
            this.panelSelectedColor.Size = new System.Drawing.Size(42, 38);
            this.panelSelectedColor.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Location = new System.Drawing.Point(121, 332);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 16);
            this.panel3.TabIndex = 3;
            this.panel3.Click += new System.EventHandler(this.panelSelectColor);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(241, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 16);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.panelSelectColor);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Location = new System.Drawing.Point(151, 332);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 16);
            this.panel5.TabIndex = 3;
            this.panel5.Click += new System.EventHandler(this.panelSelectColor);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Aqua;
            this.panel6.Location = new System.Drawing.Point(181, 332);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(24, 16);
            this.panel6.TabIndex = 3;
            this.panel6.Click += new System.EventHandler(this.panelSelectColor);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Location = new System.Drawing.Point(211, 332);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(24, 16);
            this.panel7.TabIndex = 3;
            this.panel7.Click += new System.EventHandler(this.panelSelectColor);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Line";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonElement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSelectedColor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonElement);
            this.Controls.Add(this.panelDrawing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.Button buttonElement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSelectedColor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
    }
}


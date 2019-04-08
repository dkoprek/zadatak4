namespace WindowsFormsApp4
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
            this.startbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.lapbtn = new System.Windows.Forms.Button();
            this.vrijemelbl = new System.Windows.Forms.Label();
            this.laplbl = new System.Windows.Forms.Label();
            this.startlbl = new System.Windows.Forms.Label();
            this.stoplbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(210, 75);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(210, 138);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(75, 23);
            this.stopbtn.TabIndex = 1;
            this.stopbtn.Text = "STOP";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // lapbtn
            // 
            this.lapbtn.Location = new System.Drawing.Point(210, 199);
            this.lapbtn.Name = "lapbtn";
            this.lapbtn.Size = new System.Drawing.Size(75, 23);
            this.lapbtn.TabIndex = 2;
            this.lapbtn.Text = "LAP";
            this.lapbtn.UseVisualStyleBackColor = true;
            this.lapbtn.Click += new System.EventHandler(this.lapbtn_Click);
            // 
            // vrijemelbl
            // 
            this.vrijemelbl.AutoSize = true;
            this.vrijemelbl.Location = new System.Drawing.Point(474, 75);
            this.vrijemelbl.Name = "vrijemelbl";
            this.vrijemelbl.Size = new System.Drawing.Size(47, 13);
            this.vrijemelbl.TabIndex = 3;
            this.vrijemelbl.Text = "Vrijeme: ";
            // 
            // laplbl
            // 
            this.laplbl.AutoSize = true;
            this.laplbl.Location = new System.Drawing.Point(477, 138);
            this.laplbl.Name = "laplbl";
            this.laplbl.Size = new System.Drawing.Size(25, 13);
            this.laplbl.TabIndex = 4;
            this.laplbl.Text = "Lap";
            this.laplbl.Visible = false;
            // 
            // startlbl
            // 
            this.startlbl.AutoSize = true;
            this.startlbl.Location = new System.Drawing.Point(101, 270);
            this.startlbl.Name = "startlbl";
            this.startlbl.Size = new System.Drawing.Size(35, 13);
            this.startlbl.TabIndex = 5;
            this.startlbl.Text = "Start: ";
            this.startlbl.Visible = false;
            // 
            // stoplbl
            // 
            this.stoplbl.AutoSize = true;
            this.stoplbl.Location = new System.Drawing.Point(347, 270);
            this.stoplbl.Name = "stoplbl";
            this.stoplbl.Size = new System.Drawing.Size(35, 13);
            this.stoplbl.TabIndex = 6;
            this.stoplbl.Text = "Stop: ";
            this.stoplbl.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lap: ";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stoplbl);
            this.Controls.Add(this.startlbl);
            this.Controls.Add(this.laplbl);
            this.Controls.Add(this.vrijemelbl);
            this.Controls.Add(this.lapbtn);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Button lapbtn;
        private System.Windows.Forms.Label vrijemelbl;
        private System.Windows.Forms.Label laplbl;
        private System.Windows.Forms.Label startlbl;
        private System.Windows.Forms.Label stoplbl;
        private System.Windows.Forms.Label label3;
    }
}


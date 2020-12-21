namespace MineSweeper
{
    partial class MineSweeper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.Cells_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Hard);
            this.panel1.Controls.Add(this.Medium);
            this.panel1.Controls.Add(this.Easy);
            this.panel1.Location = new System.Drawing.Point(14, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 49);
            this.panel1.TabIndex = 1;
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Location = new System.Drawing.Point(195, 16);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(48, 17);
            this.Hard.TabIndex = 2;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(94, 16);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(62, 17);
            this.Medium.TabIndex = 1;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.BackColor = System.Drawing.SystemColors.Control;
            this.Easy.Checked = true;
            this.Easy.Location = new System.Drawing.Point(3, 16);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(48, 17);
            this.Easy.TabIndex = 0;
            this.Easy.TabStop = true;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = false;
            this.Easy.CheckedChanged += new System.EventHandler(this.Easy_CheckedChanged);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.Font = new System.Drawing.Font("Mongolian Baiti", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Start.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Start.Location = new System.Drawing.Point(313, 11);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(114, 47);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseMnemonic = false;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Cells_Panel
            // 
            this.Cells_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cells_Panel.Location = new System.Drawing.Point(12, 75);
            this.Cells_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Cells_Panel.Name = "Cells_Panel";
            this.Cells_Panel.Size = new System.Drawing.Size(415, 361);
            this.Cells_Panel.TabIndex = 2;
            // 
            // MineSweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 448);
            this.Controls.Add(this.Cells_Panel);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.panel1);
            this.Name = "MineSweeper";
            this.Text = "MineSweeper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.FlowLayoutPanel Cells_Panel;
    }
}


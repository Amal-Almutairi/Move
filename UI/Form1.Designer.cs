
namespace UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label.Image = ((System.Drawing.Image)(resources.GetObject("label.Image")));
            this.label.Location = new System.Drawing.Point(339, 141);
            this.label.MaximumSize = new System.Drawing.Size(200, 200);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 30);
            this.label.TabIndex = 0;
            this.label.Text = "Label";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.SystemColors.ControlText;
            this.Right.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Right.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Right.Location = new System.Drawing.Point(423, 299);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(112, 34);
            this.Right.TabIndex = 1;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = false;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.SystemColors.ControlText;
            this.Left.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Left.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Left.Location = new System.Drawing.Point(187, 299);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(112, 34);
            this.Left.TabIndex = 2;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.SystemColors.Desktop;
            this.Up.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Up.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Up.Location = new System.Drawing.Point(306, 255);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(112, 34);
            this.Up.TabIndex = 3;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = false;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.SystemColors.ControlText;
            this.down.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.down.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.down.Location = new System.Drawing.Point(306, 347);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(112, 34);
            this.down.TabIndex = 4;
            this.down.Text = "Down";
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button down;
    }
}


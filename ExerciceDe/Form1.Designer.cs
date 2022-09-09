namespace ExerciceDe
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
            this.btnBrasser = new System.Windows.Forms.Button();
            this.textBoxTotalDesPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrasser
            // 
            this.btnBrasser.Location = new System.Drawing.Point(186, 291);
            this.btnBrasser.Name = "btnBrasser";
            this.btnBrasser.Size = new System.Drawing.Size(75, 23);
            this.btnBrasser.TabIndex = 0;
            this.btnBrasser.Text = "Brasser";
            this.btnBrasser.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalDesPoints
            // 
            this.textBoxTotalDesPoints.Location = new System.Drawing.Point(16, 382);
            this.textBoxTotalDesPoints.Name = "textBoxTotalDesPoints";
            this.textBoxTotalDesPoints.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotalDesPoints.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "total des points";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotalDesPoints);
            this.Controls.Add(this.btnBrasser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBrasser;
        private TextBox textBoxTotalDesPoints;
        private Label label1;
    }
}
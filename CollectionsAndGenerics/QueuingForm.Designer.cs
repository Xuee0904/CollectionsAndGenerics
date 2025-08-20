namespace CollectionsAndGenerics
{
    partial class QueuingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.QueueNumberLabel = new System.Windows.Forms.Label();
            this.GetNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position in queue";
            // 
            // QueueNumberLabel
            // 
            this.QueueNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QueueNumberLabel.AutoSize = true;
            this.QueueNumberLabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueNumberLabel.Location = new System.Drawing.Point(25, 109);
            this.QueueNumberLabel.Name = "QueueNumberLabel";
            this.QueueNumberLabel.Size = new System.Drawing.Size(418, 31);
            this.QueueNumberLabel.TabIndex = 1;
            this.QueueNumberLabel.Text = "Your number will be displayed here";
            this.QueueNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetNumberButton
            // 
            this.GetNumberButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetNumberButton.Location = new System.Drawing.Point(308, 248);
            this.GetNumberButton.Name = "GetNumberButton";
            this.GetNumberButton.Size = new System.Drawing.Size(135, 74);
            this.GetNumberButton.TabIndex = 2;
            this.GetNumberButton.Text = "Get number";
            this.GetNumberButton.UseVisualStyleBackColor = true;
            this.GetNumberButton.Click += new System.EventHandler(this.GetNumberButton_Click);
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 370);
            this.Controls.Add(this.GetNumberButton);
            this.Controls.Add(this.QueueNumberLabel);
            this.Controls.Add(this.label1);
            this.Name = "QueuingForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QueuingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QueueNumberLabel;
        private System.Windows.Forms.Button GetNumberButton;
    }
}


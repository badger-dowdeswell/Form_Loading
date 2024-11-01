namespace Form_Loading {
    partial class FormTwo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
        components.Dispose();
        }
        base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonLoadFormThree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBack.Location = new System.Drawing.Point(16, 15);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(149, 66);
            this.buttonGoBack.TabIndex = 1;
            this.buttonGoBack.Text = "Go Back to Form Main";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonLoadFormThree
            // 
            this.buttonLoadFormThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadFormThree.Location = new System.Drawing.Point(211, 15);
            this.buttonLoadFormThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadFormThree.Name = "buttonLoadFormThree";
            this.buttonLoadFormThree.Size = new System.Drawing.Size(149, 66);
            this.buttonLoadFormThree.TabIndex = 1;
            this.buttonLoadFormThree.Text = "Load Form Three";
            this.buttonLoadFormThree.UseVisualStyleBackColor = true;
            this.buttonLoadFormThree.Click += new System.EventHandler(this.buttonLoadFormThree_Click);
            // 
            // FormTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLoadFormThree);
            this.Controls.Add(this.buttonGoBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This is Form Two";            
            this.Load += new System.EventHandler(this.FormTwo_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonLoadFormThree;
    }
}
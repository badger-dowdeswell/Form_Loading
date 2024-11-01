namespace Form_Loading {
    partial class FormMain {
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
            this.buttonLoadFormOne = new System.Windows.Forms.Button();
            this.buttoLoadFormTwo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoadFormOne
            // 
            this.buttonLoadFormOne.Location = new System.Drawing.Point(31, 133);
            this.buttonLoadFormOne.Name = "buttonLoadFormOne";
            this.buttonLoadFormOne.Size = new System.Drawing.Size(107, 57);
            this.buttonLoadFormOne.TabIndex = 0;
            this.buttonLoadFormOne.Text = "Load Form One";
            this.buttonLoadFormOne.UseVisualStyleBackColor = true;
            this.buttonLoadFormOne.Click += new System.EventHandler(this.buttonLoadFormOne_Click);
            // 
            // buttoLoadFormTwo
            // 
            this.buttoLoadFormTwo.Location = new System.Drawing.Point(31, 250);
            this.buttoLoadFormTwo.Name = "buttoLoadFormTwo";
            this.buttoLoadFormTwo.Size = new System.Drawing.Size(107, 57);
            this.buttoLoadFormTwo.TabIndex = 0;
            this.buttoLoadFormTwo.Text = "Load Form Two";
            this.buttoLoadFormTwo.UseVisualStyleBackColor = true;
            this.buttoLoadFormTwo.Click += new System.EventHandler(this.buttoLoadFormTwo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is the main startup form that connects all the other forms created by other " +
    "students together.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Form One loads over the top of Form Main without hiding it.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Notice how Form One loads in the center of Form Main.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(165, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Form Two hides Form Main when it loads.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(909, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoLoadFormTwo);
            this.Controls.Add(this.buttonLoadFormOne);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "This is Form Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFormOne;
        private System.Windows.Forms.Button buttoLoadFormTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


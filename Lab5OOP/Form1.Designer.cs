namespace Lab5OOP
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
            label1 = new Label();
            txtString2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtString3 = new TextBox();
            txtString1 = new TextBox();
            label4 = new Label();
            lblResult = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 51);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtString2
            // 
            txtString2.Location = new Point(350, 102);
            txtString2.Name = "txtString2";
            txtString2.Size = new Size(125, 27);
            txtString2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 109);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 163);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // txtString3
            // 
            txtString3.Location = new Point(350, 163);
            txtString3.Name = "txtString3";
            txtString3.Size = new Size(125, 27);
            txtString3.TabIndex = 4;
            // 
            // txtString1
            // 
            txtString1.Location = new Point(350, 51);
            txtString1.Name = "txtString1";
            txtString1.Size = new Size(125, 27);
            txtString1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 248);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(387, 248);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 7;
            lblResult.Text = "label5";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(330, 345);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(145, 40);
            btnOK.TabIndex = 8;
            btnOK.Text = "button1";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOK);
            Controls.Add(lblResult);
            Controls.Add(label4);
            Controls.Add(txtString1);
            Controls.Add(txtString3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtString2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtString2;
        private Label label2;
        private Label label3;
        private TextBox txtString3;
        private TextBox txtString1;
        private Label label4;
        private Label lblResult;
        private Button btnOK;
    }
}

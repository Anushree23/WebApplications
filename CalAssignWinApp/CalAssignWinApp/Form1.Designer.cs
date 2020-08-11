namespace CalAssignWinApp
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Label();
            this.Sub = new System.Windows.Forms.Label();
            this.Mul = new System.Windows.Forms.Label();
            this.Div = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(338, 87);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(35, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Num1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(338, 142);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(35, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Num2";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(361, 302);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "Sub";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(457, 302);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 4;
            this.btnMul.Text = "Mul";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(559, 302);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "Div";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(409, 142);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 20);
            this.textNum2.TabIndex = 10;
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(409, 87);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 20);
            this.textNum1.TabIndex = 11;
            this.textNum1.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.SystemColors.Control;
            this.Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add.Location = new System.Drawing.Point(285, 355);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(35, 13);
            this.Add.TabIndex = 12;
            this.Add.Text = "label1";
            this.Add.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(391, 355);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(35, 13);
            this.Sub.TabIndex = 13;
            this.Sub.Text = "label2";
            this.Sub.Click += new System.EventHandler(this.label2_Click);
            // 
            // Mul
            // 
            this.Mul.AutoSize = true;
            this.Mul.Location = new System.Drawing.Point(485, 355);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(35, 13);
            this.Mul.TabIndex = 14;
            this.Mul.Text = "label3";
            // 
            // Div
            // 
            this.Div.AutoSize = true;
            this.Div.Location = new System.Drawing.Point(599, 355);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(35, 13);
            this.Div.TabIndex = 15;
            this.Div.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.Label Sub;
        private System.Windows.Forms.Label Mul;
        private System.Windows.Forms.Label Div;
    }
}


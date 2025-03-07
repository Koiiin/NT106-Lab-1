namespace Lab1_bai4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.To_that = new System.Windows.Forms.ComboBox();
            this.From_this = new System.Windows.Forms.ComboBox();
            this.Enter_btn = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Result_box = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.To_that);
            this.groupBox1.Controls.Add(this.From_this);
            this.groupBox1.Controls.Add(this.Enter_btn);
            this.groupBox1.Controls.Add(this.Number);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // To_that
            // 
            this.To_that.FormattingEnabled = true;
            this.To_that.Items.AddRange(new object[] {
            "Hex",
            "Bin",
            "Dec"});
            this.To_that.Location = new System.Drawing.Point(469, 102);
            this.To_that.Name = "To_that";
            this.To_that.Size = new System.Drawing.Size(121, 39);
            this.To_that.TabIndex = 8;
            // 
            // From_this
            // 
            this.From_this.FormattingEnabled = true;
            this.From_this.Items.AddRange(new object[] {
            "Hex",
            "Bin",
            "Dec"});
            this.From_this.Location = new System.Drawing.Point(220, 102);
            this.From_this.Name = "From_this";
            this.From_this.Size = new System.Drawing.Size(121, 39);
            this.From_this.TabIndex = 7;
            // 
            // Enter_btn
            // 
            this.Enter_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Enter_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Enter_btn.Location = new System.Drawing.Point(313, 177);
            this.Enter_btn.Name = "Enter_btn";
            this.Enter_btn.Size = new System.Drawing.Size(191, 53);
            this.Enter_btn.TabIndex = 4;
            this.Enter_btn.Text = "Thực hiện";
            this.Enter_btn.UseVisualStyleBackColor = false;
            this.Enter_btn.Click += new System.EventHandler(this.Enter_btn_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(220, 53);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(370, 38);
            this.Number.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập 1 số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            // 
            // Result_box
            // 
            this.Result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_box.Location = new System.Drawing.Point(221, 299);
            this.Result_box.Name = "Result_box";
            this.Result_box.ReadOnly = true;
            this.Result_box.Size = new System.Drawing.Size(281, 38);
            this.Result_box.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Convert HEX, DEC, BIN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Enter_btn;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Result_box;
        private System.Windows.Forms.ComboBox To_that;
        private System.Windows.Forms.ComboBox From_this;
    }
}


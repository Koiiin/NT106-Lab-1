namespace Bai_2
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputNum3 = new System.Windows.Forms.TextBox();
            this.inputNum2 = new System.Windows.Forms.TextBox();
            this.inputNum1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.result_max = new System.Windows.Forms.TextBox();
            this.result_min = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1072, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÌM SỐ LỚN NHẤT VÀ NHỎ NHẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.inputNum3);
            this.groupBox1.Controls.Add(this.inputNum2);
            this.groupBox1.Controls.Add(this.inputNum1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(87, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1241, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các giá trị";
            // 
            // inputNum3
            // 
            this.inputNum3.Location = new System.Drawing.Point(999, 101);
            this.inputNum3.Name = "inputNum3";
            this.inputNum3.Size = new System.Drawing.Size(208, 44);
            this.inputNum3.TabIndex = 7;
            // 
            // inputNum2
            // 
            this.inputNum2.Location = new System.Drawing.Point(559, 98);
            this.inputNum2.Name = "inputNum2";
            this.inputNum2.Size = new System.Drawing.Size(208, 44);
            this.inputNum2.TabIndex = 7;
            // 
            // inputNum1
            // 
            this.inputNum1.Location = new System.Drawing.Point(155, 98);
            this.inputNum1.Name = "inputNum1";
            this.inputNum1.Size = new System.Drawing.Size(208, 44);
            this.inputNum1.TabIndex = 6;
            this.inputNum1.Text = "\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(848, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số thứ 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số thứ 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(300, 419);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(150, 52);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(646, 419);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(150, 52);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(942, 419);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(150, 52);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.result_max);
            this.groupBox2.Controls.Add(this.result_min);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label_min);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(87, 503);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1241, 161);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // result_max
            // 
            this.result_max.Location = new System.Drawing.Point(758, 97);
            this.result_max.Name = "result_max";
            this.result_max.Size = new System.Drawing.Size(247, 44);
            this.result_max.TabIndex = 7;
            // 
            // result_min
            // 
            this.result_min.Location = new System.Drawing.Point(194, 94);
            this.result_min.Name = "result_min";
            this.result_min.Size = new System.Drawing.Size(240, 44);
            this.result_min.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số lớn nhất";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(6, 101);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(182, 37);
            this.label_min.TabIndex = 0;
            this.label_min.Text = "Số bé nhất";
            this.label_min.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 782);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputNum1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNum3;
        private System.Windows.Forms.TextBox inputNum2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox result_max;
        private System.Windows.Forms.TextBox result_min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}


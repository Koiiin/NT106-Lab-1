namespace Lab1_bai5
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
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.average_out = new System.Windows.Forms.Label();
            this.max_out = new System.Windows.Forms.Label();
            this.min_out = new System.Windows.Forms.Label();
            this.pass_out = new System.Windows.Forms.Label();
            this.rank_out = new System.Windows.Forms.Label();
            this.not_pass_out = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(312, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(317, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "QUẢN LÝ ĐIỂM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dữ liệu điểm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(198, 82);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(707, 34);
            this.input.TabIndex = 2;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(815, 139);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(90, 42);
            this.result.TabIndex = 3;
            this.result.Text = "Xuất";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học và điểm";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(876, 134);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(14, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "* Lưu ý: Nhập với dạng danh sách. Vi dụ 7 6 5.5";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // average_out
            // 
            this.average_out.AutoSize = true;
            this.average_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average_out.Location = new System.Drawing.Point(18, 409);
            this.average_out.Name = "average_out";
            this.average_out.Size = new System.Drawing.Size(114, 29);
            this.average_out.TabIndex = 6;
            this.average_out.Text = "Điểm TB:";
            // 
            // max_out
            // 
            this.max_out.AutoSize = true;
            this.max_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_out.Location = new System.Drawing.Point(18, 468);
            this.max_out.Name = "max_out";
            this.max_out.Size = new System.Drawing.Size(172, 29);
            this.max_out.TabIndex = 7;
            this.max_out.Text = "Điểm cao nhất:";
            this.max_out.Click += new System.EventHandler(this.label4_Click);
            // 
            // min_out
            // 
            this.min_out.AutoSize = true;
            this.min_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_out.Location = new System.Drawing.Point(333, 468);
            this.min_out.Name = "min_out";
            this.min_out.Size = new System.Drawing.Size(179, 29);
            this.min_out.TabIndex = 8;
            this.min_out.Text = "Điểm thấp nhất:";
            // 
            // pass_out
            // 
            this.pass_out.AutoSize = true;
            this.pass_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_out.Location = new System.Drawing.Point(333, 409);
            this.pass_out.Name = "pass_out";
            this.pass_out.Size = new System.Drawing.Size(148, 29);
            this.pass_out.TabIndex = 9;
            this.pass_out.Text = "Số môn đậu:";
            // 
            // rank_out
            // 
            this.rank_out.AutoSize = true;
            this.rank_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rank_out.Location = new System.Drawing.Point(598, 468);
            this.rank_out.Name = "rank_out";
            this.rank_out.Size = new System.Drawing.Size(109, 29);
            this.rank_out.TabIndex = 10;
            this.rank_out.Text = "Xếp loại:";
            // 
            // not_pass_out
            // 
            this.not_pass_out.AutoSize = true;
            this.not_pass_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.not_pass_out.Location = new System.Drawing.Point(598, 409);
            this.not_pass_out.Name = "not_pass_out";
            this.not_pass_out.Size = new System.Drawing.Size(220, 29);
            this.not_pass_out.TabIndex = 11;
            this.not_pass_out.Text = "Số môn không đậu:";
            this.not_pass_out.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 531);
            this.Controls.Add(this.not_pass_out);
            this.Controls.Add(this.rank_out);
            this.Controls.Add(this.pass_out);
            this.Controls.Add(this.min_out);
            this.Controls.Add(this.max_out);
            this.Controls.Add(this.average_out);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label average_out;
        private System.Windows.Forms.Label max_out;
        private System.Windows.Forms.Label min_out;
        private System.Windows.Forms.Label pass_out;
        private System.Windows.Forms.Label rank_out;
        private System.Windows.Forms.Label not_pass_out;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListView listView1;
    }
}


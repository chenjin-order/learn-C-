namespace Calculators.WinForms
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DataX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Operator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DataY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "操作数X";
            // 
            // txt_DataX
            // 
            this.txt_DataX.Location = new System.Drawing.Point(124, 21);
            this.txt_DataX.Name = "txt_DataX";
            this.txt_DataX.Size = new System.Drawing.Size(293, 25);
            this.txt_DataX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "操作符(+,-.*,/)";
            // 
            // txt_Operator
            // 
            this.txt_Operator.Location = new System.Drawing.Point(156, 81);
            this.txt_Operator.Name = "txt_Operator";
            this.txt_Operator.Size = new System.Drawing.Size(261, 25);
            this.txt_Operator.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "操作数Y";
            // 
            // txt_DataY
            // 
            this.txt_DataY.Location = new System.Drawing.Point(124, 152);
            this.txt_DataY.Name = "txt_DataY";
            this.txt_DataY.Size = new System.Drawing.Size(293, 25);
            this.txt_DataY.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "计算结果";
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(124, 211);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(293, 25);
            this.txt_Result.TabIndex = 1;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(156, 278);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(121, 27);
            this.btn_Calculate.TabIndex = 2;
            this.btn_Calculate.Text = "计算";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 369);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DataY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Operator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DataX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FirstCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DataX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Operator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DataY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_Calculate;
    }
}


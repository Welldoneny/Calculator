namespace Калькулятор
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_zero = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_AllClear = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_leftbkt = new System.Windows.Forms.Button();
            this.button_rightbkt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(254, 49);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // button_zero
            // 
            this.button_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_zero.Location = new System.Drawing.Point(12, 299);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(45, 25);
            this.button_zero.TabIndex = 1;
            this.button_zero.Text = "0";
            this.button_zero.UseVisualStyleBackColor = true;
            this.button_zero.Click += new System.EventHandler(this.Button_zero_Click);
            // 
            // button_dot
            // 
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_dot.Location = new System.Drawing.Point(78, 299);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(45, 25);
            this.button_dot.TabIndex = 2;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            // 
            // button_result
            // 
            this.button_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_result.Location = new System.Drawing.Point(147, 299);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(45, 25);
            this.button_result.TabIndex = 3;
            this.button_result.Text = "=";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.Button_result_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(221, 299);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(45, 25);
            this.button_plus.TabIndex = 4;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.Button_plus_Click);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_1.Location = new System.Drawing.Point(12, 244);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(45, 25);
            this.button_1.TabIndex = 5;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.Button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_2.Location = new System.Drawing.Point(78, 244);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(45, 25);
            this.button_2.TabIndex = 6;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.Button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_3.Location = new System.Drawing.Point(147, 244);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(45, 25);
            this.button_3.TabIndex = 7;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.Button_3_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(221, 244);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(45, 25);
            this.button_minus.TabIndex = 8;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.Button_minus_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_4.Location = new System.Drawing.Point(12, 193);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(45, 25);
            this.button_4.TabIndex = 9;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.Button_4_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_5.Location = new System.Drawing.Point(78, 193);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(45, 25);
            this.button_5.TabIndex = 10;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.Button_5_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_6.Location = new System.Drawing.Point(147, 193);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(45, 25);
            this.button_6.TabIndex = 11;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.Button_6_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multiply.Location = new System.Drawing.Point(221, 193);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(45, 25);
            this.button_multiply.TabIndex = 12;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.Button_multiply_Click);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_7.Location = new System.Drawing.Point(12, 140);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(45, 25);
            this.button_7.TabIndex = 13;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.Button_7_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_8.Location = new System.Drawing.Point(78, 140);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(45, 25);
            this.button_8.TabIndex = 14;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.Button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_9.Location = new System.Drawing.Point(147, 140);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(45, 25);
            this.button_9.TabIndex = 15;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.Button_9_Click);
            // 
            // button_divide
            // 
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_divide.Location = new System.Drawing.Point(221, 140);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(45, 25);
            this.button_divide.TabIndex = 16;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.Button_divide_Click);
            // 
            // button_AllClear
            // 
            this.button_AllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AllClear.Location = new System.Drawing.Point(12, 90);
            this.button_AllClear.Name = "button_AllClear";
            this.button_AllClear.Size = new System.Drawing.Size(45, 25);
            this.button_AllClear.TabIndex = 17;
            this.button_AllClear.Text = "AC";
            this.button_AllClear.UseVisualStyleBackColor = true;
            this.button_AllClear.Click += new System.EventHandler(this.Button_AllClear_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(78, 90);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(45, 25);
            this.button_clear.TabIndex = 18;
            this.button_clear.Text = "<-";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // button_leftbkt
            // 
            this.button_leftbkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_leftbkt.Location = new System.Drawing.Point(147, 90);
            this.button_leftbkt.Name = "button_leftbkt";
            this.button_leftbkt.Size = new System.Drawing.Size(45, 25);
            this.button_leftbkt.TabIndex = 19;
            this.button_leftbkt.Text = "(";
            this.button_leftbkt.UseVisualStyleBackColor = true;
            // 
            // button_rightbkt
            // 
            this.button_rightbkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_rightbkt.Location = new System.Drawing.Point(221, 90);
            this.button_rightbkt.Name = "button_rightbkt";
            this.button_rightbkt.Size = new System.Drawing.Size(45, 25);
            this.button_rightbkt.TabIndex = 20;
            this.button_rightbkt.Text = ")";
            this.button_rightbkt.UseVisualStyleBackColor = true;
            this.button_rightbkt.Click += new System.EventHandler(this.Button20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 334);
            this.Controls.Add(this.button_rightbkt);
            this.Controls.Add(this.button_leftbkt);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_AllClear);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_zero);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_zero;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_AllClear;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_leftbkt;
        private System.Windows.Forms.Button button_rightbkt;
    }
}


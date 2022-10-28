
namespace SecondLab
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textAnswer = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первая сторона треугольника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Воторая сторона треугольника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Третья сторона треугольника";
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(302, 90);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(145, 22);
            this.textA.TabIndex = 3;
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(302, 174);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(145, 22);
            this.textC.TabIndex = 4;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(302, 132);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(145, 22);
            this.textB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(93, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Существует ли треугольник?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(75, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вычислить!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textAnswer
            // 
            this.textAnswer.AutoSize = true;
            this.textAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textAnswer.Location = new System.Drawing.Point(73, 281);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(72, 20);
            this.textAnswer.TabIndex = 8;
            this.textAnswer.Text = "Ответ: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(72, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(375, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Введите все значения сторон и нажмите на кнопку";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 375);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ЛабРабота2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textAnswer;
        private System.Windows.Forms.TextBox textBox4;
    }
}


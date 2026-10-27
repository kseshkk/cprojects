namespace WindowsFormsFirstProject
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
            this.buttonNewExample = new System.Windows.Forms.Button();
            this.labelExample = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserAnswer = new System.Windows.Forms.TextBox();
            this.buttonCheckUserAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewExample
            // 
            this.buttonNewExample.Location = new System.Drawing.Point(12, 12);
            this.buttonNewExample.Name = "buttonNewExample";
            this.buttonNewExample.Size = new System.Drawing.Size(309, 52);
            this.buttonNewExample.TabIndex = 0;
            this.buttonNewExample.Text = "сгенерировать новый пример";
            this.buttonNewExample.UseVisualStyleBackColor = true;
            this.buttonNewExample.Click += new System.EventHandler(this.buttonNewExample_Click);
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExample.Location = new System.Drawing.Point(12, 79);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(87, 29);
            this.labelExample.TabIndex = 1;
            this.labelExample.Text = "x+y=?";
            this.labelExample.Click += new System.EventHandler(this.labelExample_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите ваш ответ:";
            // 
            // textBoxUserAnswer
            // 
            this.textBoxUserAnswer.Location = new System.Drawing.Point(15, 137);
            this.textBoxUserAnswer.Name = "textBoxUserAnswer";
            this.textBoxUserAnswer.Size = new System.Drawing.Size(306, 22);
            this.textBoxUserAnswer.TabIndex = 3;
            // 
            // buttonCheckUserAnswer
            // 
            this.buttonCheckUserAnswer.Location = new System.Drawing.Point(12, 194);
            this.buttonCheckUserAnswer.Name = "buttonCheckUserAnswer";
            this.buttonCheckUserAnswer.Size = new System.Drawing.Size(309, 41);
            this.buttonCheckUserAnswer.TabIndex = 4;
            this.buttonCheckUserAnswer.Text = "проверить ответ";
            this.buttonCheckUserAnswer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCheckUserAnswer);
            this.Controls.Add(this.textBoxUserAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.buttonNewExample);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewExample;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserAnswer;
        private System.Windows.Forms.Button buttonCheckUserAnswer;
    }
}


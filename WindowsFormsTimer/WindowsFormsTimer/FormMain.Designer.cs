namespace WindowsFormsTimer
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonLap = new System.Windows.Forms.Button();
            this.Label55 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelTotalTime = new System.Windows.Forms.Label();
            this.LabelLapTime = new System.Windows.Forms.Label();
            this.listBoxLapsTime = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountLap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentLap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(15, 119);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(105, 38);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(126, 119);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 37);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(341, 120);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(98, 37);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonLap
            // 
            this.buttonLap.Location = new System.Drawing.Point(232, 120);
            this.buttonLap.Name = "buttonLap";
            this.buttonLap.Size = new System.Drawing.Size(103, 37);
            this.buttonLap.TabIndex = 3;
            this.buttonLap.Text = "Круг";
            this.buttonLap.UseVisualStyleBackColor = true;
            this.buttonLap.Click += new System.EventHandler(this.buttonLap_Click);
            // 
            // Label55
            // 
            this.Label55.AutoSize = true;
            this.Label55.Location = new System.Drawing.Point(13, 9);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(93, 16);
            this.Label55.TabIndex = 4;
            this.Label55.Text = "Общее время";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(13, 68);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(96, 16);
            this.Label22.TabIndex = 5;
            this.Label22.Text = "Текущий круг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Круги";
            // 
            // LabelTotalTime
            // 
            this.LabelTotalTime.AutoSize = true;
            this.LabelTotalTime.Location = new System.Drawing.Point(11, 29);
            this.LabelTotalTime.Name = "LabelTotalTime";
            this.LabelTotalTime.Size = new System.Drawing.Size(22, 16);
            this.LabelTotalTime.TabIndex = 7;
            this.LabelTotalTime.Text = "***";
            this.LabelTotalTime.Click += new System.EventHandler(this.LabelTotalTime_Click);
            // 
            // LabelLapTime
            // 
            this.LabelLapTime.AutoSize = true;
            this.LabelLapTime.Location = new System.Drawing.Point(13, 94);
            this.LabelLapTime.Name = "LabelLapTime";
            this.LabelLapTime.Size = new System.Drawing.Size(22, 16);
            this.LabelLapTime.TabIndex = 8;
            this.LabelLapTime.Text = "***";
            this.LabelLapTime.Click += new System.EventHandler(this.LabelLapTime_Click);
            // 
            // listBoxLapsTime
            // 
            this.listBoxLapsTime.FormattingEnabled = true;
            this.listBoxLapsTime.ItemHeight = 16;
            this.listBoxLapsTime.Location = new System.Drawing.Point(15, 197);
            this.listBoxLapsTime.Name = "listBoxLapsTime";
            this.listBoxLapsTime.Size = new System.Drawing.Size(406, 148);
            this.listBoxLapsTime.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Пройдено кругов";
            // 
            // labelCountLap
            // 
            this.labelCountLap.AutoSize = true;
            this.labelCountLap.Location = new System.Drawing.Point(279, 29);
            this.labelCountLap.Name = "labelCountLap";
            this.labelCountLap.Size = new System.Drawing.Size(22, 16);
            this.labelCountLap.TabIndex = 11;
            this.labelCountLap.Text = "***";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Текущий круг";
            // 
            // labelCurrentLap
            // 
            this.labelCurrentLap.AutoSize = true;
            this.labelCurrentLap.Location = new System.Drawing.Point(279, 94);
            this.labelCurrentLap.Name = "labelCurrentLap";
            this.labelCurrentLap.Size = new System.Drawing.Size(22, 16);
            this.labelCurrentLap.TabIndex = 13;
            this.labelCurrentLap.Text = "***";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 360);
            this.Controls.Add(this.labelCurrentLap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCountLap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLapsTime);
            this.Controls.Add(this.LabelLapTime);
            this.Controls.Add(this.LabelTotalTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.Label55);
            this.Controls.Add(this.buttonLap);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonLap;
        private System.Windows.Forms.Label Label55;
        private System.Windows.Forms.Label Label22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelTotalTime;
        private System.Windows.Forms.Label LabelLapTime;
        private System.Windows.Forms.ListBox listBoxLapsTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCountLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentLap;
    }
}


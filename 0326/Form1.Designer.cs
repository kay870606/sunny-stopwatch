namespace _0326
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonStopwatchStart = new System.Windows.Forms.Button();
            this.buttonStopwatchClear = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStopwatch = new System.Windows.Forms.Button();
            this.buttonCountdown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonCountdownStart = new System.Windows.Forms.Button();
            this.buttonCountdownClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Enabled = false;
            this.buttonDisplay.Font = new System.Drawing.Font("新細明體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDisplay.Location = new System.Drawing.Point(104, 40);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(208, 112);
            this.buttonDisplay.TabIndex = 0;
            this.buttonDisplay.Text = "00:00:00";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Visible = false;
            // 
            // buttonStopwatchStart
            // 
            this.buttonStopwatchStart.Location = new System.Drawing.Point(104, 172);
            this.buttonStopwatchStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStopwatchStart.Name = "buttonStopwatchStart";
            this.buttonStopwatchStart.Size = new System.Drawing.Size(90, 40);
            this.buttonStopwatchStart.TabIndex = 1;
            this.buttonStopwatchStart.Text = "Start";
            this.buttonStopwatchStart.UseVisualStyleBackColor = true;
            this.buttonStopwatchStart.Visible = false;
            this.buttonStopwatchStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStopwatchClear
            // 
            this.buttonStopwatchClear.Location = new System.Drawing.Point(222, 172);
            this.buttonStopwatchClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStopwatchClear.Name = "buttonStopwatchClear";
            this.buttonStopwatchClear.Size = new System.Drawing.Size(90, 40);
            this.buttonStopwatchClear.TabIndex = 2;
            this.buttonStopwatchClear.Text = "Clear";
            this.buttonStopwatchClear.UseVisualStyleBackColor = true;
            this.buttonStopwatchClear.Visible = false;
            this.buttonStopwatchClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(301, 230);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(82, 44);
            this.buttonSet.TabIndex = 14;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Visible = false;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonClear2
            // 
            this.buttonClear2.Location = new System.Drawing.Point(301, 278);
            this.buttonClear2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(82, 45);
            this.buttonClear2.TabIndex = 13;
            this.buttonClear2.Text = "Clear";
            this.buttonClear2.UseVisualStyleBackColor = true;
            this.buttonClear2.Visible = false;
            this.buttonClear2.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStopwatch
            // 
            this.buttonStopwatch.Location = new System.Drawing.Point(41, 378);
            this.buttonStopwatch.Name = "buttonStopwatch";
            this.buttonStopwatch.Size = new System.Drawing.Size(153, 104);
            this.buttonStopwatch.TabIndex = 15;
            this.buttonStopwatch.Text = "Stopwatch";
            this.buttonStopwatch.UseVisualStyleBackColor = true;
            this.buttonStopwatch.Click += new System.EventHandler(this.buttonStopwatch_Click);
            // 
            // buttonCountdown
            // 
            this.buttonCountdown.Location = new System.Drawing.Point(230, 378);
            this.buttonCountdown.Name = "buttonCountdown";
            this.buttonCountdown.Size = new System.Drawing.Size(153, 104);
            this.buttonCountdown.TabIndex = 16;
            this.buttonCountdown.Text = "Countdown";
            this.buttonCountdown.UseVisualStyleBackColor = true;
            this.buttonCountdown.Click += new System.EventHandler(this.buttonCountdown_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 44);
            this.button2.TabIndex = 18;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 44);
            this.button3.TabIndex = 19;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 44);
            this.button4.TabIndex = 20;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 44);
            this.button5.TabIndex = 21;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(83, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 44);
            this.button6.TabIndex = 22;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(135, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 44);
            this.button7.TabIndex = 23;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(187, 230);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 44);
            this.button8.TabIndex = 24;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(239, 230);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 44);
            this.button9.TabIndex = 25;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(31, 280);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(46, 44);
            this.button0.TabIndex = 26;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Visible = false;
            this.button0.Click += new System.EventHandler(this.buttonNum_Click);
            // 
            // buttonCountdownStart
            // 
            this.buttonCountdownStart.Location = new System.Drawing.Point(460, 172);
            this.buttonCountdownStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountdownStart.Name = "buttonCountdownStart";
            this.buttonCountdownStart.Size = new System.Drawing.Size(90, 40);
            this.buttonCountdownStart.TabIndex = 27;
            this.buttonCountdownStart.Text = "Start";
            this.buttonCountdownStart.UseVisualStyleBackColor = true;
            this.buttonCountdownStart.Visible = false;
            this.buttonCountdownStart.Click += new System.EventHandler(this.buttonCountdownStart_Click);
            // 
            // buttonCountdownClear
            // 
            this.buttonCountdownClear.Location = new System.Drawing.Point(574, 172);
            this.buttonCountdownClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountdownClear.Name = "buttonCountdownClear";
            this.buttonCountdownClear.Size = new System.Drawing.Size(90, 40);
            this.buttonCountdownClear.TabIndex = 28;
            this.buttonCountdownClear.Text = "Clear";
            this.buttonCountdownClear.UseVisualStyleBackColor = true;
            this.buttonCountdownClear.Visible = false;
            this.buttonCountdownClear.Click += new System.EventHandler(this.buttonCountdownClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 551);
            this.Controls.Add(this.buttonCountdownClear);
            this.Controls.Add(this.buttonCountdownStart);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCountdown);
            this.Controls.Add(this.buttonStopwatch);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.buttonClear2);
            this.Controls.Add(this.buttonStopwatchClear);
            this.Controls.Add(this.buttonStopwatchStart);
            this.Controls.Add(this.buttonDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonStopwatchStart;
        private System.Windows.Forms.Button buttonStopwatchClear;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonClear2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStopwatch;
        private System.Windows.Forms.Button buttonCountdown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonCountdownStart;
        private System.Windows.Forms.Button buttonCountdownClear;
    }
}


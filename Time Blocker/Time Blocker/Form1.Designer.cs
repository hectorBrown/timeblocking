namespace Time_Blocker
{
    partial class FRM_main
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
            this.LBL_elapsed = new System.Windows.Forms.Label();
            this.BUT_startstop = new System.Windows.Forms.Button();
            this.LBL_workTime = new System.Windows.Forms.Label();
            this.LBL_restTime = new System.Windows.Forms.Label();
            this.NUD_workTime = new System.Windows.Forms.NumericUpDown();
            this.NUD_restTime = new System.Windows.Forms.NumericUpDown();
            this.TIM_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_workTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_restTime)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_elapsed
            // 
            this.LBL_elapsed.AutoSize = true;
            this.LBL_elapsed.BackColor = System.Drawing.Color.Green;
            this.LBL_elapsed.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_elapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_elapsed.ForeColor = System.Drawing.Color.White;
            this.LBL_elapsed.Location = new System.Drawing.Point(0, 0);
            this.LBL_elapsed.Name = "LBL_elapsed";
            this.LBL_elapsed.Size = new System.Drawing.Size(194, 73);
            this.LBL_elapsed.TabIndex = 0;
            this.LBL_elapsed.Text = "00:00";
            // 
            // BUT_startstop
            // 
            this.BUT_startstop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BUT_startstop.Location = new System.Drawing.Point(0, 73);
            this.BUT_startstop.Name = "BUT_startstop";
            this.BUT_startstop.Size = new System.Drawing.Size(194, 23);
            this.BUT_startstop.TabIndex = 1;
            this.BUT_startstop.Text = "START";
            this.BUT_startstop.UseVisualStyleBackColor = true;
            this.BUT_startstop.Click += new System.EventHandler(this.BUT_startstop_Click);
            // 
            // LBL_workTime
            // 
            this.LBL_workTime.AutoSize = true;
            this.LBL_workTime.Location = new System.Drawing.Point(12, 99);
            this.LBL_workTime.Name = "LBL_workTime";
            this.LBL_workTime.Size = new System.Drawing.Size(58, 13);
            this.LBL_workTime.TabIndex = 2;
            this.LBL_workTime.Text = "Work (min)";
            // 
            // LBL_restTime
            // 
            this.LBL_restTime.AutoSize = true;
            this.LBL_restTime.Location = new System.Drawing.Point(128, 99);
            this.LBL_restTime.Name = "LBL_restTime";
            this.LBL_restTime.Size = new System.Drawing.Size(54, 13);
            this.LBL_restTime.TabIndex = 3;
            this.LBL_restTime.Text = "Rest (min)";
            // 
            // NUD_workTime
            // 
            this.NUD_workTime.Location = new System.Drawing.Point(15, 115);
            this.NUD_workTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NUD_workTime.Name = "NUD_workTime";
            this.NUD_workTime.Size = new System.Drawing.Size(55, 20);
            this.NUD_workTime.TabIndex = 4;
            this.NUD_workTime.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.NUD_workTime.ValueChanged += new System.EventHandler(this.NUD_workTime_ValueChanged);
            // 
            // NUD_restTime
            // 
            this.NUD_restTime.Location = new System.Drawing.Point(127, 115);
            this.NUD_restTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NUD_restTime.Name = "NUD_restTime";
            this.NUD_restTime.Size = new System.Drawing.Size(55, 20);
            this.NUD_restTime.TabIndex = 5;
            this.NUD_restTime.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NUD_restTime.ValueChanged += new System.EventHandler(this.NUD_restTime_ValueChanged);
            // 
            // TIM_timer
            // 
            this.TIM_timer.Interval = 1000;
            this.TIM_timer.Tick += new System.EventHandler(this.TIM_timer_Tick);
            // 
            // FRM_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 148);
            this.Controls.Add(this.NUD_restTime);
            this.Controls.Add(this.NUD_workTime);
            this.Controls.Add(this.LBL_restTime);
            this.Controls.Add(this.LBL_workTime);
            this.Controls.Add(this.BUT_startstop);
            this.Controls.Add(this.LBL_elapsed);
            this.Name = "FRM_main";
            this.Opacity = 0.65D;
            this.Text = "Time Blocker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_workTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_restTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_elapsed;
        private System.Windows.Forms.Button BUT_startstop;
        private System.Windows.Forms.Label LBL_workTime;
        private System.Windows.Forms.Label LBL_restTime;
        private System.Windows.Forms.NumericUpDown NUD_workTime;
        private System.Windows.Forms.NumericUpDown NUD_restTime;
        private System.Windows.Forms.Timer TIM_timer;
    }
}


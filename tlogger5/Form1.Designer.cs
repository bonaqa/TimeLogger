namespace tlogger5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmrDispUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbcntrlMain = new System.Windows.Forms.TabControl();
            this.tabPgDay = new System.Windows.Forms.TabPage();
            this.tabPgWeek = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPgMonth = new System.Windows.Forms.TabPage();
            this.tabPgYear = new System.Windows.Forms.TabPage();
            this.txtExpectend = new System.Windows.Forms.TextBox();
            this.txtWorktime = new System.Windows.Forms.TextBox();
            this.txtValeotime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOfficetime = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.tabPgSettings = new System.Windows.Forms.TabPage();
            this.tbcntrlMain.SuspendLayout();
            this.tabPgDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Tlogger";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipShown += new System.EventHandler(this.Form1_Resize);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tmrDispUpdate
            // 
            this.tmrDispUpdate.Interval = 5000;
            this.tmrDispUpdate.Tick += new System.EventHandler(this.tmrDispUpdate_Tick);
            // 
            // tbcntrlMain
            // 
            this.tbcntrlMain.Controls.Add(this.tabPgDay);
            this.tbcntrlMain.Controls.Add(this.tabPgWeek);
            this.tbcntrlMain.Controls.Add(this.tabPgMonth);
            this.tbcntrlMain.Controls.Add(this.tabPgYear);
            this.tbcntrlMain.Controls.Add(this.tabPgSettings);
            this.tbcntrlMain.Location = new System.Drawing.Point(12, 12);
            this.tbcntrlMain.Name = "tbcntrlMain";
            this.tbcntrlMain.SelectedIndex = 0;
            this.tbcntrlMain.Size = new System.Drawing.Size(526, 295);
            this.tbcntrlMain.TabIndex = 10;
            // 
            // tabPgDay
            // 
            this.tabPgDay.Controls.Add(this.txtExpectend);
            this.tabPgDay.Controls.Add(this.txtWorktime);
            this.tabPgDay.Controls.Add(this.txtValeotime);
            this.tabPgDay.Controls.Add(this.label2);
            this.tabPgDay.Controls.Add(this.label1);
            this.tabPgDay.Controls.Add(this.lblOfficetime);
            this.tabPgDay.Controls.Add(this.cmdStop);
            this.tabPgDay.Controls.Add(this.cmdStart);
            this.tabPgDay.Controls.Add(this.dataGridView1);
            this.tabPgDay.Location = new System.Drawing.Point(4, 22);
            this.tabPgDay.Name = "tabPgDay";
            this.tabPgDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgDay.Size = new System.Drawing.Size(518, 269);
            this.tabPgDay.TabIndex = 0;
            this.tabPgDay.Text = "Daily Stats";
            this.tabPgDay.UseVisualStyleBackColor = true;
            // 
            // tabPgWeek
            // 
            this.tabPgWeek.Location = new System.Drawing.Point(4, 22);
            this.tabPgWeek.Name = "tabPgWeek";
            this.tabPgWeek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgWeek.Size = new System.Drawing.Size(518, 269);
            this.tabPgWeek.TabIndex = 1;
            this.tabPgWeek.Text = "Weekly Stats";
            this.tabPgWeek.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K,
            this.G,
            this.Net});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 193);
            this.dataGridView1.TabIndex = 4;
            // 
            // K
            // 
            this.K.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.K.HeaderText = "K";
            this.K.Name = "K";
            // 
            // G
            // 
            this.G.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.G.HeaderText = "G";
            this.G.Name = "G";
            // 
            // Net
            // 
            this.Net.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Net.HeaderText = "Net";
            this.Net.Name = "Net";
            // 
            // tabPgMonth
            // 
            this.tabPgMonth.Location = new System.Drawing.Point(4, 22);
            this.tabPgMonth.Name = "tabPgMonth";
            this.tabPgMonth.Size = new System.Drawing.Size(518, 269);
            this.tabPgMonth.TabIndex = 2;
            this.tabPgMonth.Text = "Monthly Stats";
            this.tabPgMonth.UseVisualStyleBackColor = true;
            // 
            // tabPgYear
            // 
            this.tabPgYear.Location = new System.Drawing.Point(4, 22);
            this.tabPgYear.Name = "tabPgYear";
            this.tabPgYear.Size = new System.Drawing.Size(518, 269);
            this.tabPgYear.TabIndex = 3;
            this.tabPgYear.Text = "Yearly Stats";
            this.tabPgYear.UseVisualStyleBackColor = true;
            // 
            // txtExpectend
            // 
            this.txtExpectend.Location = new System.Drawing.Point(412, 246);
            this.txtExpectend.Name = "txtExpectend";
            this.txtExpectend.ReadOnly = true;
            this.txtExpectend.Size = new System.Drawing.Size(100, 20);
            this.txtExpectend.TabIndex = 17;
            this.txtExpectend.TabStop = false;
            // 
            // txtWorktime
            // 
            this.txtWorktime.Location = new System.Drawing.Point(412, 226);
            this.txtWorktime.Name = "txtWorktime";
            this.txtWorktime.ReadOnly = true;
            this.txtWorktime.Size = new System.Drawing.Size(100, 20);
            this.txtWorktime.TabIndex = 16;
            this.txtWorktime.TabStop = false;
            // 
            // txtValeotime
            // 
            this.txtValeotime.Location = new System.Drawing.Point(412, 206);
            this.txtValeotime.Name = "txtValeotime";
            this.txtValeotime.ReadOnly = true;
            this.txtValeotime.Size = new System.Drawing.Size(100, 20);
            this.txtValeotime.TabIndex = 15;
            this.txtValeotime.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Expected end:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Working time:";
            // 
            // lblOfficetime
            // 
            this.lblOfficetime.AutoSize = true;
            this.lblOfficetime.Location = new System.Drawing.Point(333, 210);
            this.lblOfficetime.Name = "lblOfficetime";
            this.lblOfficetime.Size = new System.Drawing.Size(73, 13);
            this.lblOfficetime.TabIndex = 12;
            this.lblOfficetime.Text = "Time in office:";
            // 
            // cmdStop
            // 
            this.cmdStop.Enabled = false;
            this.cmdStop.Location = new System.Drawing.Point(91, 216);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 43);
            this.cmdStop.TabIndex = 11;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click_1);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(7, 216);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 43);
            this.cmdStart.TabIndex = 10;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click_1);
            // 
            // tabPgSettings
            // 
            this.tabPgSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPgSettings.Name = "tabPgSettings";
            this.tabPgSettings.Size = new System.Drawing.Size(518, 269);
            this.tabPgSettings.TabIndex = 4;
            this.tabPgSettings.Text = "Settings";
            this.tabPgSettings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(550, 319);
            this.Controls.Add(this.tbcntrlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Time Logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tbcntrlMain.ResumeLayout(false);
            this.tabPgDay.ResumeLayout(false);
            this.tabPgDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer tmrDispUpdate;
        private System.Windows.Forms.TabControl tbcntrlMain;
        private System.Windows.Forms.TabPage tabPgDay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn K;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn Net;
        private System.Windows.Forms.TabPage tabPgWeek;
        private System.Windows.Forms.TabPage tabPgMonth;
        private System.Windows.Forms.TabPage tabPgYear;
        private System.Windows.Forms.TextBox txtExpectend;
        private System.Windows.Forms.TextBox txtWorktime;
        private System.Windows.Forms.TextBox txtValeotime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOfficetime;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.TabPage tabPgSettings;
    }
}


namespace serial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            serial_port_text = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            serialport = new ComboBox();
            serialbounte = new ComboBox();
            scan_button = new Button();
            open_off_button = new Button();
            label1 = new Label();
            label5 = new Label();
            labe_send = new Label();
            led_on = new Button();
            led_off = new Button();
            dgvLog = new DataGridView();
            colTime = new DataGridViewTextBoxColumn();
            colDir = new DataGridViewTextBoxColumn();
            Frame_header = new DataGridViewTextBoxColumn();
            Length = new DataGridViewTextBoxColumn();
            colData = new DataGridViewTextBoxColumn();
            Sumer_check = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
            SuspendLayout();
            // 
            // serial_port_text
            // 
            serial_port_text.AutoSize = true;
            serial_port_text.Location = new Point(27, 18);
            serial_port_text.Name = "serial_port_text";
            serial_port_text.Size = new Size(54, 20);
            serial_port_text.TabIndex = 0;
            serial_port_text.Text = "串口号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 49);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "波特率";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 89);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "串口扫描";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 125);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "打开串口";
            // 
            // serialport
            // 
            serialport.FormattingEnabled = true;
            serialport.Location = new Point(102, 10);
            serialport.Name = "serialport";
            serialport.Size = new Size(151, 28);
            serialport.TabIndex = 4;
            serialport.SelectedIndexChanged += serialport_SelectedIndexChanged;
            // 
            // serialbounte
            // 
            serialbounte.FormattingEnabled = true;
            serialbounte.Location = new Point(102, 46);
            serialbounte.Name = "serialbounte";
            serialbounte.Size = new Size(151, 28);
            serialbounte.TabIndex = 5;
            serialbounte.SelectedIndexChanged += serialbounte_SelectedIndexChanged;
            // 
            // scan_button
            // 
            scan_button.Location = new Point(102, 85);
            scan_button.Name = "scan_button";
            scan_button.Size = new Size(94, 29);
            scan_button.TabIndex = 6;
            scan_button.Text = "开始扫描";
            scan_button.UseVisualStyleBackColor = true;
            scan_button.Click += scan_button_Click;
            // 
            // open_off_button
            // 
            open_off_button.Location = new Point(102, 125);
            open_off_button.Name = "open_off_button";
            open_off_button.Size = new Size(94, 29);
            open_off_button.TabIndex = 7;
            open_off_button.Text = "打开串口";
            open_off_button.UseVisualStyleBackColor = true;
            open_off_button.Click += open_off_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 10);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 8;
            label1.Text = "开灯";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(547, 10);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 9;
            label5.Text = "关灯";
            // 
            // labe_send
            // 
            labe_send.AutoSize = true;
            labe_send.Location = new Point(372, 129);
            labe_send.MinimumSize = new Size(300, 30);
            labe_send.Name = "labe_send";
            labe_send.Size = new Size(300, 30);
            labe_send.TabIndex = 10;
            labe_send.Text = "label_send";
            labe_send.Click += label6_Click;
            // 
            // led_on
            // 
            led_on.Location = new Point(372, 49);
            led_on.Name = "led_on";
            led_on.Size = new Size(94, 29);
            led_on.TabIndex = 11;
            led_on.Text = "open";
            led_on.UseVisualStyleBackColor = true;
            led_on.Click += led_on_Click;
            // 
            // led_off
            // 
            led_off.Location = new Point(547, 49);
            led_off.Name = "led_off";
            led_off.Size = new Size(94, 29);
            led_off.TabIndex = 12;
            led_off.Text = "close";
            led_off.UseVisualStyleBackColor = true;
            led_off.Click += led_off_Click;
            // 
            // dgvLog
            // 
            dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLog.Columns.AddRange(new DataGridViewColumn[] { colTime, colDir, Frame_header, Length, colData, Sumer_check });
            dgvLog.Location = new Point(41, 184);
            dgvLog.Name = "dgvLog";
            dgvLog.RowHeadersWidth = 51;
            dgvLog.Size = new Size(805, 149);
            dgvLog.TabIndex = 13;
            dgvLog.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colTime
            // 
            colTime.HeaderText = "colTime";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.Width = 125;
            // 
            // colDir
            // 
            colDir.HeaderText = "colDir";
            colDir.MinimumWidth = 6;
            colDir.Name = "colDir";
            colDir.Width = 125;
            // 
            // Frame_header
            // 
            Frame_header.HeaderText = "Frame_header";
            Frame_header.MinimumWidth = 6;
            Frame_header.Name = "Frame_header";
            Frame_header.Width = 125;
            // 
            // Length
            // 
            Length.HeaderText = "Length";
            Length.MinimumWidth = 6;
            Length.Name = "Length";
            Length.Width = 125;
            // 
            // colData
            // 
            colData.HeaderText = "colData";
            colData.MinimumWidth = 6;
            colData.Name = "colData";
            colData.Width = 125;
            // 
            // Sumer_check
            // 
            Sumer_check.HeaderText = "Sumer_check";
            Sumer_check.MinimumWidth = 6;
            Sumer_check.Name = "Sumer_check";
            Sumer_check.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 416);
            Controls.Add(dgvLog);
            Controls.Add(led_off);
            Controls.Add(led_on);
            Controls.Add(labe_send);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(open_off_button);
            Controls.Add(scan_button);
            Controls.Add(serialbounte);
            Controls.Add(serialport);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(serial_port_text);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label serial_port_text;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox serialport;
        private ComboBox serialbounte;
        private Button scan_button;
        private Button open_off_button;
        private Label label1;
        private Label label5;
        private Label labe_send;
        private Button led_on;
        private Button led_off;
        private DataGridView dgvLog;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colDir;
        private DataGridViewTextBoxColumn colData;
        private DataGridViewTextBoxColumn Frame_header;
        private DataGridViewTextBoxColumn Length;
        private DataGridViewTextBoxColumn Sumer_check;
    }
}

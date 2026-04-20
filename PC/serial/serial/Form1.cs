using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;

namespace serial
{
    public partial class Form1 : Form
    {
        // 实例化串口对象
        private SerialPort mySerialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            // 初始化波特率选项
            InitSerialSettings();

            // 绑定串口接收事件回调
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void InitSerialSettings()
        {
            string[] bauds = { "9600", "19200", "38400", "57600", "115200" };
            serialbounte.Items.AddRange(bauds);
            serialbounte.SelectedIndex = 0; // 默认选中 9600
        }

        // 1. 扫描串口
        private void scan_button_Click(object sender, EventArgs e)
        {
            serialport.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                serialport.Items.AddRange(ports);
                serialport.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("未找到可用串口！", "提示");
            }
        }

        // 2. 打开/关闭串口切换
        private void open_off_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mySerialPort.IsOpen)
                {
                    // 检查是否选择了串口和波特率
                    if (string.IsNullOrEmpty(serialport.Text)) return;

                    mySerialPort.PortName = serialport.Text;
                    mySerialPort.BaudRate = Convert.ToInt32(serialbounte.Text);

                    mySerialPort.Open();

                    open_off_button.Text = "关闭串口";
                    open_off_button.BackColor = Color.LightCoral;
                    // 打开后禁用配置控件防止误操作
                    serialport.Enabled = false;
                    serialbounte.Enabled = false;
                }
                else
                {
                    mySerialPort.Close();

                    open_off_button.Text = "打开串口";
                    open_off_button.BackColor = SystemColors.Control;
                    serialport.Enabled = true;
                    serialbounte.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作失败: " + ex.Message, "错误");
            }
        }

        // 3. 接收数据处理 (注意：此函数在后台线程运行)
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // 读取缓冲区内容
            string incomingData = mySerialPort.ReadExisting();

            // 因为 DataReceived 在非 UI 线程，更新界面需要使用 Invoke
            this.Invoke(new MethodInvoker(delegate
            {
                // 假设你有一个名为 txtConsole 的 TextBox 用来显示日志
                // txtConsole.AppendText($"[{DateTime.Now:HH:mm:ss}] RX: {incomingData}\r\n");
                Console.WriteLine("收到数据: " + incomingData);
            }));
        }

        // 4. 窗体关闭前确保关闭串口，防止句柄死锁
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (mySerialPort.IsOpen) mySerialPort.Close();
            base.OnFormClosing(e);
        }

        // 占位函数（如果不需要可以删除或保留）
        private void serialport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void serialbounte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void led_on_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen)
            {

                byte[] cmd = { 0x01, 0x1 }; // 假设 01 是地址，11 是指令

                byte[] fullPkg = send_cmd.Send(mySerialPort, cmd);
                LogToExcelStyle("TX 发送", fullPkg);
                led_on.BackColor = Color.Green;
                led_off.BackColor = Color.Red;

            }
        }

        private void led_off_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen)
            {
                byte[] cmd = { 0x01, 0x0 }; // 假设 01 是地址，11 是指令
                send_cmd.Send(mySerialPort, cmd);
                led_off.BackColor = Color.Green;
                led_on.BackColor = Color.Red;
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LogToExcelStyle(string direction, byte[] fullPkg)
        {
            if (fullPkg == null || fullPkg.Length < 4) return; // 基础保护

            this.Invoke(new MethodInvoker(delegate
            {
                // 1. 提取各部分数据
                string time = DateTime.Now.ToString("HH:mm:ss.fff");
                string header = fullPkg[0].ToString("X2") + " " + fullPkg[1].ToString("X2"); // AA 55
                string length = fullPkg[2].ToString("X2"); // 长度位

                // 提取中间的数据位 (去掉头2位, 长度1位, 末尾校验1位)
                byte[] dataPart = new byte[fullPkg.Length - 4];
                Array.Copy(fullPkg, 3, dataPart, 0, dataPart.Length);
                string dataStr = BitConverter.ToString(dataPart).Replace("-", " ");

                string checksum = fullPkg[fullPkg.Length - 1].ToString("X2"); // 校验位

                // 2. 插入新行，对应你图片中的列顺序
                // colTime | colDir | Frame_header | Length | colData | Sumer_check
                dgvLog.Rows.Insert(0, time, direction, header, length, dataStr, checksum );
                // 2. 因为你是 Insert(0, ...)，所以新插入的行永远是第 0 行
                // 直接针对第 0 行进行颜色美化
                if (direction.Contains("TX"))
                {
                    dgvLog.Rows[0].DefaultCellStyle.ForeColor = Color.Blue;
                }
                else
                {
                    dgvLog.Rows[0].DefaultCellStyle.ForeColor = Color.Green;
                }
            }));
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
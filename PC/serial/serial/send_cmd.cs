using System;
using System.IO.Ports;

namespace serial
{
    internal class send_cmd
    {
        /// <summary>
        /// 发送自定义协议帧
        /// 结构：起始码(2字节) + 长度(1字节) + 数据(n字节) + 累加校验(1字节)
        /// </summary>
        public static byte[] Send(SerialPort port, byte[] data)
        {
            if (port == null || !port.IsOpen) return null;

            byte header1 = 0xAA; // 启示码1
            byte header2 = 0x55; // 启示码2
            byte[] frame = new byte[2 + 1 + data.Length + 1];

            frame[0] = header1;
            frame[1] = header2;
            frame[2] = (byte)data.Length;

            byte checksum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                frame[3 + i] = data[i];
            }

            // 计算包括头和长度在内的所有位累加
            for (int i = 0; i < frame.Length - 1; i++)
            {
                checksum += frame[i];
            }
            frame[frame.Length - 1] = checksum;

            port.Write(frame, 0, frame.Length);
            return frame; // 返回发出的完整包
        }
    }
}
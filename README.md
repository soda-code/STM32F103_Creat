# STM32F103_Creat

![STM32](https://img.shields.io/badge/STM32-F103-blue)
![Keil MDK](https://img.shields.io/badge/Keil-MDK-green)
![License](https://img.shields.io/badge/License-MIT-yellow)

**STM32F103 开发模板仓库** | **STM32F103 Development Template**

本仓库提供了一个结构清晰、开箱即用的 STM32F103 开发工程模板，适合学习、快速原型开发和项目复用。

This repository provides a well-structured, ready-to-use STM32F103 development project template, ideal for learning, rapid prototyping, and project reuse.

---

## ✨ 项目特性 | Features

- 支持标准库 / HAL 库（根据实际 Drivers 文件夹）
- 完整的 Keil MDK 工程（`.uvprojx`）
- 模块化目录结构，易于扩展和维护
- 附带 PC 端串口上位机程序（`PC/serial`）
- 常用外设初始化模板（GPIO、USART、TIM、ADC 等）
- 提供 Keil 工程清理脚本 `keilkill.bat`

- Standard Library / HAL Library supported
- Complete Keil MDK project
- Modular directory structure, easy to extend
- PC serial debugging tool included
- Common peripheral initialization templates
- Keil cache cleaning script

---

## 📁 项目结构 | Project Structure

```bash
STM32F103_Creat/
├── stm32f103/                  # 主工程目录 / Main Project
│   ├── Drivers/                # 驱动库
│   ├── User/                   # 用户代码（核心开发区域）
│   ├── Projects/MDK-ARM/       # Keil 工程文件
│   └── keilkill.bat
├── PC/serial/                  # PC 端串口上位机
├── LICENSE
└── README.md
```

---

## 🚀 快速上手 | Quick Start

### 1. 克隆仓库 | Clone the Repository
```bash
git clone https://github.com/soda-code/STM32F103_Creat.git
cd STM32F103_Creat
```

### 2. 打开工程 | Open Project
1. 进入目录 `stm32f103/Projects/MDK-ARM/`
2. 双击 `stm32F103.uvprojx` 使用 **Keil μVision** 打开
3. 编译（`F7`）并下载到开发板

### 3. 串口调试 | Serial Debugging
使用 `PC/serial` 目录下的上位机程序进行测试，默认波特率请参考 `User` 目录下的 USART 配置。

---

## 📋 开发说明 | Development Notes

- **支持开发板**：STM32F103C8T6 / STM32F103ZET6 等（可自行适配）
- **推荐工具**：Keil MDK 5.3x 及以上 + J-Link / ST-Link
- **系统时钟**：外部 8MHz 晶振，倍频至 72MHz
- **建议**：用户代码尽量写在 `User/` 目录下，保持工程整洁

---

## 🤝 如何贡献 | How to Contribute

欢迎提交 Issue 和 Pull Request！

1. Fork 本仓库
2. 创建特性分支 (`git checkout -b feature/AmazingFeature`)
3. 提交更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 提交 Pull Request

---

## 📄 License

本项目采用 [MIT License](LICENSE) 开源协议。

This project is licensed under the [MIT License](LICENSE).

---

## ⭐ 支持项目 | Star History

如果你觉得这个项目对你有帮助，欢迎点个 **Star** 支持！

If this project helps you, please give it a **Star** ⭐

---

**Happy Coding with STM32!** 🚀  
**祝开发愉快！**



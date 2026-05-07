#include "gui_app.h"
#include "./BSP/LCD/lcd.h"

//******************************************************************************
//  File Name          : gui_run
//  Description        : This function runs the GUI application logic
//  Author             : MCD Application Team
//  Date               : 01-July-2016
//******************************************************************************

void gui_run(void)
{
    uint8_t tick_disp[20] = {0};
    uint32_t tick_count = 0;
    while (1)
    {
        tick_count = xTaskGetTickCount(); /* 获取当前系统滴答计数 */
        sprintf(tick_disp, "Tick: %lu", tick_count); /* 将滴答计数转换为字符串 */
        lcd_show_string(10, 10, lcddev.width - 20, lcddev.height - 20, 24, tick_disp, g_point_color); /* 显示字符串 */
    }
}

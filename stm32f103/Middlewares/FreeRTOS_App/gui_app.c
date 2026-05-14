#include "gui_app.h"
#include "./BSP/bsp_app.h"
#include "freertos_user_app.h"

extern QueueHandle_t Lsens_Data_Queue;  /* 队列句柄 */
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
    float lux_value = 0.0;
    while (1)
    {

        tick_count = xTaskGetTickCount(); /* 获取当前系统滴答计数 */
        sprintf(tick_disp, "Tick: %lu", tick_count); /* 将滴答计数转换为字符串 */
        lcd_show_string(10, 10, lcddev.width - 20, lcddev.height - 20, 24, tick_disp, g_point_color); /* 显示字符串 */
        if (xQueueReceive(Lsens_Data_Queue, &lux_value, 0) == pdPASS)
        {
            lux_value = Lsens_get_lux(); /* 获取光强值并更新曲线显示 */
            sprintf(tick_disp, "Lux: %.2f", lux_value); /* 将光强值转换为字符串 */
            lcd_show_string(10, 40, lcddev.width - 20, lcddev.height - 20, 24, tick_disp, g_point_color); /* 显示光强值 */
        }
    }
}




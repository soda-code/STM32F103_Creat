#include "led_app.h"
#include "./BSP/LED/led.h"

//******************************************************************************
//  File Name          : led_get_status
//  Description        : 获取当前LED状态
//  Author             : MCD Application Team
//  Date               : 01-July-2016
//******************************************************************************
static LED_StateTypeDef led_state = LED_OFF;

void led_get_status(uint8_t *state)
{
    if(state != NULL)
    {
        led_state = (LED_StateTypeDef)(*state); /* 将输入参数state转换为LED_StateTypeDef类型并赋值给led_state */
    }
    else
    {
        led_state = LED_MAX; /* 处理输入参数state为NULL的情况，可以选择返回错误码或者执行其他操作 */
    }
}
//******************************************************************************
//  File Name          : led_run
//  Description        : This function runs the LED application logic
//  Author             : MCD Application Team
//  Date               : 01-July-2016
//******************************************************************************

void led_run(void)
{
    switch (led_state)
    {
        case LED_OFF:
            led_on(LED0_INDEX);
            break;
        case LED_ON:
            led_off(LED0_INDEX);
            break;
        default:
            break;
    }
}

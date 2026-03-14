#include "sys.h"
#include "usart.h"
#include "delay.h"
#include "freertos_app.h"

void led_init(void);                       /* LED初始化函数声明 */

int main(void)
{
    HAL_Init();                              /* 初始化HAL库 */
    sys_stm32_clock_init(RCC_PLL_MUL9);      /* 设置时钟, 72Mhz */
    delay_init(72);                          /* 延时初始化 */
    led_init();                              /* LED初始化 */
    Freertos_App();                    /* 运行FreeRTOS例程 */
    while(1)
    { 

    }
}


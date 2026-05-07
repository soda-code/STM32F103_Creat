#include "./SYSTEM/sys/sys.h"
#include "./SYSTEM/usart/usart.h"
#include "./SYSTEM/delay/delay.h"
#include "./BSP/bsp_app.h"
#include "./MALLOC/malloc.h"
#include "./FATFS/fatfs_app.h"
#include "freertos_app.h"


int main(void)
{
    HAL_Init();                         /* 初始化HAL库 */
    sys_stm32_clock_init(RCC_PLL_MUL9); /* 设置时钟, 72Mhz */
    delay_init(72);                     /* 延时初始化 */
    usart_init(115200);                 /* 串口初始化为115200 */
    dma_init(DMA1_Channel4);            /* 初始化串口1 TX DMA */
    led_init();                         /* 初始化LED */
    lcd_init();                         /* 初始化LCD */
    key_init();                         /* 初始化按键 */
    Lsens_init();                       /* 初始化光敏传感器 */
    exfuns_init();                      /* 为exfuns申请内存 */
    my_mem_init(SRAMIN);                /* 初始化内部SRAM内存池 */
    freertos_app();                     /* 运行FreeRTOS例程 */
}

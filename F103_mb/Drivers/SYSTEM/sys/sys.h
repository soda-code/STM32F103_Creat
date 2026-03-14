/******************************************************************************************************
 * @file        sys.h
 * @author      F103_mb
 * @version     V1.0
 * @date        2024-06-01
 * @brief       系统相关函数的头文件
 * *****************************************************************************************************/


#ifndef __SYS_H
#define __SYS_H

#include "stm32f1xx.h"



// * SYS_SUPPORT_OS: 是否支持OS, 0, 不支持; 1, 支持
// * 如果支持OS, 则需要在delay.c中添加与OS相关的函数和宏定义来支持OS的使用, 以便在OS环境下也可以使用delay函数

#define SYS_SUPPORT_OS          1




void sys_nvic_set_vector_table(uint32_t baseaddr, uint32_t offset);             /* */
void sys_standby(void);                                                         /*  */
void sys_soft_reset(void);                                                      /*  */
uint8_t sys_clock_set(uint32_t plln);                                           /*  */
void sys_stm32_clock_init(uint32_t plln);                                       /*  */

/*  */
void sys_wfi_set(void);                                                         /*  */
void sys_intx_disable(void);                                                    /*  */
void sys_intx_enable(void);                                                     /*  */
void sys_msr_msp(uint32_t addr);                                                /*  */

#endif












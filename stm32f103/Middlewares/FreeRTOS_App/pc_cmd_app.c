#include "pc_cmd_app.h"
#include "led_app.h"

#include "./SYSTEM/usart/usart.h"

//******************************************************************************
//  File Name          : pc_cmd_run
//  Description        : This function runs the PC command task, which processes commands received from the USART interface.
//  Author             : MCD Application Team
//  Date               : 01-July-2016
// ******************************************************************************


void pc_cmd_run(void)
{
    uint8_t *pc_data = return_usart_receive_callback();
    if (pc_data != NULL)
    {
        PC_CMD_PacketTypeDef pc_cmd_packet;
        pc_cmd_packet.cmd = (PC_CMD_TypeDef)pc_data[1]; /* 假设命令数据在接收数据的第一个字节 */
    
        switch (pc_cmd_packet.cmd)
        {
            case PC_CMD_LED_CTRL:
                led_get_status(&pc_data[2]); /* 获取LED状态，假设状态数据在接收数据的第二个字节 */
                break;
        
            default:
                /* 处理未知命令 */
                break;
        }
    }

}

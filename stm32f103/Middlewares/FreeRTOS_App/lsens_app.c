#include "lsens_app.h"
#include "./BSP/LSENS/lsens.h"

//******************************************************************************
//  File Name          : lsens_on
//  Description        : 获取当前LSENS状态
//  Author             : MCD Application Team
//  Date               : 01-July-2016
//******************************************************************************
static LSENS_PacketTypeDef lsens_packet;

void lsens_on(void)
{
    lsens_packet.state = LSENS_ON;
}

//******************************************************************************
//  File Name          : lsens_off
//  Description        : 获取当前LSENS状态
//  Author             : MCD Application Team
//  Date               : 01-July-2016
//******************************************************************************
void lsens_off(void)
{
    lsens_packet.state = LSENS_OFF;
}

//******************************************************************************
//  File Name          : lsens_error
//  Description        : 获取当前LSENS状态
//  Author             : MCD Application Team
//  Date               : 01-July-2016
//******************************************************************************
void lsens_error(void)
{
    lsens_packet.state = LSENS_ERROR;
}

//******************************************************************************
//  File Name          : lsens_get_data
//  Description        : 获取数据
//  Author             : MCD Application Team
//  Date               : 01-July-2016
//******************************************************************************
void lsens_get_data(void)
{
    lsens_packet.state = LSENS_GET;
}


//******************************************************************************
//  File Name          : lsens_run
//  Description        : This function runs the LSENS application logic
//  Author             : MCD Application Team
//  Date               : 01-July-2016
//******************************************************************************

void lsens_run(void)
{
    switch (lsens_packet.state)
    {
        case LSENS_OFF:
            break;
        case LSENS_ON:
            lsens_off();
            break;
        case LSENS_ERROR:
            /* 处理错误状态的逻辑 */
            break;
        case LSENS_GET:
            lsens_packet.data = Lsens_get_lux(); /* 获取传感器数据并存储在lsens_packet.data中 */
            /* 处理获取状态的逻辑 */
            break;
        default:
            break;
    }
}

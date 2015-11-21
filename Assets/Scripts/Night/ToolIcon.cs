using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ToolIcon : Icon {

    protected bool set_reserve = false;


    void Update()
    {
        if (!set_reserve && Memory.Instance != null)
        {
            reserve = Memory.Instance.nombreOutil;

            display.GetComponent<Text>().text = reserve.ToString();
            set_reserve = true;
        }
    }


    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestTool();
    }

}

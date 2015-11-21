using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ToolIcon : Icon {

    void Start()
    {
        reserve = Memory.Instance.nombreOutil;
        display.GetComponent<Text>().text = reserve.ToString();
    }

    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestTool();
    }

}

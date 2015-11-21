using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class WallIcon : Icon
{
    void Start()
    {
        reserve = Memory.Instance.nombreMur;
        display.GetComponent<Text>().text = reserve.ToString();
    }

    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestWall();
    }
}

using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class WallIcon : Icon
{
    protected bool set_reserve = false;


    void Update()
    {
        if (!set_reserve && Memory.Instance != null)
        {
            reserve = Memory.Instance.nombreMur;

            display.GetComponent<Text>().text = reserve.ToString();
            set_reserve = true;
        }
    }


    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestWall();
    }
    protected override void UseReserve()
    {
        reserve--;
        Memory.Instance.RemoveBlocks(0, 1);
        display.GetComponent<Text>().text = reserve.ToString();
    }

    public override void AddToReserve()
    {
        Debug.Log("Add");
        reserve++;
        Memory.Instance.AddBlocks(0, 1);
        display.GetComponent<Text>().text = reserve.ToString();
    }

}

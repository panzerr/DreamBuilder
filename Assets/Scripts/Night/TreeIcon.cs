using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class TreeIcon : Icon {

    protected bool set_reserve = false;


    void Update()
    {
        if (!set_reserve && Memory.Instance != null)
        {
            reserve = Memory.Instance.nombreArbre;

            display.GetComponent<Text>().text = reserve.ToString();
            set_reserve = true;
        }
    }

    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestTree();
    }

    protected override void UseReserve()
    {
        reserve--;
        Memory.Instance.RemoveBlocks(3, 1);
        display.GetComponent<Text>().text = reserve.ToString();
    }

    public override void AddToReserve()
    {
        reserve++;
        Memory.Instance.AddBlocks(3, 1);
        display.GetComponent<Text>().text = reserve.ToString();
    }
}

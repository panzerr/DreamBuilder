using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class TreeIcon : Icon {

    void Start()
    {
        reserve = Memory.Instance.nombreArbre;
        display.GetComponent<Text>().text = reserve.ToString();
    }

    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestTree();
    }
}

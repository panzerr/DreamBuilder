using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class MonsterIcon : Icon {


    void Start()
    {
        reserve = Memory.Instance.nombreMonstre;
        display.GetComponent<Text>().text = reserve.ToString();
    }

    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestMonster();
    }
   
}

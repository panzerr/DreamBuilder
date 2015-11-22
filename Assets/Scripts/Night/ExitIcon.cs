using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class ExitIcon : Icon {

    [SerializeField]
    protected GameObject exitPrefab;

    void Start()
    {
        reserve = 1;
    }

    public override void AddToReserve()
    {    
            reserve++;
            display.GetComponent<Text>().text = reserve.ToString();     
    }

    protected override GameObject Request()
    {
        return Instantiate(exitPrefab);
    }

    protected override void UseReserve()
    {
        reserve--;
    }
}

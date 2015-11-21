using UnityEngine;
using System.Collections;
using System;

public class ExitIcon : Icon {

    [SerializeField]
    protected GameObject exitPrefab;

    protected override GameObject Request()
    {
        return Instantiate(exitPrefab);
    }



}

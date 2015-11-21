using UnityEngine;
using System.Collections;
using System;

public class TreeIcon : Icon {

    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestTree();
    }
}

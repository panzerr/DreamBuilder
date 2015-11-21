using UnityEngine;
using System.Collections;
using System;

public class WallIcon : Icon
{

    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestWall();
    }
}

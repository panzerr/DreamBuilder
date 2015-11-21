using UnityEngine;
using System.Collections;
using System;

public class ToolIcon : Icon {

    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestTool();
    }

}

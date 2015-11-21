using UnityEngine;
using System.Collections;
using System;

public class ToolPlacement : Placement {

    protected override void Give()
    {
        BlockFacotry.Instance.GiveTool(gameObject);
    }
}

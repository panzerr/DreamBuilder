using UnityEngine;
using System.Collections;
using System;

public class TreePlacement : Placement {

    protected override void Give()
    {
        BlockFacotry.Instance.GiveTree(gameObject);
    }
}

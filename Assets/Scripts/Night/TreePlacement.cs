using UnityEngine;
using System.Collections;
using System;

public class TreePlacement : Placement {

    protected override void Give()
    {
        father.AddToReserve();
        BlockFacotry.Instance.GiveTree(gameObject);
    }
}

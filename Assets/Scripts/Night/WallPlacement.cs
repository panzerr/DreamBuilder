using UnityEngine;
using System.Collections;
using System;

public class WallPlacement : Placement {


    //ajouter au decompte
    protected override void Give()
    {
        father.AddToReserve();
        BlockFacotry.Instance.GiveWall(gameObject);
    }
}

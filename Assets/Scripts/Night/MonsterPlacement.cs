using UnityEngine;
using System.Collections;
using System;

public class MonsterPlacement : Placement {

    protected override void Give()
    {
        BlockFacotry.Instance.GiveMonster(gameObject);
    }

}

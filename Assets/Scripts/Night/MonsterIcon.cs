using UnityEngine;
using System.Collections;
using System;

public class MonsterIcon : Icon {

    protected override GameObject Request()
    {
        return BlockFacotry.Instance.RequestMonster();
    }

}

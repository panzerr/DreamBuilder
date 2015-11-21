using UnityEngine;
using System.Collections;
using System;

public class MonsterPlacement : Placement {

    protected override void Give()
    {
        BlockFacotry.Instance.GiveMonster(gameObject);

    }

    public override void SetMoving(bool value)
    {
        if (!value)
            gameObject.GetComponent<MovementMonster>().setStartX(gameObject.transform.position.x);
        base.SetMoving(value);
        Debug.Log("test1");

    }

}

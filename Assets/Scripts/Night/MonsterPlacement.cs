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
        moving = value;
        gameObject.GetComponent<Behavior>().isActive = !moving;
        Color tmp = gameObject.GetComponentInChildren<SpriteRenderer>().color;
        if (moving)
            tmp.a = .5f;
        else
            tmp.a = 1f;
        gameObject.GetComponentInChildren<SpriteRenderer>().color = tmp;

    }

}

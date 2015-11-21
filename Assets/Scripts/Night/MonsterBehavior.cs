using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonsterBehavior : Behavior {

	// Use this for initialization
	void Start () {
        tests = new List<assocMoods>();
        assocMoods tmp = new assocMoods();
        tmp.value = 50; tmp.moodType = "Calm"; tmp.comparison = operations.SUP;
        tests.Add(tmp);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    protected override void Success(Collider2D coll)
    {
        coll.gameObject.GetComponent<Movement>().Pause(2);
        gameObject.GetComponent<MovementMonster>().Pause(2);
        gameObject.GetComponent<Collider2D>().enabled = false;
    }

    protected override void Fail(Collider2D coll)
    {
        if (coll.GetComponent<State>().TestValue("Empowerment",operations.SUP,50))
        {
            coll.GetComponent<State>().ModifyValue("Empowerment", 30);
            BlockFacotry.Instance.GiveMonster(gameObject);
        }
        else
        {
            coll.GetComponent<State>().ModifyValue("Empowerment", - 30);
            coll.GetComponent<State>().ModifyValue("Depression", -30);
            BlockFacotry.Instance.GiveMonster(gameObject);
        }
    }
}

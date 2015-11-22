using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/* comportement d'un mur*/

public class WallBehavior : Behavior {

    


    // Use this for initialization
    void Start () {
        /* initialisation des tests*/
        tests = new List<assocMoods>();
        assocMoods tmp = new assocMoods();
        tmp.value = 20; tmp.moodType = "Empowerment"; tmp.comparison = operations.SUP;
        tests.Add(tmp);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected override void Success(Collider2D coll)
    {
        coll.gameObject.GetComponent<State>().ModifyValue("Empowerment", 20);
        BlockFacotry.Instance.GiveWall(gameObject);
    }

    protected override void Fail(Collider2D coll)
    {
        coll.gameObject.GetComponent<State>().ModifyValue("Calm", 10);
        coll.gameObject.GetComponent<Movement>().Climb();
        isActive = false;
    }

}

using UnityEngine;
using System.Collections;

public class Icon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseDown()
    {
        Debug.Log("test");
        GameObject wall;
        wall = BlockFacotry.Instance.RequestWall();
        wall.SetActive(true);
        wall.GetComponent<Placement>().SetMoving(true);
    }

}

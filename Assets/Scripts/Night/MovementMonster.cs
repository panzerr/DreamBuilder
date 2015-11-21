using UnityEngine;
using System.Collections;

public class MovementMonster : MonoBehaviour {

    [SerializeField]
    protected float distance;
    [SerializeField]
    protected float speed;

    protected float startX;

    protected float pause = 0;
    // -1 ou 1
    protected int forward = 1;

    public void setStartX(float x)
    {
        startX = x;
        Debug.Log(startX);
    }

	// Use this for initialization
	void Start () {
        //setStartX(gameObject.transform.position.x); // TEMP  
	}
	
	// Update is called once per frame
	void Update () {
        if (pause <= 0 && Entrance.Instance.started)
            gameObject.transform.Translate(new Vector2(forward * speed / 100, 0));
        else if (pause >=0)
            pause -= Time.deltaTime;

        if ( gameObject.transform.position.x > startX + distance || gameObject.transform.position.x < startX - distance)
        {
            forward = -forward;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        // evaluation paresseuse
        if (coll.tag == "Wall" && !coll.gameObject.GetComponent<Placement>().IsMoving())
        {
            forward = -forward;
        }
   }

    public void Pause(float time)
    {
        pause = time;
    }
}

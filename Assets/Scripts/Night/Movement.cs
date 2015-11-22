using UnityEngine;
using System.Collections;

/*classe generale pour le deplacement de nuit */

public class Movement : MonoBehaviour {

    [SerializeField]
    protected float speed; // vitesse laterale, negative pour gauche on la divise par 100 pour avoir plus de marge

    protected int isClimbing;
    protected bool ignorereenter = false;
    protected bool ignoreexit = false;
    protected float pause = 0;

    Collider2D currentWall;

    protected int direction = 0;

	// Use this for initialization
	void Start () {
        currentWall = new Collider2D();
	}



    // Update is called once per frame
    void Update()
    {
        if (pause <= 0)
            transform.Translate(Direction());
        else
        {
            pause -= Time.deltaTime;
            if (pause <= 0)
                GetComponentInChildren<Animator>().SetBool("Marche", true);
        }
    }


    protected Vector2 Direction()
    {
        if (direction == 0)
        { return new Vector2(speed / 100, 0); }
        if (direction == 1)
        { return new Vector2(0, speed / 100); }
        if (direction == 2)
        { return new Vector2(-2*speed / 100, 0); }
            return new Vector2(0, -speed / 100); 

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("enter");
        if (coll.tag == "Ground")
        {
            direction = 0;
            ignoreexit = true;
            isClimbing = 0;
            transform.rotation = new Quaternion(0, 0, 0 , 0);
        }
        if (coll.tag == "Wall" && ! ignorereenter && isClimbing == 1 )
        {
            direction = direction + 1 % 4;
            //transform.Rotate(new Vector3(0, 0, 90));
            currentWall = coll;
        }
        else
        {
            ignorereenter = false;

        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        Debug.Log("exit");
        if (coll.tag == "Wall" && coll == currentWall && !ignoreexit)
        {
            ignorereenter = true;
            //transform.Rotate(new Vector3(0, 0, -90));
            transform.Translate(-2 * Direction());
            direction = direction - 1 % 4;
        }
        else
            ignoreexit = false;
    }

    //fait grimper
    public void Climb()
    {
        isClimbing = 1;

    }

    //fait s'arreter
    public void Pause(float time)
    {
        pause = time;
        GetComponentInChildren<Animator>().SetBool("Marche", false);
    }

}

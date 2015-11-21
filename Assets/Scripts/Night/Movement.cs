using UnityEngine;
using System.Collections;

/*classe generale pour le deplacement de nuit */

public class Movement : MonoBehaviour {

    [SerializeField]
    protected float speed; // vitesse laterale, negative pour gauche on la divise par 100 pour avoir plus de marge

    protected int isClimbing;

    protected float pause = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        /* TODO faire ca mieux pour le climb */
        if (isClimbing >= 0)
        {
            if (pause >= 0)
            { pause -= Time.deltaTime; }
            else
            {
                if (isClimbing >= 60)
                    transform.Translate(new Vector2(0, speed / 100));
                else if (isClimbing >= 30)
                    transform.Translate(new Vector2(speed / 100, 0));
                else
                    transform.Translate(new Vector2(0, -speed / 100));
                isClimbing--;
            }
        }


        else // deplacement normal
        {
            if (pause <= 0)
                transform.Translate(new Vector2(speed / 100, 0));
            else
                pause -= Time.deltaTime;
        }
        }
   
    //fait grimper
    public void Climb()
    {
        isClimbing = 90;

    }

    //fait s'arreter
    public void Pause(float time)
    {
        pause = time;
    }

}

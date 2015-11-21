using UnityEngine;
using System.Collections;

/*classe generale pour le deplacement de nuit */

public class Movement : MonoBehaviour {

    [SerializeField]
    protected float speed; // vitesse laterale, negative pour gauche on la divise par 100 pour avoir plus de marge

    protected int isClimbing;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        /* TODO faire ca mieux pour le climb */
        if (isClimbing >=0)
        {
            if (isClimbing >= 60)
                transform.Translate(new Vector2(0, speed / 100));
            else if(isClimbing >= 30)
                transform.Translate(new Vector2(speed / 100, 0));
            else
                transform.Translate(new Vector2(0, - speed / 100));
            isClimbing--;
        }
        else // deplacement normal
            transform.Translate(new Vector2(speed/100, 0));
	}
   
    public void Climb()
    {
        isClimbing = 90;

    }

}

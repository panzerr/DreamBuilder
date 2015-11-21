using UnityEngine;
using System.Collections;

/*classe generale pour le deplacement de nuit */

public class Movement : MonoBehaviour {

    [SerializeField]
    protected float speed; // vitesse laterale, negative pour gauche on la divise par 100 pour avoir plus de marge

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(speed/100, 0));
	}

}

using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

    [SerializeField]
    protected float limitUpX;
    [SerializeField]
    protected float limitDownX;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!(Input.GetAxis("Horizontal") >= 0 && transform.position.x >= limitUpX) && !(Input.GetAxis("Horizontal") <= 0 && transform.position.x <= limitDownX))
        transform.Translate(new Vector2(Input.GetAxis("Horizontal"), 0));
	}
}

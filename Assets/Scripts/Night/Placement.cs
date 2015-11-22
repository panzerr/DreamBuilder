using UnityEngine;
using System.Collections;

public abstract class Placement : MonoBehaviour
{

    // si le joueur est en train de placer le block
    protected bool moving;
    protected bool placable = false;
    protected Icon father;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition); ;
        pos.z = 0;
        if (moving)
            this.transform.position = pos;
    }

    public virtual void SetMoving(bool value)
    {
        moving = value;
        gameObject.GetComponent<Behavior>().isActive = !moving;
        Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
        if (moving)
            tmp.a = .5f;
        else
            tmp.a = 1f;
        gameObject.GetComponent<SpriteRenderer>().color = tmp;
    }

    void OnMouseUp()
    {
        // c'est ici qu'on regarde si on est dans le sol
        if (placable && gameObject.transform.position.y > -8)
        {
            SetMoving(false);

        }
        // pas une super solution mais on a pas le temps
        else if (this.transform.position.x <= father.transform.position.x + 1 && this.transform.position.x >= father.transform.position.x - 1 && this.transform.position.y <= father.transform.position.y + 1 && this.transform.position.y >= father.transform.position.y - 1)
            Give();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        placable = false;
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        placable = true;
    }

    protected abstract void Give();


    public void SetFather(Icon f)
    {
        father = f;
    }

    public bool IsMoving()
    {
        return moving;
    }



}


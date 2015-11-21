using UnityEngine;
using System.Collections;

public abstract class Icon : MonoBehaviour {

    void OnMouseDown()
    {
        GameObject obj;
        obj = Request();
        obj.SetActive(true);
        obj.GetComponent<Placement>().SetMoving(true);
        obj.GetComponent<Placement>().SetFather(this);
    }

    protected abstract GameObject Request(); 


}

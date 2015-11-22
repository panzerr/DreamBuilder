using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class Icon : MonoBehaviour
{

    protected int reserve = 0;

    [SerializeField]
    protected GameObject display;


    void OnMouseDown()
    {
        if (reserve > 0)
        {
            GameObject obj;
            obj = Request();
            obj.SetActive(true);
            obj.GetComponent<Placement>().SetMoving(true);
            obj.GetComponent<Placement>().SetFather(this);
            UseReserve();
            display.GetComponent<Text>().text = reserve.ToString();
        }
    }

    protected abstract GameObject Request();
    protected abstract void UseReserve();
    public abstract void AddToReserve();

}

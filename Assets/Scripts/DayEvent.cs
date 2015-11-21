using UnityEngine;
using System.Collections;

public class DayEvent : MonoBehaviour
{
    public static DayEvent instance;

    // Use this for initialization
    void Start()
    {
        GameManager.Instance.AddToDayEventList(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

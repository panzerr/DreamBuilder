using UnityEngine;
using System.Collections;

public class FirstDay : DayEvent
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayDay()
    {
        Memory.Instance.DayIncrement();
        Application.LoadLevel(1);
    }
}

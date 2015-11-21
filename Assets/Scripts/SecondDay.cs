using UnityEngine;
using System.Collections;

public class SecondDay : DayEvent
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Retard()
    {

    }

    public void Depressif()
    {


        Memory.Instance.AddBlocks(0, 2);
    }

    public void FaireSonLit()
    {


        Memory.Instance.AddBlocks(3, 1);
    }

    public void DefaultReveil()
    {


        Memory.Instance.AddBlocks(2, 1);
    }

    public void Engueule()
    {


        Memory.Instance.AddBlocks(1, 2);
        Memory.Instance.AddBlocks(0, 1);
    }

    public void Travail()
    {


        Memory.Instance.AddBlocks(0, 2);
    }

    public void DormirApresEngueule()
    {


        Memory.Instance.AddBlocks(2, 1);
    }

    public void Vaisselle()
    {


        Memory.Instance.AddBlocks(3, 1);
        Memory.Instance.AddBlocks(0, 1);
    }

    public void Endors()
    {


        Memory.Instance.AddBlocks(1, 1);
        Memory.Instance.AddBlocks(2, 1);
    }

    public void Bisou()
    {


        Memory.Instance.AddBlocks(3, 1);
    }

    public void Nothing()
    {


        Memory.Instance.AddBlocks(1, 1);
    }
}

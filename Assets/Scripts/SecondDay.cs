using UnityEngine;
using System.Collections;

public class SecondDay : DayEvent
{
    [SerializeField]
    protected GameObject decorReveil;
    [SerializeField]
    protected GameObject decorTravail;
    [SerializeField]
    protected GameObject decorCopine;
    [SerializeField]
    protected GameObject decorChezsoi;
    [SerializeField]
    private float timer = 5;
    [SerializeField]
    private float timerState;
    private bool premiereIteration = false;
    private GameObject decor;

    // Use this for initialization
    void Start()
    {
        timerState = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerState >= 0.01)
            timerState -= Time.deltaTime;
        if (timerState <= 0.01)
        {
            if (premiereIteration)
            {
                Destroy(decor);
                GameManager.Instance.SceneSuivante();
            }
        }
    }

    public void Retard()
    {
        decor = Instantiate(decorReveil);
        timerState = timer;
        premiereIteration = true;
    }

    public void Depressif()
    {
        decor = Instantiate(decorReveil);
        Memory.Instance.AddBlocks(0, 2);
        timerState = timer;
        premiereIteration = true;
    }

    public void FaireSonLit()
    {
        decor = Instantiate(decorReveil);
        Memory.Instance.AddBlocks(3, 1);
        timerState = timer;
        premiereIteration = true;
    }

    public void DefaultReveil()
    {
        decor = Instantiate(decorReveil);
        Memory.Instance.AddBlocks(2, 1);
        timerState = timer;
        premiereIteration = true;
    }

    public void Engueule()
    {
        decor = Instantiate(decorTravail);
        GameManager.Instance.Engueule();
        Memory.Instance.AddBlocks(1, 2);
        Memory.Instance.AddBlocks(0, 1);
        timerState = timer;
        premiereIteration = true;
    }

    public void Travail()
    {
        decor = Instantiate(decorTravail);
        Memory.Instance.AddBlocks(0, 2);
        timerState = timer;
        premiereIteration = true;
    }

    public void DormirApresEngueule()
    {
        decor = Instantiate(decorChezsoi);
        Memory.Instance.AddBlocks(2, 1);
        timerState = timer;
        premiereIteration = true;
    }

    public void Vaisselle()
    {
        decor = Instantiate(decorChezsoi);
        Memory.Instance.AddBlocks(3, 1);
        Memory.Instance.AddBlocks(0, 1);
        timerState = timer;
        premiereIteration = true;
    }

    public void Endors()
    {
        decor = Instantiate(decorCopine);
        Memory.Instance.AddBlocks(1, 1);
        Memory.Instance.AddBlocks(2, 1);
        timerState = timer;
        premiereIteration = true;
    }

    public void Bisou()
    {
        decor = Instantiate(decorCopine);
        Memory.Instance.AddBlocks(3, 1);
        timerState = timer;
        premiereIteration = true;
    }

    public void Nothing()
    {
        decor = Instantiate(decorCopine);
        Memory.Instance.AddBlocks(1, 1);
        timerState = timer;
        premiereIteration = true;
    }
}

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
    private float timerState;

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
    }

    public void Retard()
    {
        GameObject decor;
        decor = Instantiate(decorReveil);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
        }
    }

    public void Depressif()
    {
        GameObject decor;
        decor = Instantiate(decorReveil);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
            Memory.Instance.AddBlocks(0, 2);
        }
    }

    public void FaireSonLit()
    {
        GameObject decor;
        decor = Instantiate(decorReveil);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
            Memory.Instance.AddBlocks(3, 1);
        }
    }

    public void DefaultReveil()
    {
        GameObject decor;
        decor = Instantiate(decorReveil);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
            Memory.Instance.AddBlocks(2, 1);
        }
    }

    public void Engueule()
    {
        GameObject decor;
        decor = Instantiate(decorTravail);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
            GameManager.Instance.Engueule();
            Memory.Instance.AddBlocks(1, 2);
            Memory.Instance.AddBlocks(0, 1);
        }
    }

    public void Travail()
    {
        GameObject decor;
        decor = Instantiate(decorTravail);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
            Memory.Instance.AddBlocks(0, 2);
        }
    }

    public void DormirApresEngueule()
    {
        GameObject decor;
        decor = Instantiate(decorChezsoi);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
            Memory.Instance.AddBlocks(2, 1);
        }
    }

    public void Vaisselle()
    {
        GameObject decor;
        decor = Instantiate(decorChezsoi);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
            Memory.Instance.AddBlocks(3, 1);
            Memory.Instance.AddBlocks(0, 1);
        }
    }

    public void Endors()
    {
        GameObject decor;
        decor = Instantiate(decorCopine);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
            Memory.Instance.AddBlocks(1, 1);
            Memory.Instance.AddBlocks(2, 1);
        }
    }

    public void Bisou()
    {
        GameObject decor;
        decor = Instantiate(decorCopine);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
            Memory.Instance.AddBlocks(3, 1);
        }
    }

    public void Nothing()
    {
        GameObject decor;
        decor = Instantiate(decorCopine);
        timerState = timer;
        if (timerState <= -0.01)
        {
            Destroy(decor);
            GameManager.Instance.SceneSuivante();
            Memory.Instance.AddBlocks(1, 1);
        }
    }
}

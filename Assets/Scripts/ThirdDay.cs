using UnityEngine;
using System.Collections;

public class ThirdDay : DayEvent
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
    private int end = 5;

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
            if (premiereIteration && end == 5)
            {
                Destroy(decor);
                GameManager.Instance.SceneSuivante();
            }
            else if (premiereIteration && end == 0)
            {
                Destroy(decor);
                GameManager.Instance.SceneRunningFalse();
                GameManager.Instance.GameFinished(0);
            }
            else if (premiereIteration && end == 1)
            {
                Destroy(decor);
                GameManager.Instance.SceneRunningFalse();
                GameManager.Instance.GameFinished(1);
            }
            else if (premiereIteration && end == 2)
            {
                Destroy(decor);
                GameManager.Instance.SceneRunningFalse();
                GameManager.Instance.GameFinished(2);
            }
            else if (premiereIteration && end == 3)
            {
                Destroy(decor);
                GameManager.Instance.SceneRunningFalse();
                GameManager.Instance.GameFinished(3);
            }
        }
    }

    public void Retard()
    {
        decor = Instantiate(decorReveil);
        timerState = timer;
        premiereIteration = true;
    }

    public void Rien()
    {
        decor = Instantiate(decorReveil);
        timerState = timer;
        premiereIteration = true;
    }

    public void Engueule2()
    {
        decor = Instantiate(decorTravail);
        timerState = timer;
        premiereIteration = true;
    }

    public void Travaille()
    {
        decor = Instantiate(decorTravail);
        timerState = timer;
        premiereIteration = true;
    }

    public void Conquerir()
    {
        decor = Instantiate(decorChezsoi);
        timerState = timer;
        premiereIteration = true;
        end = 0;
    }

    public void Copine2()
    {
        decor = Instantiate(decorCopine);
        timerState = timer;
        premiereIteration = true;
        end = 1;
    }

    public void Depression()
    {
        decor = Instantiate(decorChezsoi);
        timerState = timer;
        premiereIteration = true;
        end = 2;
    }

    public void Nothing()
    {
        decor = Instantiate(decorChezsoi);
        timerState = timer;
        premiereIteration = true;
        end = 3;
    }
}

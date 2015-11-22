using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    protected Hashtable statistics;         // Stats récupérées dans Memory
    protected List<string> statNames;       // Nom des stats récupérés dans Memory
    protected int day;
    public static GameManager instance;
    private int i;
    protected FirstDay firstDay;
    protected SecondDay secondDay;
    protected ThirdDay thirdDay;
    private int indiceJournee = 0;
    private bool engueule = false;
    private bool initiated = false;
    private bool sceneRunning = false;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Memory.Instance != null && !initiated)
        {
            Init();
            initiated = true;
        }

        if (day == 2 && initiated && !sceneRunning)
        {
            // First period
            if ((int)statistics[statNames[3]] < -50 && indiceJournee == 0)
                secondDay.Retard();
            else if ((int)statistics[statNames[2]] > 50 && indiceJournee == 0)
                secondDay.Depressif();
            else if ((int)statistics[statNames[1]] > 50 && indiceJournee == 0)
                secondDay.FaireSonLit();
            else if (indiceJournee == 0)
                secondDay.DefaultReveil();

            // Second period
            if ((int)statistics[statNames[0]] > 50 && (int)statistics[statNames[1]] < 50 && indiceJournee == 1)
                secondDay.Engueule();
            else if (indiceJournee == 1)
                secondDay.Travail();

            // Third Period après Engueule
            if (engueule && (int)statistics[statNames[2]] > 50 && indiceJournee == 2)
                secondDay.DormirApresEngueule();
            else if (engueule && indiceJournee == 2)
                secondDay.Vaisselle();

            // Third Period après Travail
            if (!engueule && (int)statistics[statNames[3]] > 50 && indiceJournee == 2)
                secondDay.Endors();
            else if (!engueule && (int)statistics[statNames[1]] > 50 && indiceJournee == 2)
                secondDay.Bisou();
            else if (!engueule && indiceJournee == 2)
                secondDay.Nothing();

            sceneRunning = true;
        }
        /*else if (initiated)
        {
            statistics = Memory.Instance.GetStatistics();
            statNames = Memory.Instance.GetStatNames();
            thirdDay = gameObject.GetComponent<ThirdDay>();


            Application.LoadLevel(1);
        }*/
    }

    public void SceneSuivante()
    {
        indiceJournee += 1;
        if (indiceJournee == 3)
            Application.LoadLevel(1);
        sceneRunning = false;
    }

    public bool Engueule()
    {
        return true;
    }

    public void Init()
    {
        day = Memory.Instance.GetDay();
        day = 2;
        if (day == 1)
        {
            firstDay = gameObject.GetComponent<FirstDay>();
            firstDay.PlayDay();
        }
        else if (day == 2)
        {
            statistics = Memory.Instance.GetStatistics();
            statNames = Memory.Instance.GetStatNames();
            secondDay = gameObject.GetComponent<SecondDay>();
        }
        else
        {
            statistics = Memory.Instance.GetStatistics();
            statNames = Memory.Instance.GetStatNames();
            thirdDay = gameObject.GetComponent<ThirdDay>();
        }
    }
}
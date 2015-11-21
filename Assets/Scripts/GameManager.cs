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
        day = Memory.Instance.GetDay();
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

            // First period
            if ((int)statistics[statNames[3]] < -50)
                secondDay.Retard();
            else if ((int)statistics[statNames[2]] > 50)
                secondDay.Depressif();
            else if ((int)statistics[statNames[1]] > 50)
                secondDay.FaireSonLit();
            else
                secondDay.DefaultReveil();

            // Second period
            if ((int)statistics[statNames[0]] > 50 && (int)statistics[statNames[1]] < 50)
                secondDay.Engueule();
            else
                secondDay.Travail();

            // Third Period après Engueule
            if ((int)statistics[statNames[2]] > 50)
                secondDay.DormirApresEngueule();
            else
                secondDay.Vaisselle();

            // Third Period après Travail
            if ((int)statistics[statNames[3]] > 50)
                secondDay.Endors();
            else if ((int)statistics[statNames[1]] > 50)
                secondDay.Bisou();
            else
                secondDay.Nothing();

            Application.LoadLevel(1);
        }
        else
        {
            statistics = Memory.Instance.GetStatistics();
            statNames = Memory.Instance.GetStatNames();
            thirdDay = gameObject.GetComponent<ThirdDay>();


            Application.LoadLevel(1);
        }
    }
}
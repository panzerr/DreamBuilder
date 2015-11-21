using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    protected List<DayEvent> dayEventList;  // Liste des dayEvent à jouer jusqu'à l'appel de la scène Night suivante
    protected DayEvent dayEvent;
    protected Hashtable statistics;         // Stats récupérées dans Memory
    protected List<string> statNames;       // Nom des stats récupérés dans Memory
    public static GameManager instance;
    private int i;

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
        statistics = Memory.Instance.GetStatistics();
        statNames = Memory.Instance.GetStatNames();
        for (i = 0; i < statNames.Count; i++)
        {
            // TODO : REMPLIR EN DUR LES dayEvent A JOUER
        }
        OnDayEventFinished(); // Premier dayEvent du jour
    }
    
    void OnDayEventFinished()
    {
        if (dayEventList.Count == 0)
        {
            // TODO : INDEXER LA SCENE
            //Application.LoadLevel(2);
        }
        else
        {
            dayEvent = dayEventList[dayEventList.Count - 1];
            dayEventList.Remove(dayEvent);
            // TODO : LAUNCH dayEvent
        }
    }

    public void AddToDayEventList(DayEvent dayEventToAdd)
    {
        dayEventList.Add(dayEventToAdd);
    }
}

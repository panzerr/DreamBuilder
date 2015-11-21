﻿using UnityEngine;
using System.Collections;

public class State : MonoBehaviour {

    /* Dictionnaires des etats d'esprit du joueur */
    protected Hashtable moods;
    
    // on en aura besoin un jour
    public bool hasTool = false;

    [SerializeField]
    protected int lives = 3;

    public Hashtable GetMoods()
    {
        return moods;
    }

	// Use this for initialization
	void Start () {
        moods = new Hashtable();
        moods = Memory.Instance.GetStatistics();
        moods["Calm"] = 100;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    /* test une valeur de mood */
    public bool TestValue(string name,operations type, int value)
    {
        Debug.Log("testing " + name + " " + type + " " + value);
        if (type == operations.SUP) 
            return ((int)moods[name] >= value);
        else
           return ((int)moods[name] <= value);
    }

    /* ajoute a une mood */
    public void ModifyValue(string name, int value)
    {
        moods[name] = (int)moods[name] + value;
        if ((int)moods[name] >= 100)
            moods[name] = 100;
        if ((int)moods[name] <= -100)
            moods[name] = -100;
        Debug.Log(name + "=" + moods[name]);
    }

    public void GrabTool()
    {
        if (!hasTool)
        {
            hasTool = true;
            ModifyValue("Empowerment", 20);
        }
    }

    public void TakeDmg()
    {
        lives--;
        if (lives == 0) ;

    }

}

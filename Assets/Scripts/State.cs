using UnityEngine;
using System.Collections;

public class State : MonoBehaviour {

    /* Dictionnaires des etats d'esprit du joueur */
    protected Hashtable moods;
    


	// Use this for initialization
	void Start () {
        moods = new Hashtable();
        /*TODO : recuperer la hashtable du gamemanager */
        moods["Empowerment"] = 10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /* test une valeur de mood */
    public bool TestValue(string name,operations type, int value)
    {
        if (type == operations.SUP) 
            return ((int)moods[name] >= value);
        else
           return ((int)moods[name] <= value);
    }

    /* ajoute a une mood */
    public void ModifyValue(string name, int value)
    {
        moods[name] = (int)moods[name] + value;
    }

}

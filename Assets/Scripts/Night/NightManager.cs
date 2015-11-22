using UnityEngine;
using System.Collections;


public class NightManager : MonoBehaviour
{

    [SerializeField]
    protected float Timer;

    protected GameObject perso;

    public static NightManager instance;

    public static NightManager Instance
    {
        get { return instance; }
    }

    // Use this for initialization
    void Start()
    {
        if (instance == null)
            instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        if (Entrance.Instance.started)
          Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            perso.GetComponent<State>().ModifyValue("Fatigue", -50);
            End(perso);
        }
    }

    public void setPerso(GameObject p)
    {
        perso = p;
    }

    public void End(GameObject coll)
    {
        Memory.Instance.SetStatistics(coll.GetComponent<State>().GetMoods());
        Destroy(coll);
        Application.LoadLevel(0);
    }

}

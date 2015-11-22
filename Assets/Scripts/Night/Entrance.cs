using UnityEngine;
using System.Collections;

public class Entrance : MonoBehaviour {

    [SerializeField]
    protected GameObject character;

    public static Entrance instance;

    public static Entrance Instance
    { get { return instance; }
     }

    public bool started = false;

    void Start()
    {
        instance = this;
    }

    public void Launch()
    {
        if (!started)
        {
            Instantiate(character,this.transform.position,new Quaternion());
            started = true;
        }
    }
    
}

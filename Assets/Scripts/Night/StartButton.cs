using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

   void OnMouseDown()
    {
        Entrance.Instance.Launch();
        Destroy(gameObject);
    }
    
}

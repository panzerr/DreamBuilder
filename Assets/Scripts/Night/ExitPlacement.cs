using UnityEngine;
using System.Collections;
using System;

public class ExitPlacement : Placement
{
    protected override void Give()
    {
        Destroy(gameObject);
    }
}

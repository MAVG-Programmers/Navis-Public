using UnityEngine;
using System.Collections;

public class Positioning : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public string comparePosition(Transform object1, Transform object2)
    {
        string side = "";

        Vector3 relPoint = object1.InverseTransformPoint(object2.position);

        if (relPoint.x < 0)
            side = "Left";
        if (relPoint.x > 0)
            side = "Right";
        if (relPoint.y < 0)
            side = "Above";
        if (relPoint.x > 0)
            side = "Below";

        return side;
    }
}

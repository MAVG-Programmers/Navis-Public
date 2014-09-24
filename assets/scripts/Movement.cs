using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
    public float speed;

    public Transform target { get; set; }

    Positioning comparing;

	// Use this for initialization
	void Start () 
    {
        comparing = gameObject.GetComponent<Positioning>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void MoveToTarget()
    {
        if(comparing.comparePosition(this.transform, target) == "Left")
        {
            while(this.transform.position.x != target.position.x)
            {
                rigidbody2D.AddForce(Vector2.right * speed);
            }

        }
        if (comparing.comparePosition(this.transform, target) == "Right")
        {
            while (this.transform.position.x != target.position.x)
            {
                rigidbody2D.AddForce(Vector2.right * speed * -1);
            }

        }
        if (comparing.comparePosition(this.transform, target) == "Above")
        {
            while (this.transform.position.y != target.position.y)
            {
                rigidbody2D.AddForce(Vector2.up * speed * -1);
            }

        }
        if (comparing.comparePosition(this.transform, target) == "Below")
        {
            while (this.transform.position.y != target.position.y)
            {
                rigidbody2D.AddForce(Vector2.up * speed);
            }

        }
    }
}

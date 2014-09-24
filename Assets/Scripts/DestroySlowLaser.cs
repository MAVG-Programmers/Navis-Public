using UnityEngine;
using System.Collections;

public class DestroySlowLaser : MonoBehaviour 
{
    private float verticalBulletSpeed;
    private float horizontalBulletSpeed;

    private float currentVerticalBulletSpeed;
    private float currentHorizontalBulletSpeed;

	// Use this for initialization
	void Start () 
    {
        verticalBulletSpeed = rigidbody2D.velocity.y;
        horizontalBulletSpeed = rigidbody2D.velocity.x;

        if (verticalBulletSpeed < 0)
        {
            verticalBulletSpeed *= -1;
        }
        if (horizontalBulletSpeed < 0)
        {
            horizontalBulletSpeed *= -1;
        }

        horizontalBulletSpeed--;
        verticalBulletSpeed--;
	}
	
	// Update is called once per frame
	void Update () 
    {
        currentVerticalBulletSpeed = rigidbody2D.velocity.y;
        currentHorizontalBulletSpeed = rigidbody2D.velocity.x;

        if (currentVerticalBulletSpeed < 0)
        {
            currentVerticalBulletSpeed *= -1;
        }
        if(currentHorizontalBulletSpeed < 0)
        {
            currentHorizontalBulletSpeed *= -1;
        }

        if (currentVerticalBulletSpeed < verticalBulletSpeed || currentHorizontalBulletSpeed < horizontalBulletSpeed)
        {
            Debug.Log("Destroyed");
            Destroy(gameObject);
        }
	}
}

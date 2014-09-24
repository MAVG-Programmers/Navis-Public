using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{

    public float speed;
	public float maxDistance = 2000f;

	void Start () 
    {

	}
	

	void FixedUpdate () 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rigidbody2D.velocity = movement * speed;

    }

    Vector3 mousePosition;

    void Update()
    {
        mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

		object[] objects = GameObject.FindObjectsOfType(typeof (GameObject));
		
		foreach (GameObject obj in objects) {
			if((obj.transform.position - this.transform.position).magnitude > maxDistance)
			{
				Destroy (obj);
			}
		}
    }
}

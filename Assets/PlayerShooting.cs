using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public float cannonFireRate = 1.5f;
    public float missileFireRate = 5f;
    public float positionOffset = 1.0f;
    public float bulletSpeed = 10.0f;
    public float missileSpeed = 10.0f;

    float laserTimer;
    float missileTimer;

    public AudioClip laserSound;

    AudioPlayer player;

	// Use this for initialization
	void Start () 
    {
		laserTimer = 0.0f;

        player = gameObject.AddComponent<AudioPlayer>();
	}
	

	void Update ()
    {

		laserTimer += Time.deltaTime;

		if (Input.GetKey (KeyCode.Space) && laserTimer > cannonFireRate) 
		{
			GameObject bullet = (GameObject) Instantiate (Resources.Load ("GLaser"), 
			                                              transform.position + transform.up * positionOffset, 
			                                              transform.rotation);		

			bullet.rigidbody2D.velocity = bulletSpeed * transform.up;
			bullet.rigidbody2D.drag = 0.0f;

            player.PlayClip(laserSound);

			laserTimer = 0.0f;
		}
	}
}

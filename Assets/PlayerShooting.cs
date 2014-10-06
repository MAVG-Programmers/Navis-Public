using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public float laserFireRate = 1.5f;
    public float missileFireRate = 2f;
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

		if (Input.GetKey (KeyCode.Space) && laserTimer > laserFireRate) 
		{
			GameObject bullet = (GameObject) Instantiate (Resources.Load ("GLaser"), 
			                                              transform.position + transform.up * positionOffset, 
			                                              transform.rotation);		

			bullet.rigidbody2D.velocity = bulletSpeed * transform.up;
			bullet.rigidbody2D.drag = 0.0f;

            player.PlayClip(laserSound);

			laserTimer = 0.0f;
		}

        missileTimer += Time.deltaTime;

        if (Input.GetKey(KeyCode.M) && missileTimer > missileFireRate)
        {
            GameObject missile = (GameObject)Instantiate(Resources.Load("HomingMissle"),
                                                          transform.position + transform.up * positionOffset,
                                                          transform.rotation);

            missile.rigidbody2D.velocity = missileSpeed * transform.up;
            missile.rigidbody2D.drag = 0.0f; 

            missileTimer = 0.0f;
        }
	}
}

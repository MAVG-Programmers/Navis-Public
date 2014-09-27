using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    //public float playerHorizontalSpeed = 4.0f;
    //public float playerVerticalSpeed = 4.0f;
    public float playerSpeed = 4.0f;
    public float maxDistance = 50;

    AudioPlayer player;

    AudioSource source;

    public AudioClip engineSound;

    void Start()
    {
        player = gameObject.AddComponent<AudioPlayer>();
        source = player.PlaySource(engineSound, false);
    }


    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            PlayEngine();
            rigidbody2D.AddForce(Vector2.up * playerSpeed);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            PlayEngine();
            rigidbody2D.AddForce(Vector2.up * playerSpeed * -1);

        }

        if (Input.GetKey(KeyCode.A))
        {
            PlayEngine();
            rigidbody2D.AddForce(Vector2.right * playerSpeed * -1);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            PlayEngine();
            rigidbody2D.AddForce(Vector2.right * playerSpeed);

        }

        Debug.Log(source.isPlaying);

        //if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) && source.isPlaying)
        //{
        //    source.Stop();
        //}
    }

    void PlayEngine()
    {
        if (!source.isPlaying)
        {
            source.Play();
        }
        
    }

    Vector3 mousePosition;

    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);


        destroyObjects();

    }

    void destroyObjects()
    {

        object[] objects = GameObject.FindObjectsOfType(typeof(GameObject));

        foreach (GameObject obj in objects)
        {
            if ((obj.transform.position - this.transform.position).magnitude > maxDistance)
            {
                Destroy(obj);
            }
        }

    }

}
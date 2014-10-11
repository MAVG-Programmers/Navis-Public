using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour 
{
    public GameObject[] backgrounds;

    public int rows;
    public int columns;

	// Use this for initialization
	void Start () 
    {
        StartCoroutine("AddBackground", 1);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    IEnumerator AddBackground(float seconds)
    {
        int i = 0;

        int row = 0;
        int column = 0;

        float xPos = gameObject.transform.position.x;
        float yPos = gameObject.transform.position.y;

        yield return new WaitForSeconds(seconds);
        
        do
        {
            Instantiate(backgrounds[i], new Vector3(xPos, yPos), Quaternion.identity);

            if (column != columns)
            {
                xPos += backgrounds[i].renderer.bounds.size.x;
                column++;
            }
            if (column == columns)
            {
                yPos -= backgrounds[i].renderer.bounds.size.y;

                xPos = gameObject.transform.position.x;

                column = 0;
                row++;
            }

            

            if(i == backgrounds.Length - 1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
        }
        while (row != rows && column != columns);
    }


}

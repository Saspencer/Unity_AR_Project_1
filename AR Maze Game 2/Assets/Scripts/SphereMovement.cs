using UnityEngine;
using System.Collections;

public class SphereMovement : MonoBehaviour 
{
    public GameObject plane;
    public GameObject spawnPoint;
	
	void Start () 
    {
        //transform.position = spawnPoint.transform.position;
	}
	
	
	void Update () 
    {
	    if(transform.position.y < plane.transform.position.y - 10)
        {
            transform.position = spawnPoint.transform.position;
        }
	}
}

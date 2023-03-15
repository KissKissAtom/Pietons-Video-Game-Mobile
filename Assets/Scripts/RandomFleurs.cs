using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFleurs : MonoBehaviour
{
	public GameObject fleursSpawn;
	public int xPos;
	public int zPos;
	public int flowerCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DropFlower());
    }

    // Update is called once per frame
    IEnumerator DropFlower()
    {
        while (flowerCount < 2)
        {
        	xPos = Random.Range(-15,3);
        	zPos = Random.Range(-5,5);
        	Instantiate(fleursSpawn, new Vector3(xPos,0,zPos), Quaternion.Euler(-90,0,108));
        	yield return new WaitForSeconds(0.1f);
        	flowerCount +=1;
        }
    }
}

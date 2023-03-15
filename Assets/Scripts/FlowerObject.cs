using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerObject : MonoBehaviour
{
    public GameObject fleursSpawn;
    public int xPos;
    public int zPos;
    public int flowerCount = 0;
	public GameObject fleurs;
	//public static int nbrFlower = 0;
	//RandomFleurs randomFleurs;
    // Start is called before the first frame update
    void Start()
    {
       // randomFleurs = GetComponent<RandomFleurs>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Perso")
        {
            xPos = Random.Range(-15,0);
            zPos = Random.Range(-5,0);
            Instantiate(fleursSpawn, new Vector3(xPos,0,zPos), Quaternion.Euler(-90,0,108));
        	Destroy(fleurs);
        	//nbrFlower +=1;  
            //randomFLeurs.flowerCount -=1;
        }
    }
}

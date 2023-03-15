using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CollisionMesh : MonoBehaviour
{
    public GameObject Rejouer;
    public Text score;
    public Text scoreInGame;
    //public FlowerObject flowerObject;
    public  int nbrFlower = 0;   
    public static bool GameIsPause = false;
    public Text pointsRecord;

    void Awake(){
        pointsRecord.text = PlayerPrefs.GetInt("PointsRecord",0).ToString();
       // Debug.Log("hello");
    }

    void DestructionObjet()
    {
      Rejouer.SetActive(true);
     Time.timeScale = 0f;
        GameIsPause = true;
        if(nbrFlower > PlayerPrefs.GetInt("PointsRecord",0)){
         PlayerPrefs.SetInt("PointsRecord",nbrFlower);
        PlayerPrefs.Save();
        }
        //Debug.Log(pointsRecord);
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Enemy")
        {
        DestructionObjet();
        //nbrFlower = 0;
         
    }
    else if(col.gameObject.tag == "Fleurs")
    {
    	nbrFlower +=1;
        score.text = nbrFlower.ToString() + " Fleurs";
        scoreInGame.text = nbrFlower.ToString() + " Fleurs";

        
    }

    }
}

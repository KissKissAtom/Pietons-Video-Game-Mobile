using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start_Btn : MonoBehaviour
{

  public static bool GameIsPause = true;
  //private int index;
    // Start is called before the first frame update
  
 public  InputField Pseudo;
 // public int numeroPersonnage;
 

  void Start(){
   
      
  }

  public void StartButton(){
      //PlayerPrefs.SetInt("PersonnageSelectionne",numeroPersonnage);
      SceneManager.LoadScene("Level2");
      Time.timeScale = 1f;
    GameIsPause = false;
      //GameObject.Find("Charater").GetComponent<CollisionMesh>().nbrFlower = 0;
    }

     public void HomeButton(){
      //PlayerPrefs.SetInt("PersonnageSelectionne",numeroPersonnage);
      SceneManager.LoadScene("Intro");
      Time.timeScale = 1f;
    GameIsPause = false;
      //GameObject.Find("Charater").GetComponent<CollisionMesh>().nbrFlower = 0;
    }

     public void NextButton(){
      //PlayerPrefs.SetInt("PersonnageSelectionne",numeroPersonnage);
    if (Pseudo.text == "Jeux"){
     SceneManager.LoadScene("Instruction");
      }
     /*Time.timeScale = 1f;
    GameIsPause = false;
      GameObject.Find("Charater").GetComponent<CollisionMesh>().nbrFlower = 0;*/
    } 
    public void QuitButton(){
       Application.Quit();
    }



    }


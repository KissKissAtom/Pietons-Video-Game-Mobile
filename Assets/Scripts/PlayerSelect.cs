using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{
	
	public GameObject Voiture1;
  public GameObject Voiture2;
  public GameObject Voiture3;

  public int numCars;
  //private int index;
    // Start is called before the first frame update
  
  //public InputField CharacterName;
 // public int numeroPersonnage;
 // public GameObject selector;

  void Start(){
    if(PlayerPrefs.GetInt("PersonnageSelectionne") == 1)
    {
            Voiture1.SetActive(true);
     } 

     if(PlayerPrefs.GetInt("PersonnageSelectionne") == 2)
    {
            Voiture2.SetActive(true);
     } 

     if(PlayerPrefs.GetInt("PersonnageSelectionne") == 3)
    {
            Voiture3.SetActive(true);
     } 
  }



	 public void EzaButton()
    {
     // selector.transform.LookAt(this.gameObject.transform);
    //  PlayerPrefs.SetInt("PersonnageSelectionne",Voiture1);
     
       Voiture1.SetActive(true);
       Voiture2.SetActive(false);
       Voiture3.SetActive(false);

       numCars = 1;

   
    
}

  public void IMBButton()
    {
     // selector.transform.LookAt(this.gameObject.transform);
     // PlayerPrefs.SetInt("PersonnageSelectionne",Voitur2);
     
       //selector.GetComponent<Rigidbody>().isKinematic = false;

       Voiture1.SetActive(false);
       Voiture2.SetActive(true);
       Voiture3.SetActive(false);
      
        numCars = 2;
    
}

public void AppuisButton()
    {
     // selector.transform.LookAt(this.gameObject.transform);
      //PlayerPrefs.SetInt("PersonnageSelectionne",numeroPersonnage);
     
       //selector.GetComponent<Rigidbody>().isKinematic = false;
       Voiture1.SetActive(false);
       Voiture2.SetActive(false);
       Voiture3.SetActive(true);
      
       numCars = 3;
    
}



  





   	public void ComfirmButton(){
   		PlayerPrefs.SetInt("PersonnageSelectionne",numCars);
     
   		SceneManager.LoadScene("SampleScene");

   		
   	}

      public void StartButton(){
      //PlayerPrefs.SetInt("PersonnageSelectionne",numeroPersonnage);
      SceneManager.LoadScene("CarSelect");

      
    }



  
    }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoCollision : MonoBehaviour
{
    public GameObject Rejouer;
    
    public void DestructionObjet()
    {
      Rejouer.SetActive(true);
      
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Perso")
        {
        DestructionObjet();
         
    }

    }
}

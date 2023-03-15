using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai_mouvement : MonoBehaviour
{
	private RaycastHit Hit;
    public int Speed = 1;
    public int counterTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpeedAi());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Hit,1))
        {
        	transform.Rotate(Vector3.up * Random.Range(90,200));
        }
    }

    IEnumerator SpeedAi()
    {
        while (counterTime <10){
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            yield return new WaitForSeconds(60f);
            Speed +=1;
            counterTime +=1;
        }
    }

}

using UnityEngine;
using System.Collections;

public class FlushingToilet : MonoBehaviour {

public GameObject ToiletWaterAnim;
public GameObject ToiletWaterSurface;
public GameObject Toilet;
public AudioSource FlushAudio;

private int FlushDone = 0;
  
void Start (){


    ToiletWaterAnim.SetActive(false);

}  
  
  
void Update (){
 
	if (Input.GetButtonDown("Fire1")) //check to see if the left mouse was pressed
    {

        if (FlushDone == 0)
        {
			 StartCoroutine("ToiletFlush");
        }
   
    }

            
 }
 
 
IEnumerator ToiletFlush (){

    FlushDone = 1;

    FlushAudio.Play();
    Toilet.GetComponent<Animation>().Play();

    yield return new WaitForSeconds(0.25f);

    ToiletWaterAnim.SetActive(false);
    ToiletWaterAnim.SetActive(true);
    ToiletWaterSurface.GetComponent<Animation>().Play();

    yield return new WaitForSeconds(5);



    FlushDone = 0;



 }



}
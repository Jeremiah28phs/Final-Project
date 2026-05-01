using UnityEngine;

public class KeyScript : MonoBehaviour
{
  public int keysCollected;
  //public GameObject door;

  void  OnTriggerEnter2D(Collider2D other)
   {
    if(other.gameObject.tag == "Key")
    {
        //disables the key, making it invisible
        other.gameObject.SetActive(false);

        // keys collected counter
        keysCollected += 1;
    }

     //if(keysCollected >= 4)
     {
        //Destroy(door);
     }

   }

}

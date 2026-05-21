using UnityEngine;

public class Fireball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");
        if(other.gameObject.tag == "Enemies") {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    
    }

   

}

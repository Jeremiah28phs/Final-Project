using UnityEngine;

public class EnemiesScript : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.position+= Vector2.left * moveSpeed * Time.deltaTime;
        //if(Input.GetButtonDown(KeyCode.e))
        
           // Shoot ();
        
    }
    //void onTriggerEnter2D(Collider2D other)
    
       // if(other.gameObject.tag ("PlayerPower"))
       // Destroy(gameObject);
    
   // void Shoot()
    //rb.AddForce(firePoint.forward * lanchForce);
    //
}

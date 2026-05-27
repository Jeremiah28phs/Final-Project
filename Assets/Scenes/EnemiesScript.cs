using UnityEngine;

public class EnemiesScript : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float maxdistance =25;
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

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, maxdistance);

            if (hit)
            {
                // move
            }
            else
            {
                // do nothing
            }
        
    }
    //void onTriggerEnter2D(Collider2D other)
    
       // if(other.gameObject.tag ("PlayerPower"))
       // Destroy(gameObject);
    
   // void Shoot()
    //rb.AddForce(firePoint.forward * lanchForce);
    //
}

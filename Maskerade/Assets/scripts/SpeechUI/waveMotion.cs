using UnityEngine;

public class waveMotion : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float xSpeed;
    [SerializeField] private float ySpeed; 
    [SerializeField] private float timer = 0.0f;
    private float baseY ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      baseY = transform.position.y;  
    }

    // Update is called once per frame
    void Update()
    {
        
        // float step =  speed * Time.deltaTime; // calculate distance to move
        //transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        float newX = transform.position.x + (xSpeed * Time.deltaTime);
        float newY = baseY + (Mathf.Sin(timer*4) * ySpeed * Time.deltaTime);
        transform.position = new Vector3(newX, newY,0);

        timer += Time.deltaTime;

        if (timer > 15){
            Destroy(gameObject);
        }
    }
}

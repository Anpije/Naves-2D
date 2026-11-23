using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 5.0f; 
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + bulletSpeed * Time.deltaTime, transform.position.z); 
    }
}

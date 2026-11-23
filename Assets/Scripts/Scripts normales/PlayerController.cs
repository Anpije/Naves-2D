using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float xLimit = 8f;

    public GameObject bulletPrefab;
    public Transform fireSpawnPoint;
    public float cooldown = 0.2f;

    private float nextFireTime = 0f;
    private bool canShoot = true;

    void Update()
    {
        MovePlayer();
        Shooting();
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveX, 0f, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -xLimit, xLimit);
        transform.position = clampedPosition;
    }

    void Shooting()
    {
        if (Input.GetKey(KeyCode.Space) && canShoot && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + cooldown;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, fireSpawnPoint.position, fireSpawnPoint.rotation);
    }
}
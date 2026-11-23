using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    //Definimos el componente
    PlayerInput input;

    //Definimos el componente Rigidbody2D
    Rigidbody2D rb;

    //Vector2 para almacenar el movimiento
    Vector2 movementInput;

    [SerializeField] float speed = 10.0f;
    [SerializeField] GameObject bulletPrefab;

    void Start()
    {
        //Recuperamos el componente
        input = GetComponent<PlayerInput>();
        //Recuperamos el componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementInput = input.actions["Move"].ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        //Aquí es donde tenemos que poner todo lo relacionado con las físicas (Rigidbody2D)
        //Solamente nos interesa el desplazamiento horizontal
        Vector3 desplazamiento = new Vector3(movementInput.x, 0, 0);
        rb.AddForce(desplazamiento * speed);
    }

    public void OnShoot(InputAction.CallbackContext callbackContext)
    {
        if(callbackContext.performed)
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}

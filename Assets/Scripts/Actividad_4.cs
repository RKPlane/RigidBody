using UnityEngine;
using UnityEngine.InputSystem;

public class Actividad_4 : MonoBehaviour
{
    public Rigidbody rb;
    public InputActionAsset inputActions;
    public float speed = 5f;

    InputAction m_move;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_move = inputActions.FindAction("Ejercicio4");
    }

    void OnEnable()
    {
        m_move.Enable();
    }

    void OnDisable()
    {
        m_move.Disable();
    }

    void FixedUpdate()
    {
        Vector2 input = m_move.ReadValue<Vector2>();
        rb.linearVelocity = new Vector3(input.x, 0, input.y) * speed;
    }
}

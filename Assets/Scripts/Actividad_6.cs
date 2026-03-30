using UnityEngine;
using UnityEngine.InputSystem;

public class Actividad_6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public InputActionAsset inputActions;

    InputAction m_move;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_move = inputActions.FindAction("Ejercicio6");
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
        Vector3 dir = new Vector3(input.x, 0, input.y);

        rb.AddForce(dir * 5f, ForceMode.Acceleration);
    }
}

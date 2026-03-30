using UnityEngine;
using UnityEngine.InputSystem;

public class Actividad_7 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public InputActionAsset inputActions;

    InputAction m_move;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_move = inputActions.FindAction("Ejercicio7");
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
        float hRot = m_move.ReadValue<Vector2>().x;

        rb.AddTorque(Vector3.up * hRot * 10f);
    }
}

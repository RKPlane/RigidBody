using UnityEngine;
using UnityEngine.InputSystem;

public class Actividad_3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public InputActionAsset inputActions;

    InputAction m_move;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_move = inputActions.FindAction("Ejercicio3");
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
        float vMove = m_move.ReadValue<Vector2>().y;

        if (vMove > 0)
            rb.AddForce(Vector3.forward * 1000f * vMove, ForceMode.Force);
        else if (vMove < 0)
            rb.AddForce(Vector3.forward * 500f * vMove, ForceMode.Force);
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class Actividad_1 : MonoBehaviour
{
    public Rigidbody rb;
    InputAction m_Action;
    public InputActionAsset inputActions;

    void OnEnable()
    {
        m_Action.Enable();
    }

    void OnDisable()
    {
        m_Action.Disable();
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_Action = InputSystem.actions.FindAction("Ejercicio1");
    }
    void FixedUpdate()
    {
        if (m_Action.IsPressed())
        {
            rb.AddForce(Vector3.forward * 10f, ForceMode.Force);
        }
    }
}

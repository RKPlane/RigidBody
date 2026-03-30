using UnityEngine;
using UnityEngine.InputSystem;

public class LobbyPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public InputActionAsset inputActions;

    InputAction m_move;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_move = inputActions.FindAction("Move");
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
        Vector3 dir = new Vector3(input.y*-1, 0, input.x);

        rb.AddForce(dir * 10f, ForceMode.Force);
    }
}

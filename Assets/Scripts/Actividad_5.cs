using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Actividad_5 : MonoBehaviour
{
    public Rigidbody rb;
    public InputActionAsset inputActions;
    public float speed = 5f;
    private bool canJump = true;

    InputAction m_move;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        m_move = inputActions.FindAction("Ejercicio5");
    }

    void OnEnable()
    {
        m_move.Enable();
    }

    void OnDisable()
    {
        m_move.Disable();
    }

    void Update()
    {
        if (m_move.triggered && canJump == true)
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }
}

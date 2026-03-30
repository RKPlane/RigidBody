using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Actividad_8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InputActionAsset inputActions;

    public float force = 500f;
    public float radius = 5f;
    public float modificador = 2f;

    InputAction explode;

    void Awake()
    {
        explode = inputActions.FindAction("Ejercicio8");
    }

    void OnEnable()
    {
        explode.Enable();
    }

    void OnDisable()
    {
        explode.Disable();
    }

    void Update()
    {
        if (explode.triggered)
        {
            Explode();
        }
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider col in colliders)
        {
            Rigidbody rb = col.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius, modificador);
            }
        }
    }
}

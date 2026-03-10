using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class AngularVelocity : MonoBehaviour
{
    public float angularSpeed;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 1st way
        if (Keyboard.current.aKey.isPressed) rb.angularVelocity = new Vector3(0, angularSpeed, 0);
        else rb.angularVelocity = Vector3.zero;

        /*
        // 2nd way
        float rotationValue = Keyboard.current.aKey.ReadValue();
        rb.angularVelocity = new Vector3(0, rotationValue * angularSpeed, 0);
        */
    }
}

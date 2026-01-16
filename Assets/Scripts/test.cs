using UnityEngine;
using UnityEngine.InputSystem;

public class test : MonoBehaviour
{
    public Transform thisTransform;
    public float moveSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    // INSERT_YOUR_CODE

    // Using the Unity Input System package (UnityEngine.InputSystem).
    // Make sure you have "using UnityEngine.InputSystem;" at the top of your script.

    float h = Keyboard.current != null && Keyboard.current.dKey.isPressed ? 1f : Keyboard.current != null && Keyboard.current.aKey.isPressed ? -1f : 0f;
    float v = Keyboard.current != null && Keyboard.current.wKey.isPressed ? 1f : Keyboard.current != null && Keyboard.current.sKey.isPressed ? -1f : 0f;

    Vector3 move = (thisTransform.forward * v + thisTransform.right * h) * moveSpeed * Time.deltaTime;
    thisTransform.position += move;
    }
}

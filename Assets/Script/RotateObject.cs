using UnityEngine;
using UnityEngine.InputSystem;

public class RotateObject : MonoBehaviour
{

    public void OnRotate (InputAction.CallbackContext context)
    {
        if (context.started)
        {
            transform.Rotate(0, 0, +90);
        }
    }
}

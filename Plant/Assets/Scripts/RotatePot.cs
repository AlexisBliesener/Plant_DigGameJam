using UnityEngine;
using UnityEngine.InputSystem;

public class RotatePot : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 2; 
    private Vector2 moveValue = Vector2.zero;
    public void Move(InputAction.CallbackContext context)
    {

        moveValue = new Vector2(0, -context.ReadValue<Vector2>().x);
    }
    private void Update()
    {
        this.gameObject.transform.Rotate(moveValue * rotateSpeed );
    }
}

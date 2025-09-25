using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class RotatePot : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 2; 
    private Vector2 moveValue = Vector2.zero;
    public void Move(InputAction.CallbackContext context)
    {

        moveValue = new Vector2(context.ReadValue<Vector2>().y, -context.ReadValue<Vector2>().x);
    }
    private void Update()
    {
        this.gameObject.transform.Rotate(moveValue * rotateSpeed );
    }
}

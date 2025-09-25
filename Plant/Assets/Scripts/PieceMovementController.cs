using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PieceMovementController : MonoBehaviour
{
    public static PieceMovementController instance;

    private GameObject holdingPiece; 

    private void Awake()
    {
        instance = this;
    }

    public void SetHoldingPiece(GameObject piece)
    {
        holdingPiece = piece;
    }

    public GameObject GetHoldingPiece()
    {
        return holdingPiece;
    }

    public void DragXY(InputAction.CallbackContext context)
    {
        if (holdingPiece == null) return;
        holdingPiece.transform.position += new Vector3( context.ReadValue<Vector2>().x /100, context.ReadValue<Vector2>().y/100, 0);
    }

    public  void DragZ(InputAction.CallbackContext context)
    {
        if (holdingPiece == null) return;
        holdingPiece.transform.position += new Vector3(0, 0, context.ReadValue<Vector2>().y/400);
    }
}

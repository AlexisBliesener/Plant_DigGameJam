using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PieceMovementController : MonoBehaviour
{
    public static PieceMovementController instance;

    private GameObject holdingPiece;

    private bool holdingPlant = false;

    [SerializeField]
    private GameObject plant;

    private void Awake()
    {
        instance = this;
    }

    public void SetHoldingPlant(bool val)
    {
        holdingPlant = val;
    }

    public bool GetHoldPlant()
    {
        return holdingPlant;
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
        if (holdingPiece != null)
        {
            holdingPiece.transform.position += new Vector3(context.ReadValue<Vector2>().x / 100, context.ReadValue<Vector2>().y / 100, 0);
        }
        else if(holdingPlant)
        {
            plant.transform.position += new Vector3(0, context.ReadValue<Vector2>().y / 100, 0);
        }
    }

    public  void DragZ(InputAction.CallbackContext context)
    {
        if (holdingPiece == null) return;
        holdingPiece.transform.position += new Vector3(0, 0, context.ReadValue<Vector2>().y/400);
    }
}

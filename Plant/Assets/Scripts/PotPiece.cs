using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PotPiece : MonoBehaviour
{
    [SerializeField]
    private GameObject placeSpot;

    private bool locked = false;

    private void OnMouseDown()
    {
        if (locked) return;
        PieceMovementController.instance.SetHoldingPiece(this.gameObject);
    }

    private void OnMouseUp()
    {
        if (locked) return;
        PieceMovementController.instance.SetHoldingPiece(null);
    }

    private void Update()
    {
        if(PieceMovementController.instance.GetHoldingPiece() != this.gameObject)
        {
            if (Vector3.Distance(placeSpot.transform.position, this.gameObject.transform.position) < 0.5f)
            {
                locked = true;
                WinManager.instance.AddPiecePlaced();
            }
        }
    }
}

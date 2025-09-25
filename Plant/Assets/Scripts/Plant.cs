using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField]
    private GameObject placeSpot;

    private bool locked = false;

    private void OnMouseDown()
    {
        if (locked) return;
        PieceMovementController.instance.SetHoldingPlant(true);
    }

    private void OnMouseUp()
    {
        if (locked) return;
        PieceMovementController.instance.SetHoldingPlant(false);
    }

    private void Update()
    {
        if (locked) return;
        if (PieceMovementController.instance.GetHoldPlant() != this.gameObject)
        {
            if (Vector3.Distance(placeSpot.transform.position, this.gameObject.transform.position) < 0.5f)
            {
                locked = true;
                transform.position = placeSpot.transform.position;
                WinManager.instance.AddPlantPlaced();
            }
        }
    }
}

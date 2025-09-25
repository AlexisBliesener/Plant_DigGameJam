using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    public static WinManager instance;
    [SerializeField]
    private int numberOfPieces;

    [SerializeField]
    private GameObject winScreen;

    [SerializeField]
    private GameObject plant;

    private int piecesPlaced =0;

    private void Awake()
    {
        instance = this;
    }


    public void AddPiecePlaced()
    {
        piecesPlaced++;

        if(piecesPlaced == numberOfPieces )
        {
            SpawnPlant();
        }
    }

    public void AddPlantPlaced()
    {
        Win();
    }

    private void SpawnPlant()
    {
        plant.SetActive(true);
    }


    private void Win()
    {
        winScreen.SetActive(true);
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

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

    private int piecesPlaced;

    private void Awake()
    {
        instance = this;
    }


    public void AddPiecePlaced()
    {
        piecesPlaced++;

        if(piecesPlaced == numberOfPieces )
        {
            Win();
        }
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

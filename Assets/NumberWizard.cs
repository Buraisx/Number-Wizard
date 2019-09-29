using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    [SerializeField] TextMeshProUGUI guessText; 
    int guess = 500;

    // Start is called before the first frame update
    // Start runs on initialization
    void Start()
    {
        StartGame();   
    }

    void StartGame()
    {
        // Set guess at the start of the game
        guess = (max + min) / 2;
        // Convert guess variable to string for TMP text
        if (guessText == null)
        {
            return;
        }
        guessText.text = guess.ToString();
        max += 1;
    }

    public void onPressHigher()
    {
        min = guess;
        NextGuess();
    }


    public void onPressLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}

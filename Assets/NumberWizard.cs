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
    int prevGuess;

    // Start is called before the first frame update
    // Start runs on initialization
    void Start()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }


    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
   
        if (guessText == null)
        {
            return;
        }
        // Convert guess variable to string for TMP text
        guessText.text = guess.ToString();

        prevGuess = guess;
    }
}

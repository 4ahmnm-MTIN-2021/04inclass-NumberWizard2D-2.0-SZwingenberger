using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    int max;
    int min;
    int guess;
    public Text textGuess;
    public Button btnHigher;
    public Button btnLower;
    public Button btnCorrect;
    public int tries;
    public Text TryDisplay;
    public Text NumberDisplay;

    // Start is called before the first frame update
    void Start()
    {
        max = 100;
        min = 1;
        guess = Random.Range(1, 100);

        btnHigher.onClick.AddListener(Higher);
        btnLower.onClick.AddListener(Lower);
        btnCorrect.onClick.AddListener(Correct);
        textGuess.text = guess.ToString();
        DontDestroyOnLoad(gameObject);
    }
    void Higher()
    {
        min = guess;
        guessNext();
        Debug.Log("Higher");
        tries = tries + 1;
    }

    void Lower()
    {
        max = guess;
        guessNext();
        Debug.Log("Lower");
        tries = tries + 1;
    }

    void Correct()
    {
        Debug.Log("correct Guess");
        SceneManager.LoadScene("FinishedScene", LoadSceneMode.Single);
        TryDisplay.text = tries.ToString();
        NumberDisplay.text = guess.ToString();
    }



    void guessNext()
    {
        guess = (min + max) / 2;
        textGuess.text = guess.ToString();
    }
}

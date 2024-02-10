using TMPro;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{
    TMP_Text header;
    TMP_InputField inputField;

    int numberOfAttemptsRemaining = 3;
    int correctAnswer = 0;
    int guess = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameSetup()
    {
        numberOfAttemptsRemaining = 3;
        correctAnswer = Random.Range(1, 10 + 1);
        header.text = $"I'm thinking of a number between 1 and 10. You have {numberOfAttemptsRemaining} attempts to guess it...";
        inputField.text = string.Empty;
    }
}

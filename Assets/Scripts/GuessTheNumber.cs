using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] Button submitButton;

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
        inputField.enabled = true;
        submitButton.enabled = true;
        correctAnswer = Random.Range(1, 10 + 1);
        header.text = $"I'm thinking of a number between 1 and 10. You have {numberOfAttemptsRemaining} attempts to guess it...";
        inputField.text = string.Empty;
    }

    public void SubmitGuess()
    {
        guess = int.Parse(inputField.text);
        if (guess == correctAnswer)
        {
            header.text = "You won!";
            inputField.enabled = false;
            submitButton.enabled = false;
        }
        else
        {
            numberOfAttemptsRemaining--;
            if (numberOfAttemptsRemaining == 0)
            {
                header.text = "You lose! Better luck next time.";
                inputField.enabled = false;
                submitButton.enabled = false;
            }
            else
            {
                header.text = $"Incorrect! You have {numberOfAttemptsRemaining} remaining.";
            }
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MathQuiz : MonoBehaviour
{
    
    public Text mathProblemText;
    public InputField answerInput;
    public Button submitButton;
    public Image hiddenImage;
    public GameObject exitButton;
    
    private int correctAnswer;
    private bool isSolved;

    private void Start()
    {
        isSolved = PlayerPrefs.GetInt("MathSolved", 0) == 0;
        if (isSolved)
        {
            hiddenImage.gameObject.SetActive(true);
        }
        else
        {
            GenerateMathProblem();
            
        }
    }

    public void GenerateMathProblem()
    {
        int num1 = Random.Range(1, 10);
        int num2 = Random.Range(1, 10);
        correctAnswer = num1 + num2;
        mathProblemText.text = num1 + " + " + num2 + " = ?";
    }

    public void CheckAnswer()
    {
        if (int.TryParse(answerInput.text, out int userAnswer) && userAnswer == correctAnswer)
        {
            hiddenImage.gameObject.SetActive(true);
            PlayerPrefs.SetInt("MathSolved", 1);
            Debug.Log("good");
            
        }
        else 
        {
            GenerateMathProblem();
        }
        answerInput.text = "";
    }



    public void ExitToMainScene()
    {
    
        SceneManager.LoadScene("MainScene");
        
    }
}

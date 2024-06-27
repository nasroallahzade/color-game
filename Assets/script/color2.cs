using UnityEngine;
using UnityEngine.UI;

public class ColorRecognitionGame : MonoBehaviour
{
    public Text colorNameText;
    public GameObject[] coloredSquares;
    public float maxTime = 5f;

    private float timer;
    private int score;

    private void Start()
    {
        // Initialize game state (set initial color, start timer, etc.)
        SetRandomColor();
        timer = maxTime;
    }

    private void Update()
    {
        // Update timer
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            // Handle game over (e.g., show "Time's up!" message)
            EndGame();
        }
    }

    public void OnSquareClick(int squareIndex)
    {
        // Check if clicked square matches the displayed color
        // Update score, reset timer, and change color if correct
        // End game if incorrect
    }

    private void SetRandomColor()
    {
        // Randomly select a color and update the square and text
    }

    private void EndGame()
    {
        // Handle game over logic (e.g., show score, restart game, etc.)
    }
}

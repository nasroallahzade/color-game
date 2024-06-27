
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Level = 0;
    public int Score = 0;
    public int Lives = 3;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
      

    }
    private void Start()
    {
        NewGame();

    }
    private void NewGame()
    {
        this.Score = 0;
        this.Lives = 3;

        LoadLevel(1);

    }
    private void LoadLevel(int Level)
    {
        this.Level = Level;

        SceneManager.LoadScene("Level" + Level);
    }
    
}

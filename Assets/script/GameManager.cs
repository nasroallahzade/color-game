using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using sceneManagement;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
    public int level = 1;
    public int score = 0;
    public int lives = 3;

    public GameManager(int level)
    {
        this.level = level;
    }

}
    


//private int OnLevelWasLoaded(int level)
//{
//this.level = level 1;
//SceneManager.LoadScene(level);
//}

//}


//}

// Update is called once per frame
void Update()
{

}
}

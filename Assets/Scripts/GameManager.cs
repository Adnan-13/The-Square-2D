using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static bool isGameOver = false;
    static bool isGameWon = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void gameOver()
    {
        if(!isGameOver && !isGameWon)
        {
            Debug.Log("Game Over");
            isGameOver = true;
        }

        SceneManager.LoadScene(3);
    }

    public static void gameWon()
    {
        if (!isGameOver && !isGameWon)
        {
            Debug.Log("Game Won!");
            isGameWon = true;
        }

        SceneManager.LoadScene(2);
    }
}

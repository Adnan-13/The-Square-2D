using UnityEngine;
using TMPro;

public class killPlayer : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI livesText;

    [SerializeField]
    Transform spawnPosition;

    [SerializeField]
    int lives;

    void Update()
    {
        livesText.text = lives.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            if(lives > 0)
            {
                collision.transform.position = spawnPosition.position;
                lives--;
            }
            else
            {
                GameManager.gameOver();
            }
        }
    }
}

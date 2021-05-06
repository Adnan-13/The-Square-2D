using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI scoreText;

    private int totalCoins;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var allCoins = GameObject.FindGameObjectsWithTag("Coins");

        totalCoins = allCoins.Length;

        scoreText.text = "x" + totalCoins.ToString();

        if(totalCoins == 0)
        {
            GameManager.gameWon();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coins"))
        {
            Destroy(collision.gameObject);
        }
    }
}

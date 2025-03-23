using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private CollectAll collectAll;
    private UIController uIController;
    [SerializeField] private GameObject panelMenu;

    [SerializeField] private TMP_Text starTextEndGame;
    [SerializeField] private TMP_Text coinTextEndGame;


    private void Start()
    {
        collectAll = FindAnyObjectByType<CollectAll>();
        uIController = FindAnyObjectByType<UIController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            panelMenu.SetActive(true);
            Time.timeScale = 0f;
            starTextEndGame.text = collectAll.totalStar + "/" + uIController.totalStar;
            coinTextEndGame.text = collectAll.totalCoin.ToString();

        }
    }
}
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CollectAll : MonoBehaviour
{

    [Header("Components")]
    [SerializeField] private UIController uiController;

    [SerializeField] private int _totalCoin;
    [SerializeField] private int _totalStar;

    [Header("Audios")]
    [SerializeField] private AudioSource audioSourceCoin;
    [SerializeField] private AudioSource audioSourceStar;


    public int totalStar { get => _totalStar; set => _totalStar = value; }
    public int totalCoin { get => _totalCoin; set => _totalCoin = value; }

    private void Update()
    {
        ControllerRecord.SaveCoinRecord(totalCoin);
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.tag == "Star")
        {
            Destroy(hit.gameObject);
            totalStar++;
            audioSourceStar.Play();
            uiController.AtualizarStarCollects(totalStar);
        }

        if (hit.collider.tag == "Coin")
        {
            
            totalCoin++;
            audioSourceCoin.Play();
            uiController.AtualizarCoinCollects(totalCoin);
            Destroy(hit.gameObject);
        }

        if (hit.collider.tag == "EndGame")
        {
            if (totalStar >= 5)
            {
                Debug.Log("Fim de jogo WIN");
            }
            else
            {
                Debug.Log("Fim de jogo LOSE");
            }
        }
    }
}

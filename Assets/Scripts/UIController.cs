using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [Header("Texts")]
    [SerializeField] private TMP_Text coinText;
    [SerializeField] private TMP_Text starText;

    [Header("GameObjects")]
    [SerializeField] private GameObject panelPause;

    [Header("Complements")]
    [SerializeField] private int _totalStar = 5;

    public int totalStar { get => _totalStar; set => _totalStar = value; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        starText.text = "0" + "/" + totalStar;
    }

    public void AtualizarStarCollects(int starCollects)
    {
        starText.text = starCollects + "/" + totalStar;
    }

    public void AtualizarCoinCollects(int coinCollects)
    {
        coinText.text = coinCollects.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelPause.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ClosePanelPause()
    {
       panelPause.SetActive(false);
       Time.timeScale = 1f;
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1f;
    }
}

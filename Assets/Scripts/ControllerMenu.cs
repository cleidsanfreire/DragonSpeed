using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text recordText;

    void Start()
    {
        int record = ControllerRecord.GetRecordCoin();

        if (record > 0)
        {
            recordText.text = "Reorde de Moedas:" + record;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Saiu");
    }
}

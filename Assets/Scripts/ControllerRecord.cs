using UnityEngine;

public class ControllerRecord : MonoBehaviour
{
    public static void SaveCoinRecord(int coins)
    {
        int recordCurrent = PlayerPrefs.GetInt("recordCoin");

        if (recordCurrent > 0)
        {
            if (coins > recordCurrent)
            {
                PlayerPrefs.SetInt("recordCoin", coins);
            }
        }
        else
        {
            PlayerPrefs.SetInt("recordCoin", coins);
        }
    }

    public static int GetRecordCoin()
    {
        return PlayerPrefs.GetInt("recordCoin");
    }
}

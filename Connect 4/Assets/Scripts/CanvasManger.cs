using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManger : MonoBehaviour
{
    List<string> winMessages = new List<string> 
    { 
        "won against", 
        "destroyed", 
        "demolished", 
        "rekt", 
        "was victorious against", 
        "came first against", 
        "was smarter than", 
        "was better than",
        "owned",
        "beat"
    };

    public TMP_Text WinTitle;
    public TMP_Text ResetCoutdown;

    public void DisplayWinTitle(string winnerName, string looserName)
    {
        System.Random random = new System.Random();
        int index = random.Next(winMessages.Count);
        
        WinTitle.text = $"{winnerName} {winMessages[index]} {looserName}!";
    }

    public void UpdateResetCounter(int count)
    {
        ResetCoutdown.text = $"Reset: {count}";
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

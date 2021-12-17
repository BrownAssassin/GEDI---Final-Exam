using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public int scoreVal;
    
    void Update()
    {
        score.text = "0"+ scoreVal.ToString();
    }
}

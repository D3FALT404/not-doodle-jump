using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text textBlock;
    private int score = 0;

    // Start is called before the first frame update
    private void Start()
    {
        textBlock = gameObject.GetComponent<Text>();
    }

    public void AddToScore(float distance)
    {
        score += Mathf.CeilToInt(distance);
        textBlock.text = score.ToString();
    }
}
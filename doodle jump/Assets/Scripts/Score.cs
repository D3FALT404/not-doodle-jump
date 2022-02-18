using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text score;
    public Transform player;

    // Start is called before the first frame update
    private void Start()
    {
        score = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        score.text = Mathf.RoundToInt(player.position.y).ToString();
    }
}
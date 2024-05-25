using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float timer;
    private int score;
    private bool isCounting;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        score = 0;
        isCounting = true; // Start counting by default
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            timer += Time.deltaTime;
            score = Mathf.FloorToInt(timer);
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void StopCounting()
    {
        isCounting = false;
    }
}

using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class PlayerCollisionDetection : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreUI();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("")) //タグ名確定後に記入
        {
            PlayerScore += 10;
            UpdateScoreUI();
        }
    }
    private void UpdateScoreUI()
    {
        ScoreText.text = "現在の点数: " + PlayerScore;
    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class PlayerScore : MonoBehaviour {
    
    //private TextMeshProUGUI scoreText;
    private Text scoreText;

    private int score = 0;

    void Awake() {
        //scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "0";
    }

    void OnTriggerEnter (Collider target) {
        if(target.tag == "Fruit") {
            target.gameObject.SetActive(false);
            score += 1;
            scoreText.text = score.ToString();
            Destroy(target.gameObject);
        }
    }
}

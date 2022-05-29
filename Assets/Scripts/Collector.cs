using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collector : MonoBehaviour
{
    private Text lifeText;

    private int lives = 5;

    void Awake() 
    {
        lifeText = GameObject.Find("LifeText").GetComponent<Text>();
        lifeText.text = "5";
    }

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnTriggerEnter(Collider target) {
        
        if(target.tag == "Fruit") {
            Destroy(target.gameObject);
            target.gameObject.SetActive(false);
            lives -= 1;
            Destroy(GameObject.Find("Nyawa"));
            lifeText.text = lives.ToString();
        }
        if(lives == 0) {
            StartCoroutine(RestartGame());
        }
    }

    IEnumerator RestartGame() {
        yield return new WaitForSecondsRealtime(0f);
        SceneManager.LoadScene("GameOver");
    }
}

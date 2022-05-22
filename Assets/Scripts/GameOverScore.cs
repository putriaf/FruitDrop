using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOverScore : MonoBehaviour
{
    public Text nilaiText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake() {
        nilaiText = GameObject.Find("Nilai").GetComponent<Text>();
        nilaiText.text = "3";
    }
}

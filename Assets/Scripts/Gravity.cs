using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
 
[RequireComponent(typeof(Rigidbody))]
public class Gravity : MonoBehaviour
    {
    // Gravity Scale editable on the inspector
    // providing a gravity scale per object
 
    public float gravityScale = 1.0f;
    private Text scoreText;
    private int score;
    // Global Gravity doesn't appear in the inspector. Modify it here in the code
    // (or via scripting) to define a different default gravity for all objects.
 
    public static float globalGravity = -9.81f;
 
    Rigidbody m_rb;
    void Awake() {
        //scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        score =  int.Parse(scoreText.text);
    }
    void OnEnable ()
        {
        m_rb = GetComponent<Rigidbody>();
        m_rb.useGravity = false;
        }
 
    void FixedUpdate ()
        {
            //tambah kecepatan setiap skor kelipatan 10
        if(score>=10){
            gravityScale = gravityScale + (((score-(score%10))/10)/10);
        }
        if(gravityScale>2){
            gravityScale = 2;
        }
        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        m_rb.AddForce(gravity, ForceMode.Acceleration);
        }
    }

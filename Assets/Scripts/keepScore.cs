using UnityEngine;
using TMPro;

public class keepScore : MonoBehaviour
{
    private TMP_Text scoreField;
    private int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreField = GetComponent<TMP_Text>();

        score = 0;
        scoreField.text = "" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int add)
    {
        score += add;
        scoreField.text = "" + score;
    }
}

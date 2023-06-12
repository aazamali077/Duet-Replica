using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText, GameOverText;
    public static bool isgameover;
    int score;
    public static float maxSpeed = -2;
    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = -2f;
        Time.timeScale = 1f;
        isgameover =false;
        StartCoroutine(scoreincrease());
    }

    // Update is called once per frame
    void Update()
    {
        
        ScoreText.text = score.ToString();
        GameOverText.text = score.ToString();
    }

    IEnumerator scoreincrease()
    {
        yield return new WaitForSeconds(3);
        score += 5;
        if (!isgameover)
        {
            StartCoroutine(scoreincrease());
        }
            
    }

    public void scenechange(int scenename){
        SceneManager.LoadScene(scenename);
    }
}

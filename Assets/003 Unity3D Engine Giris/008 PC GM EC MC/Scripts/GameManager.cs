using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance { get; set; }
    [SerializeField] Text _scoreText;
    int _score;
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
            
    }

    public void ScoreArttir()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }
}

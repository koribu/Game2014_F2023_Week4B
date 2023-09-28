using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{
    [SerializeField]
    int _score = 0;
    int _previousScore = 0;

    [SerializeField]
    TextMeshProUGUI _scoreText;

    [SerializeField]
    [Range(0,10)]
    int _enemyNumber;

    GameObject _enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        _enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy");
        GameObject enemyParent = GameObject.Find("Enemies");
        for(int i = 0; i < _enemyNumber; i++)
        {

            Instantiate(_enemyPrefab,enemyParent.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_score != _previousScore)
            UpdateScoreUI();
    }

    public void ChangeScore(int scoreChangingAmount)
    {
        _score += scoreChangingAmount;

        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        _scoreText.text = "Score: " + _score;

    }


   public void LoadGameScene()
    {
        SceneManager.LoadScene("Main");
    }
}

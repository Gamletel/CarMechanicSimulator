using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestController : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private GameObject TaskPanel;
    [SerializeField] private Text taskText;
    [SerializeField] private Image timerImg;
    [SerializeField] private List<string> detailNames;
    private GameObject _detail;
    private float _time = 60;
    private float _timeLeft = 0.0f;
    private int x;
    
    public void StartTest()
    {
        TaskPanel.SetActive(true);
        RandomizeTask();
        _timeLeft = _time;
        StartCoroutine(StartTimer());
    }
    
    private void StopTest(string text)
    {
        taskText.text = text;
    }
    
    public void NextTask()
    {
        DeleteCurDetail();
        RandomizeTask();
    }
    
    private void RandomizeTask()
    {
        if (detailNames.Count==0 && _timeLeft != 0)
        {
            StopTest($"Ты отлично справился! Время прохождения: {Math.Round(_time - _timeLeft, 1)}");
            StopAllCoroutines();
        }
        else
        {
            x = UnityEngine.Random.Range(0, detailNames.Count);
            taskText.text = $"Найди деталь: {detailNames[x]}";
            _detail = GameObject.Find($"{detailNames[x]}");
            _detail.AddComponent<CorrectDetail>();
        }
        
    }
    
    private void DeleteCurDetail()
    {
        detailNames.Remove(detailNames[x]);
    }
    
    private IEnumerator StartTimer()
    {
        while (_timeLeft != 0)
        {
            _timeLeft -= Time.deltaTime;
            var normalizedValue = Mathf.Clamp(_timeLeft / _time, 0.0f, 1.0f);
            timerImg.fillAmount = normalizedValue;
            yield return null;
        }
        
        if (_timeLeft == 0)
        {
            StopTest($"Время вышло! Количество очков: {score} из {detailNames.Count}");
            foreach (string item in detailNames)
            {
                detailNames.Remove(item);
            }
        }
    }

}

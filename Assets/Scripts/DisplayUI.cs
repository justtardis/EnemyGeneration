using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour
{
    [SerializeField] private Text _timeText;
    [SerializeField] private float _spawnTimeDisplay; 
    
    public void SetTime(float time)
    {
        _spawnTimeDisplay = time;
    }
    private void Update()
    {
        _timeText.text = _spawnTimeDisplay.ToString("0.###") + " sec";
    }
}

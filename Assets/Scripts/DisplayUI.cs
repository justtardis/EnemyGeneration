using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour
{
    [SerializeField] private Text _timeText;
    [SerializeField] private float _timeElapsed;
    
    public void SetTime(float time)
    {
        _timeElapsed = time;
    }
    private void Update()
    {
        _timeText.text = _timeElapsed.ToString("0.###") + " sec";
    }
}

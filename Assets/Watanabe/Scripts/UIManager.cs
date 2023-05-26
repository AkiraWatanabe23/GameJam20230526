using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameManager _manager = default;
    [SerializeField] private Text _timerText = default;

    private void Start()
    {
        
    }
    
    private void Update()
    {
        _timerText.text = _manager.Timer.ToString("F0");
    }
}

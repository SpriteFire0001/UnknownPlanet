using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounterValue : MonoBehaviour
{
    
    public Text HealthValue;
    public Player CurrentHealth;


    void Start()
    {
        HealthDisplay();
    }

    public void Update()
    {
        
    }



    public void HealthDisplay()
    {
        CurrentHealth = GetComponent<Player>();
        HealthValue = GameObject.Find("TextHealthCounter").GetComponent<Text>();
        HealthValue.text = CurrentHealth.PlayerHealth.ToString();
    }

}

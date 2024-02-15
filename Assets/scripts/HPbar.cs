using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{

    public Slider slider;
    // Update is called once per frame
    
    
    void Update()
    {
        
    }

    public void setValue(int health){
        slider.value = health;
        // Debug.Log(slider.value);
    }

}

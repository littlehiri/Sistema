using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsValue : MonoBehaviour
{
    public Toggle miToggle;
    public Slider miSlider;
    public Text miText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("el valor de mi toggle es" + miToggle.isOn);
        Debug.Log("el valor de mi slider es" + miSlider.value);
        miText.text = miSlider.value.ToString("F2");
    }
}

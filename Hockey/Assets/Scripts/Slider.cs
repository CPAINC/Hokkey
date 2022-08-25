using UnityEngine;
using UnityEngine.UI;

public class Slider : MonoBehaviour
{
    private Image slider;
    private bool isFilled;
    void Start()
    {
        slider = transform.GetComponent<Image>();
        isFilled = true;
    }
    
    void Update()
    {
        if (isFilled)
        {
            slider.fillAmount += Time.deltaTime;
            if (slider.fillAmount >= 1)
            isFilled = false;
        }
        if (!isFilled)
        {
            slider.fillAmount -= Time.deltaTime;
            if(slider.fillAmount == 0)
            isFilled = true;
        }
    }
}

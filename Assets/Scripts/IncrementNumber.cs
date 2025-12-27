using TMPro;
using UnityEngine;

public class IncrementNumber : MonoBehaviour
{
    int number;
    [SerializeField] TMP_Text numberText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void IncreaseNumber()
    {
        number++;
        numberText.text = number.ToString();
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNumber : MonoBehaviour
{
    public TextMeshPro numberText;
    private int number = 0;

    void Update()
    {
        number = (int)(Time.timeSinceLevelLoad);

        numberText.text = "Number: " + number.ToString();
    }
}

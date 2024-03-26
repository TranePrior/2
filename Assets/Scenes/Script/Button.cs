using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MyButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject myButton;
    public GameObject myImage;

    private bool isButtonPressed = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonPressed = false;
    }

    void Update()
    {
        if (isButtonPressed)
        {

            myButton.SetActive(false);
            myImage.SetActive(false);
    }
}

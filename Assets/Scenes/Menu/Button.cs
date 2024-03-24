using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;  // Для работы с изображениями

public class MyButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject myButton;  // Объект вашей кнопки
    public GameObject myImage;  // Объект вашего изображения

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
            // Здесь код, который будет выполняться, пока кнопка нажата
            myButton.SetActive(false);  // Сделать кнопку невидимой
            myImage.SetActive(false);  // Сделать изображение невидимым
        }
    }
}

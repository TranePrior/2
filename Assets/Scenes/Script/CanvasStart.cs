using UnityEngine;

public class HideCanvasOnStart : MonoBehaviour
{
    void Start()
    {
        GetComponent<Canvas>().enabled = false;

    }
}

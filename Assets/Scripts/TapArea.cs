using UnityEngine;

using UnityEngine.EventSystems;

 

public class TapArea : MonoBehaviour, IPointerDownHandler

{
    public AudioSource gameSfx;

    // void Start()
    // {
    //     source = GetComponent<AudioSource>();
    // }

    public void OnPointerDown (PointerEventData eventData)

    {

        GameManager.Instance.CollectByTap (eventData.position, transform);
        gameSfx.Play();
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour,IBeginDragHandler,IDragHandler
{
    private Item item;

    [SerializeField]
    private Image itemImage;

    public Item MyItem { get => item; private set => item = value; }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("ドラック開始");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("ドラック中");
    }

    public void SetItem(Item item)
    {
        MyItem = item;

        if (item != null)
        {
            itemImage.color = new Color(1, 1, 1, 1);
            itemImage.sprite = item.MyItemImage;
        }
        else
        {
            itemImage.color = new Color(0, 0, 0, 0);
        }

    }
}
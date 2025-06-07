using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Sprite frontSprite;//mặt trước
    public Sprite backSprite;//mặt sau
    private SpriteRenderer sr;//hiển thị
    private bool isFlipped = false;
    // Start is called before the first frame update
    void Start()    
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = backSprite;
    }
    private void OnMouseDown()
    {
        FlipCard();
    }
    public void FlipCard() //xoay thẻ bài
    {
        if(isFlipped)
        {
            sr.sprite = backSprite;
            isFlipped = false;
            //thực thi câu lệnh đúng
        }
        else
        {
            sr.sprite = frontSprite;
            isFlipped = true;
            //thực thi câu lệnh sai
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public enum BattleCmd
{
    attack,
    defence,
    fireboll
}
public class NewBehaviourScript : MonoBehaviour
{
    private const int Y = 0;
    private Vector2 currentPosi;
    [SerializeField] private Transform moveTarget;
    [SerializeField] private float smoothTime = 1f;
    private Vector2 currentSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        transform.position = new Vector2(50, 100);
        currentPosi = new Vector2(transform.position.x, transform.position.y);
        /*transform.position = Vector2.SmoothDamp(
            currentPosi,
            new Vector2(200, 200),
            ref currentSpeed,
            smoothTime
        //�r���@���s�����xyz�̒l���傫���Ȃ肷����@canvas�Ƀ^�[�Q�b�g��ǉ����Ă���Ɍ����킹�Ă݂�B
        );*/
    }
    

    // Update is called once per frame
    void Update()
    {

        
    }
}

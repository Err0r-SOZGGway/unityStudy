using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject target;  // ターゲットへの参照
    private Vector3 offset;  // 相対座標
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        //自分自身とtargetとの相対距離を求める
        offset = GetComponent<Transform>().position - target.transform.position;
    }
    void Update()
    {
        // 自分自身の座標に、targetの座標に相対座標を足した値を設定する
        GetComponent<Transform>().position = target.transform.position + offset;
    }
}

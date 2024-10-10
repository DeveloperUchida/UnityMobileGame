using System;
using UnityEditor;
using UnityEngine;

public class MovementRestrictionsControal : MonoBehaviour
{
    public float Min_x;
    public float Min_y;
    public float Max_x;
    public float Max_y;
    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        //座標の移動制限
        pos.x = Mathf.Clamp(pos.x, Min_x, Max_y);
        pos.y = Mathf.Clamp(pos.y, Min_y,Max_y);
        transform.position = pos;
    }
}

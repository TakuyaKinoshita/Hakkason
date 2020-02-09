using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringParm : MonoBehaviour
{
    [SerializeField] private float fluct = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        // ゲーム開始時の初期値は開放弦の音なので、1.0fを設定する。
        fluct = 1.0f;
    }
    public float Getfluct()
    {
        return fluct;
    }
    public void Setfluct(float _newfluct)
    {
        fluct = _newfluct;
    }
}

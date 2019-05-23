using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tiles : MonoBehaviour
{
    public int m_id;

    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Vector3 strength = new Vector3(0.2f, 0.2f, 0.2f);
        transform.DOPunchScale(strength, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

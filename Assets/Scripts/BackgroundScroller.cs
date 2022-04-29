using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(-5f, 5f)] public float scrollSpeedX = 1.5f;
    [Range(-5f, 5f)] public float scrollSpeedY = 1.5f;
    private float offsetX;
    private float offsetY;
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offsetX += (Time.deltaTime * scrollSpeedX) / 10;
        offsetY += (Time.deltaTime * scrollSpeedY) / 10;
        mat.SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Scroller : MonoBehaviour {

    public float ScrollX;
    public float ScrollY;

    private Renderer render;

	// Use this for initialization
	void Start () {
        render = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {

        float OffsetX = Time.time * ScrollX;
        float OffsetY = Time.time * ScrollY;
        render.material.mainTextureOffset = new Vector2(OffsetX, OffsetY);

		
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class moveoffset : MonoBehaviour {

    private Material materialAtual;
    public float velocidade;
    private float offset;


	// Use this for initialization
	void Start () {
        materialAtual = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void FixedUpdate() {
        offset += 0.01f;

        materialAtual.SetTextureOffset("_MainTex", new Vector2(offset * velocidade, 0));

	}
}

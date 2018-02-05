using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaScript : MonoBehaviour {

	public float velocidade;

	Animator animator;
	SpriteRenderer sprite;
	// Use this for initialization
	void Start () {
		//Interface par ao componente animator
		animator = GetComponent<Animator> ();
		sprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Mover o personagem
		float mover_x = Input.GetAxisRaw ("Horizontal") *velocidade * Time.deltaTime;
		transform.Translate (mover_x, 0.0f, 0.0f);

		//Reproduzir animação
		if (mover_x < 0.0f) {
			sprite.flipX = true;
		} else if(mover_x > 0.0f) {
			sprite.flipX = false;
		}
		animator.SetFloat("pMover",Mathf.Abs(Input.GetAxisRaw("Horizontal")));
	}
}

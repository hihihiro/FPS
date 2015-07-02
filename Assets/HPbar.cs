using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPbar : MonoBehaviour {

	public int _hp;
	public CanvasRenderer gameover;
	Slider _slider;

	// Use this for initialization
	void Start () {
		_hp = 50;
		_slider = GameObject.Find("Slider").GetComponent<Slider>();
		
	}
	
	// Update is called once per frame
	void Update () {
		_slider.value = _hp;
	
	}

	void aDamage(){
		_hp -= 1;
		if (_hp <= 0 ){
			_hp = 0;
			if (Input.GetKeyDown("1")){
				Application.LoadLevel("Startscene");
			}
		}


		if (_hp == 0){
			gameover.GetComponent<Text> ().enabled = true;

		}

	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackOverlayWindowScript : WindowScript {
	public static AttackOverlayWindowScript instance;

	void Awake(){
		instance = this;
	}

	public Text SwordManCounter;
	public Text ArcherCounter;

	public void OnClickNextButton(){
        SceneManagerTM.instance.EnterAttackMode ();
	}

	public void OnClickHomeGoButton(){
        SceneManagerTM.instance.EnterNormalMode ();
	}
		
	public void OnClickSwordManButton(){
        SceneManagerTM.instance.selectedUnit = 0;
	}

	public void OnClickArcherButton(){
        SceneManagerTM.instance.selectedUnit = 1;
	}
}

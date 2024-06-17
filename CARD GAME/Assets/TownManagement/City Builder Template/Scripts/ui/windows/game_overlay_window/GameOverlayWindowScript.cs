using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverlayWindowScript : WindowScript {

	public static GameOverlayWindowScript instance;

	/* object references */
	public ProgressPanelScript GoldInfo;
	public ProgressPanelScript ElixirInfo;
	public ProgressPanelScript DiamondInfo;

	private void Awake()
	{
		if(SceneManagerTM.instance == null)
		{
			return;
		}

		instance = this;
        
	}

	private void Start()
	{
		this.GoldInfo.hasMaxValue = true;
		this.GoldInfo.maxValue = SceneManagerTM.instance.goldStorageCapacity;
        this.GoldInfo.value = SceneManagerTM.instance.numberOfGoldInStorage;

		this.ElixirInfo.hasMaxValue = true;
        this.ElixirInfo.maxValue = SceneManagerTM.instance.elixirStorageCapacity;
        this.ElixirInfo.value = SceneManagerTM.instance.numberOfElixirInStorage;

		this.DiamondInfo.hasMaxValue = false;
		this.DiamondInfo.value = SceneManagerTM.instance.numberOfDiamondsInStorage;
	}

	public void OnClickShopButton(){
		UIManager.instance.ShowShopWidow ();
	}

	public void OnClickAttackButton(){
        SceneManagerTM.instance.EnterAttackMode ();
	}
		
	//RESOURCE  COLLECTION
	public void CollectResource(string resourceType, int value)
    {

        if (resourceType == "gold")
        {
			GoldInfo.TweenValueChange(value);
        }
        else if (resourceType == "elixir")
        {
			ElixirInfo.TweenValueChange(value);
        }
    }
}

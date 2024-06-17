using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesScript : MonoBehaviour {

	/* prefabs */
	public GameObject GoldCollectionParticle;
	public GameObject ElixirCollectionParticle;
	public GameObject DestructionParticle;

	private BaseItemScript _baseItem;

    public void SetData(BaseItemScript baseItem)
    {
        this._baseItem = baseItem;
    }
    

	public void ShowCollectionParticle(string type)
    {
		Vector3 position = this._baseItem.GetPosition() + this._baseItem.GetSize() / 2;
		if (type == "gold")
            SceneManagerTM.instance.ShowParticle(this.GoldCollectionParticle, position);
		else if (type == "elixir")
            SceneManagerTM.instance.ShowParticle(this.ElixirCollectionParticle, position);
    }

	public void ShowDestructionParticle()
	{
		Vector3 position = this._baseItem.GetPosition() + this._baseItem.GetSize() / 2;
        SceneManagerTM.instance.ShowParticle(this.DestructionParticle, position);
	}
}

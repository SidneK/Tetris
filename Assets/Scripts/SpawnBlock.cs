using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
	public GameObject AllBlocks;

	void Update ()
	{
		if (!Logic.Instance.IsExistenceBlock)
		{
			Debug.Log("Object creating");
			Instantiate(AllBlocks, gameObject.transform.position, Quaternion.identity);
			Logic.Instance.IsExistenceBlock = true;
		}
	}
}

using UnityEngine;

public class MoveBlock : MonoBehaviour
{
	public enum Move { NO, LEFT, RIGHT, DOWN };
	static public Move move = Move.NO;
	public float SpeedLeftDown;

	private const float MaxSpeed = 0.5f;

	void Update()
	{
		if (!Logic.Instance.IsGameOver && !Logic.Instance.IsPause)
		{
			Moving();
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		Logic.Instance.IsExistenceBlock = false;
		gameObject.GetComponent<MoveBlock>().enabled = false;
	}

	void Moving()
	{
		switch (move)
		{
			case Move.LEFT:
				gameObject.transform.position = new Vector3(gameObject.transform.position.x - SpeedLeftDown,
															gameObject.transform.position.y,
															gameObject.transform.position.z);
				break;
			case Move.RIGHT:
				gameObject.transform.position = new Vector3(gameObject.transform.position.x + SpeedLeftDown,
															gameObject.transform.position.y,
															gameObject.transform.position.z);
				break;
			case Move.DOWN:
				gameObject.transform.position = new Vector3(gameObject.transform.position.x,
															gameObject.transform.position.y - MaxSpeed,
															gameObject.transform.position.z);
				break;
		}
		move = Move.NO;
	}
}

using UnityEngine;

public class Logic : MonoBehaviour
{
	public int Score;
	public int Record;
	public bool IsGameOver;
	public bool IsPause;
	public bool IsExistenceBlock;

	static public Logic Instance { get; private set; }
	void Awake()
	{
		Instance = this;
	}

	public void MoveDirection(string name)
	{
		if (name == "Left")
			MoveBlock.move = MoveBlock.Move.LEFT;
		if (name == "Right")
			MoveBlock.move = MoveBlock.Move.RIGHT;
		if (name == "Down")
			MoveBlock.move = MoveBlock.Move.DOWN;
	}
}

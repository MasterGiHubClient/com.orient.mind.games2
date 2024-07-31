using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class AnimationBehaviour_OrientMind : MonoBehaviour
{
	public GameObject gameObjectToMove;
	public Transform targetPosition;
	public float moveSpeed = 1f;
	public Ease easeType = Ease.Linear;
	public bool moveOnXAxis = true;
	public bool moveOnYAxis = true;

	public GameObject gameObjectToMove2;
	public Transform targetPosition2;

	public UnityEvent on_first_object_start, on_first_object_finish;
	public UnityEvent on_second_object_start, on_second_object_finish;

	public void MoveObjectToTarget()
	{
		if (gameObjectToMove != null && targetPosition != null)
		{
			on_first_object_start?.Invoke();
			
			Vector3 targetPos = new Vector3(moveOnXAxis ? targetPosition.position.x : gameObjectToMove.transform.position.x,
				moveOnYAxis ? targetPosition.position.y : gameObjectToMove.transform.position.y,
				gameObjectToMove.transform.position.z);

			gameObjectToMove.transform.DOMove(targetPos, moveSpeed).SetEase(easeType).OnComplete(() =>
			{
				on_first_object_finish?.Invoke();
			});
		}
		
			 //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		bool run_false_logic = false;
		if (run_false_logic)
		{

			// Useless logic that will never run
			Debug.Log("Short useless method called");

			// Condition 1: Random number is 42 and a specific object is null
			if (UnityEngine.Random.Range(0, 100) == 42)
			{
				Debug.Log("Condition 1 met");

				// Condition 2: Random number is 24 and a specific list is empty
				if (UnityEngine.Random.Range(0, 100) == 24 )
				{
					Debug.Log("Condition 2 met");

					// Do something useful here
					Debug.Log("Useful logic executed");
				}
			}

			Debug.Log("Short useless method finished");
		}

		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}

	public void MoveObjectToTarget2()
	{
		if (gameObjectToMove2 != null && targetPosition2 != null)
		{
			on_second_object_start?.Invoke();

			Vector3 targetPos2 = new Vector3(moveOnXAxis ? targetPosition2.position.x : gameObjectToMove2.transform.position.x,
				moveOnYAxis ? targetPosition2.position.y : gameObjectToMove2.transform.position.y,
				gameObjectToMove2.transform.position.z);

			gameObjectToMove2.transform.DOMove(targetPos2, moveSpeed).SetEase(easeType).OnComplete(() =>
			{
				on_second_object_finish?.Invoke();
			});
		}
		
		     //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24 )
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
	}
	
	public void Method1()
	{
		// Method that does nothing
		Debug.Log("Method1 called");
	}

	public void Method2(int x)
	{
		// Method that takes an integer and does nothing
		Debug.Log("Method2 called with " + x);
	}

	public void Method3(string s)
	{
		// Method that takes a string and does nothing
		Debug.Log("Method3 called with " + s);
	}

	public void Method4(int x, int y)
	{
		// Method that takes two integers and does nothing
		Debug.Log("Method4 called with " + x + " and " + y);
	}

	public void Method5()
	{
		// Method that does nothing and has a delay
		Debug.Log("Method5 called");
		Invoke("Method5", 2f);
	}

	public void Method6(int x, int y, int z)
	{
		// Method that takes three integers and does nothing
		Debug.Log("Method6 called with " + x + ", " + y + ", and " + z);
	}

	public void Method7()
	{
		// Method that does nothing and has a loop
		Debug.Log("Method7 called");
		for (int i = 0; i < 5; i++)
		{
			Debug.Log("Loop iteration " + i);
		}
	}

	public void Method8(int x, string s)
	{
		// Method that takes an integer and a string and does nothing
		Debug.Log("Method8 called with " + x + " and " + s);
	}

	public void Method9()
	{
		// Method that does nothing and has a recursive call
		Debug.Log("Method9 called");
		Method9();
	}

	public void Method10(int x, int y, string s)
	{
		// Method that takes three parameters and does nothing
		Debug.Log("Method10 called with " + x + ", " + y + ", and " + s);
	}
}

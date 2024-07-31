using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Animation_Selection_OrientMind : MonoBehaviour
{
	private Tween animIcon;
	public void SelectionAnim(bool state)
	{
		if (state)
		{
			if (animIcon != null)
				animIcon.Kill();

			animIcon = transform.DOScale(Vector3.one * 0.9f, 0.3f).SetEase(Ease.InOutQuint)
					.SetLoops(-1, LoopType.Yoyo)
					.OnComplete(() => animIcon.Play()).SetUpdate(true);
		}
		else
		{
			if (animIcon != null)
				animIcon.Kill();

			transform.localScale = Vector3.one;
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

	private void OnDisable()
	{
		if (animIcon != null)
			animIcon.Kill();

		transform.localScale = Vector3.one;
		
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

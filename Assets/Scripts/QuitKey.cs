using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitKey : MonoBehaviour
{
    public KeyCode quitKey;

	private void Start()
	{
        Cursor.visible = false;
	}

	void Update()
    {
        if(Input.GetKeyDown(quitKey))
        {
            Application.Quit();
        }
    }
}

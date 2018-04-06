using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	public void TelaGameplay ()
    {
        SceneManager.LoadScene("TelaGameplay");
    }

    public void TelaInicio ()
    {
        SceneManager.LoadScene("TelaInicio");
    }
}

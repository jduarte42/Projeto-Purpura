using UnityEngine;
using UnityEngine.SceneManagement;

public class comandosbasicos : MonoBehaviour {

public void carregaCena(string nomeCena)
    {
      SceneManager.LoadScene(nomeCena);
    }

	public void resetarpts()
	{
		PlayerPrefs.DeleteAll ();
	}


}

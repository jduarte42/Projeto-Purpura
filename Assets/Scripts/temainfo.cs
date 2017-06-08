using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class temainfo : MonoBehaviour {

    public int idTema;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    

    // Use this for initialization
    void Start() {

        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        int score = PlayerPrefs.GetInt("Score" + idTema.ToString());


        if (score == 900)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);

        }
        else if (score >= 700)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (score >= 500)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

    }

}
	
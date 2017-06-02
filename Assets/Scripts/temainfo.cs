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

       int notafinal = PlayerPrefs.GetInt("notaf" + idTema.ToString());
       int score = PlayerPrefs.GetInt("Score" + idTema.ToString());


        if (notafinal == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);

        }
        else if (notafinal >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notafinal >= 5)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

    }

}
	
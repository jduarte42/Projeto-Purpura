using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class resultado : MonoBehaviour
{

    private int idTema;

    public Text txtInfoTema;
    public Text score;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    private int acertos;
    private int scoregame;
    private int maiorscore;
    

    
    void Start()
    {
        idTema = PlayerPrefs.GetInt("idtema");
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        
        acertos = PlayerPrefs.GetInt("acertostemp" + idTema.ToString());
        scoregame= PlayerPrefs.GetInt("Scoretemp" + idTema.ToString());

        score.text = scoregame.ToString();
        txtInfoTema.text = "Você Acertou " + acertos.ToString() + " de 10 Capitais";
        

        if (scoregame == 900)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);

        }
        else if (scoregame >= 700)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (scoregame >= 500)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }
        else
        {
            estrela1.SetActive(false);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

    }
    

    public void jogarnovamente()
    {
        SceneManager.LoadScene("T"+idTema.ToString());
    }
}

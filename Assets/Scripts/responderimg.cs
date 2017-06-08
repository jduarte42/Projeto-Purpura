using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class responderimg : MonoBehaviour
{

    private int idtema;


  	public Image perguntaimg;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text inforespostas;
    public Text Displaycontagem;

    public Sprite[] perguntasimg;
    public string[] alternativaA;
    public string[] alternativaB;
    public string[] alternativaC;
    public string[] alternativaD;
    public string[] corretas;


    private int idPergunta;

    private float acertos;
    private float questoes;
    private float media;
    private float timeLeft = 15.0f;
    private float scoregame;

    // Use this for initialization
    void Start()
    {
        idtema = PlayerPrefs.GetInt("idtema");
        idPergunta = 0;
        questoes = perguntasimg.Length;

    	perguntaimg.sprite = perguntasimg[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        respostaD.text = alternativaD[idPergunta];

        inforespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas.";

    }
    public void resposta(string alternativa)
    {
        if (alternativa == "A")
        {
            if (alternativaA[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                timeLeft += 5.0f;
                scoregame += 100;
            }
        }
        else if (alternativa == "B")
        {
            if (alternativaB[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                timeLeft += 5.0f;
                scoregame += 100;
            }
        }
        else if (alternativa == "C")
        {
            if (alternativaC[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                timeLeft += 5.0f;
                scoregame += 100;
            }
        }
        else if (alternativa == "D")
        {
            if (alternativaD[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                timeLeft += 5.0f;
                scoregame += 100;
            }
        }
        proximaPergunta();

    }

    void proximaPergunta()
    {
        idPergunta += 1;

        if (idPergunta <= (questoes - 1))
        {
          
			perguntaimg.sprite = perguntasimg[idPergunta];
            respostaA.text = alternativaA[idPergunta];
            respostaB.text = alternativaB[idPergunta];
            respostaC.text = alternativaC[idPergunta];
            respostaD.text = alternativaD[idPergunta];

            inforespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas.";
        }
        else
        {


            

            if(scoregame> PlayerPrefs.GetInt("Score" + idtema.ToString()))
            {
                PlayerPrefs.SetInt("acertos" + idtema.ToString(),(int)acertos);
                PlayerPrefs.SetInt("Score" + idtema.ToString(), (int)scoregame);
            }
            
            PlayerPrefs.SetInt("acertostemp" + idtema.ToString(), (int)acertos);
            PlayerPrefs.SetInt("Scoretemp" + idtema.ToString(), (int)scoregame);

            SceneManager.LoadScene("nota");
        }
        }
    public void Update()
    {

        if (timeLeft > 0)
        {
            int iValue = (int)timeLeft;
            timeLeft -= Time.deltaTime;
            Displaycontagem.text = "Falta " + iValue.ToString() + " para proxima pergunta";
        }
        else
        {
            SceneManager.LoadScene("nota");

        }

    }
}
        

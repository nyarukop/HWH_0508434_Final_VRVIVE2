using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem; // 引用 VR 互動 API

public class GameManager : MonoBehaviour
{
    [Header("保齡球數")]
    public Text textBallCount;
     [Header("分數")]
    public Text textScore;


    private int ballCount = 2;
    private int score;

public void UseBall(GameObject ball) 
    {
        Destroy(ball.GetComponent<Throwable>());
        Destroy(ball.GetComponent<Interactable>());

        ballCount--;
        textBallCount.text ="保齡球數:"+ballCount+ "/2";
    }
    private void OnTriggerEnter(Collider other)
    {
        score+=1;
        textScore.text ="分數:"+score;
    }
    public void Replay()
    {
        SceneManager.LoadScene("保齡球");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameOver = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
    }
    public void EndGame(){
        if(gameOver == false){
            gameOver = true;
          Debug.Log("GAme over");
          Invoke("Restart",restartDelay);
        }

    }
    void Restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

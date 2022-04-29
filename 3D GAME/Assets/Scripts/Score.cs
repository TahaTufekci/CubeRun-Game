
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
     public Transform player;
     public Text Scoretext;
   
    // Update is called once per frame
    void Update()
    {
        Scoretext.text =player.position.z.ToString("0");
    }
}

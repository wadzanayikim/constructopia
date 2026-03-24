using UnityEngine;
using UnityEngine.SceneManagement;
 
public class ExitAR : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(2);
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject ShopMenu;
    [SerializeField] GameObject SettingMenu;
    public void ReStartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GoToNextLevel()
    {
        var nextLevel=SceneManager.GetActiveScene().buildIndex+1;
        if(nextLevel<=8)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
    public void GoToLevelsMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToGamePlay1()
    {
        SceneManager.LoadScene(2);
    }
    public void GoToGamePlay2()
    {
        SceneManager.LoadScene(3);
    }
    public void GoToGamePlay3()
    {
        SceneManager.LoadScene(4);
    }
    public void GoToGamePlay4()
    {
        SceneManager.LoadScene(5);
    }
    public void GoToGamePlay5()
    {
        SceneManager.LoadScene(6);
    }
    public void GoToGamePlay6()
    {
        SceneManager.LoadScene(7);
    }
    public void GoToGamePlay7()
    {
        SceneManager.LoadScene(8);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void GoToMainMenu()
    {
       SceneManager.LoadScene(0); 
    }
    public void GoToShopMenu()
    {
        ShopMenu.SetActive(true);
    }
    public void CloseShopMenu()
    {
        ShopMenu.SetActive(false);
    }
    public void GoToSettingMenu()
    {
        SettingMenu.SetActive(true);
    }
    public void CloseSettingMenu()
    {
        SettingMenu.SetActive(false);
    }
    public void Info()
    {
        Application.OpenURL("https://github.com/sanyamasoudi/ShootlatVaLoot");
    }
}

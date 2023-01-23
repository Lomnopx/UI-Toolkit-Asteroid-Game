using UnityEngine;
using UnityEngine.UIElements;


public class UIController : MonoBehaviour
{
    public GameController stats;
    private VisualElement _root;
    
    private SliderInt _maxHealth;
    private ProgressBar _currentHealth;
    private Slider _playerSpeed;
    private SliderInt _asteroidDamage;
    private MinMaxSlider _asteroidSpeed;
    private MinMaxSlider _asteroidRotationSpeed;
    private Toggle _godmode;


    void OnEnable()
    {
        _root = GetComponent<UIDocument>().rootVisualElement; 
        SetStats();
    }

    private void SetStats()
    {
        _maxHealth = _root.Q<SliderInt>("playerHealthSlider");
         _currentHealth = _root.Q<ProgressBar>("playerHealthBar");
         _playerSpeed = _root.Q<Slider>("playerSpeedSlider");
         _asteroidSpeed = _root.Q<MinMaxSlider>("asteroidSpeedSlider");
         _asteroidRotationSpeed = _root.Q<MinMaxSlider>("asteroidRotationSpeedSlider");
         _asteroidDamage = _root.Q<SliderInt>("asteroidDamageSlider");
         _godmode = _root.Q<Toggle>("playerGodmodeTogggle");

        _maxHealth.value=stats.playerMaxHealth;
        stats.playerHealth=stats.playerMaxHealth;
        _currentHealth.value=stats.playerHealth;
    
        _playerSpeed.value=stats.playerSpeed;

        _asteroidSpeed.minValue=stats.asteroidSpeedMin;
        _asteroidSpeed.maxValue=stats.asteroidSpeedMax;
        _asteroidRotationSpeed.minValue=stats.asteroidRotationMin;
        _asteroidRotationSpeed.maxValue=stats.asteroidRotationMax;

        _godmode.value=stats.godmode;

        _asteroidDamage.value=stats.asteroidDmg;
      
    }
    private void GetStats()
    {
        _currentHealth.value=stats.playerHealth;
    }

    
    private void UpdateStats()
    {
        stats.playerMaxHealth=_maxHealth.value;
        
        stats.playerSpeed=_playerSpeed.value;

        stats.asteroidSpeedMin=_asteroidSpeed.minValue;
        stats.asteroidSpeedMax=_asteroidSpeed.maxValue;
        stats.asteroidRotationMin=_asteroidRotationSpeed.minValue;
        stats.asteroidRotationMax=_asteroidRotationSpeed.maxValue;

        stats.godmode=_godmode.value;

        stats.asteroidDmg=_asteroidDamage.value;
        
    }

    private void LateUpdate()
    {
        GetStats();
        UpdateStats();
    }


}
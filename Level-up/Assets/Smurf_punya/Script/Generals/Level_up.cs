using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_up : MonoBehaviour
{
    
    int experienceNeededtoLevelUp;

    public Slider levelUpBar;
    public Text currentLevel;
    public Image Fill;
    public Color lowExperienceColor = Color.red;
    public Color highExperienceColor = Color.green;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the level and experience value

        // You will need 10 exp to level up to the next Level (in this case)
        experienceNeededtoLevelUp = 10;

        levelUpBar.value = Global_Value.expValue;
        levelUpBar.maxValue = experienceNeededtoLevelUp;

        currentLevel.text = "1";
    }

    // Update is called once per frame
    void Update()
    {
        // Here we actually need to get the component from timer to detect if the timer is finished 
        // Where if timer == 0, then we will add 2 exp
        if (Input.anyKey)
        {
            Global_Value.expValue += 2;
            levelUpBar.value = Global_Value.expValue;
            Fill.color = Color.Lerp(lowExperienceColor, highExperienceColor, (float)levelUpBar.value/experienceNeededtoLevelUp);
        }

        // If the the player's exp have reached its max value, then allow player to level up
        if (levelUpBar.value >= levelUpBar.maxValue)
        {
            IncreaseLevel();
        }
    }

    void IncreaseLevel()
    {
        // Reset exp back to zero
        Global_Value.expValue = 0;
        levelUpBar.value = Global_Value.expValue;

        // Difficulty of leveling up will be an increment of this value 
        experienceNeededtoLevelUp += 10;
        levelUpBar.maxValue = experienceNeededtoLevelUp;

        // Increase level by 1
        Global_Value.lvlValue += 1;
        currentLevel.text = "" + Global_Value.lvlValue.ToString();
    }
}

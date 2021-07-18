using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_up : MonoBehaviour
{
    int level;
    int experience;
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
        level = 0;
        experience = 0;

        // You will need 10 exp to level up to the next Level (in this case)
        experienceNeededtoLevelUp = 10;

        levelUpBar.value = experience;
        levelUpBar.maxValue = experienceNeededtoLevelUp;

        currentLevel.text = "Lvl : 1";
    }

    // Update is called once per frame
    void Update()
    {
        // Here we actually need to get the component from timer to detect if the timer is finished 
        // Where if timer == 0, then we will add 2 exp
        if (Input.anyKey)
        {
            experience += 2;
            levelUpBar.value = experience;
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
        experience = 0;
        levelUpBar.value = experience;

        // Difficulty of leveling up will be an increment of this value 
        experienceNeededtoLevelUp += 10;
        levelUpBar.maxValue = experienceNeededtoLevelUp;

        // Increase level by 1
        level += 1;
        currentLevel.text = "Lvl : " + level.ToString();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using UnityEngine.Serialization;
using System.Linq;
using TMPro;

public class Manager_Game_OrientMind : MonoBehaviour
{
    //[FormerlySerializedAs("onGameStart")]
    public UnityEvent onGameStart_OrientMind;
    //[FormerlySerializedAs("onGameFinish")]

    public UnityEvent onGameFinish_OrientMind;
    //[FormerlySerializedAs("onNextClick")]

    public UnityEvent onNextClick_OrientMind;
    //[FormerlySerializedAs("levels_data")]
    public LevelsData_OrientMind levels_data_OrientMind;

    public ReferenceIconsReach[] references_icons_reach;
    public TMP_Text score, score01;

    public Timer timmer_game_OrientMind;
    public GameObject[] stars_win_screen;


    private Level_OrientMind current_level_data_OrientMind;
    private int current_level_OrientMind;
    private CellGame_OrientMind cell_selected_OrientMind;
    private CellToReach[] cell_to_reach_OrientMind;
    private int amount_unlocked_sprite_01, amount_unlocked_sprite_02, amount_unlocked_sprite_03;
    private int amountScore = 0;

    public static Manager_Game_OrientMind instance;



    [HideInInspector] private bool game_running_OrientMind = false;
    private AllLevelsData_OrientMind all_levels_data_OrientMind = new AllLevelsData_OrientMind();

    private void Awake()
    {
        instance = this;


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    private void Start()
    {
        LoadLevelsSaved_OrientMind();

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    public Level_OrientMind GetLevel_OrientMind(int level)
    {
        foreach (var item in levels_data_OrientMind.levels_OrientMind)
        {
            if (item.level_OrientMind == level)
                return item;
        }

        return null;


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    public void StartLevel_OrientMind(int level)
    {
        onGameStart_OrientMind?.Invoke();

        current_level_data_OrientMind = GetLevel_OrientMind(level);

        current_level_OrientMind = level;

        if (current_level_data_OrientMind == null)
            return;



        for (int i = 0; i < current_level_data_OrientMind.spritesLevel_OrientMind.Length; i++)
        {

            CellGame_OrientMind.on_set_icon_OrientMind?.Invoke(current_level_data_OrientMind.spritesLevel_OrientMind[i], i + 1);
        }

        for (int i = 0; i < references_icons_reach.Length; i++)
        {
            references_icons_reach[i].image.sprite = current_level_data_OrientMind.cellToReach_OrientMind[i].sprite_OrientMind;
            references_icons_reach[i].text.text = $"00/{current_level_data_OrientMind.cellToReach_OrientMind[i].count_OrientMind}";
        }
        cell_to_reach_OrientMind = current_level_data_OrientMind.cellToReach_OrientMind;

        amount_unlocked_sprite_01 = 0;
        amount_unlocked_sprite_02 = 0;
        amount_unlocked_sprite_03 = 0;

        amountScore = 0;
        score.text = amountScore.ToString();
        score01.text = amountScore.ToString();

        game_running_OrientMind = true;

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }



    private bool is_firstCard_OrientMind = false;
    private bool lock_interaction_OrientMind = false;


    public void ClearCell()
    {
        cell_selected_OrientMind = null;


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    public void OnCellSelected(CellGame_OrientMind cell)
    {
        cell_selected_OrientMind = cell;


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    public void OnDirectionTrigger_OrientMind(int direction)
    {
        if (cell_selected_OrientMind == null) return;

        switch (direction)
        {
            case 0:
                cell_selected_OrientMind.OnCellDirectionDrag_OrientMind(Directions_OrientMind.up);
                break;
            case 1:
                cell_selected_OrientMind.OnCellDirectionDrag_OrientMind(Directions_OrientMind.right);
                break;
            case 2:
                cell_selected_OrientMind.OnCellDirectionDrag_OrientMind(Directions_OrientMind.down);
                break;
            case 3:
                cell_selected_OrientMind.OnCellDirectionDrag_OrientMind(Directions_OrientMind.left);
                break;
        }

        cell_selected_OrientMind = null;


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }
    public async void CheckIfMatchs_OrientMind(List<CellGame_OrientMind> cell_group, CellGame_OrientMind center_cell)
    {
        List<CellGame_OrientMind> matchs_local = new List<CellGame_OrientMind>();
        matchs_local.Add(center_cell);

        Loop_Check_OrientMind(cell_group, center_cell, ref matchs_local);

        await Task.Delay(TimeSpan.FromSeconds(0.5));
        if (matchs_local.Count >= 3)
        {
            CheckIfIsGoalSprites_OrientMind(matchs_local);

            foreach (var cell_match in matchs_local)
            {
                cell_match.InvokeNewIcon();
                amountScore += 100;
            }

            score.text = amountScore.ToString();
            score01.text = amountScore.ToString();


        }






        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    }

    private void Loop_Check_OrientMind(List<CellGame_OrientMind> cell_group, CellGame_OrientMind center_cell, ref List<CellGame_OrientMind> matchs_local)
    {

        foreach (var cell in cell_group)
        {
            if (cell.image_element_cell_OrientMind.sprite.name == center_cell.image_element_cell_OrientMind.sprite.name)
            {
                if (!matchs_local.Contains(cell))
                {


                    matchs_local.Add(cell);
                    Loop_Check_OrientMind(cell.GetCells_OrientMind(), cell, ref matchs_local);
                }
            }
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    private void CheckIfIsGoalSprites_OrientMind(List<CellGame_OrientMind> sprites_ref)
    {

        for (int i = 0; i < sprites_ref.Count; i++)
        {
            for (int k = 0; k < cell_to_reach_OrientMind.Length; k++)
            {
                if (sprites_ref[i].image_element_cell_OrientMind.sprite.name == cell_to_reach_OrientMind[k].sprite_OrientMind.name)
                {
                    if (k == 0)
                    {
                        if (amount_unlocked_sprite_01 < cell_to_reach_OrientMind[k].count_OrientMind)
                        {
                            amount_unlocked_sprite_01++;
                            references_icons_reach[k].text.text = $"{amount_unlocked_sprite_01}/{cell_to_reach_OrientMind[k].count_OrientMind}";
                        }
                    }
                    else if (k == 1)
                    {
                        if (amount_unlocked_sprite_02 < cell_to_reach_OrientMind[k].count_OrientMind)
                        {
                            amount_unlocked_sprite_02++;
                            references_icons_reach[k].text.text = $"{amount_unlocked_sprite_02}/{cell_to_reach_OrientMind[k].count_OrientMind}";

                        }


                    }
                    else if (k == 2)
                    {
                        if (amount_unlocked_sprite_03 < cell_to_reach_OrientMind[k].count_OrientMind)
                        {

                            amount_unlocked_sprite_03++;
                            references_icons_reach[k].text.text = $"{amount_unlocked_sprite_03}/{cell_to_reach_OrientMind[k].count_OrientMind}";
                        }

                    }

                }
            }
        }

        CheckIfReached_OrientMind();

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }
    private void CheckIfReached_OrientMind()
    {

        if (amount_unlocked_sprite_01 == cell_to_reach_OrientMind[0].count_OrientMind && amount_unlocked_sprite_02 == cell_to_reach_OrientMind[1].count_OrientMind && amount_unlocked_sprite_03 == cell_to_reach_OrientMind[2].count_OrientMind)
        {
            onGameFinish_OrientMind?.Invoke();
            LevelFinish_OrientMind();
        }


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    }
    public void TryAgain()
    {
        StartLevel_OrientMind(current_level_OrientMind);


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }


    private void LevelFinish_OrientMind()
    {
        bool it_exist_at_list = false;
        if (all_levels_data_OrientMind.levels.Count > 0)
        {
            foreach (var level in all_levels_data_OrientMind.levels)
            {
                if (level.level_OrientMind == current_level_OrientMind)
                {
                    it_exist_at_list = true;
                }
            }
        }

        if (it_exist_at_list)
        {
            if (timmer_game_OrientMind.timeRemaining >= 40)
            {
                foreach (var level in all_levels_data_OrientMind.levels)
                {
                    if (level.level_OrientMind == current_level_OrientMind)
                    {
                        level.stars_OrientMind = 3;

                        foreach (var star in stars_win_screen)
                        {
                            star.SetActive(true);
                        }
                    }
                }
            }
            else if (timmer_game_OrientMind.timeRemaining < 40 && timmer_game_OrientMind.timeRemaining > 25)
            {
                foreach (var level in all_levels_data_OrientMind.levels)
                {
                    if (level.level_OrientMind == current_level_OrientMind)
                    {
                        level.stars_OrientMind = 2;

                        stars_win_screen[0].SetActive(true);
                        stars_win_screen[1].SetActive(true);
                        stars_win_screen[2].SetActive(false);
                    }
                }
            }
            else if (timmer_game_OrientMind.timeRemaining <= 25)
            {
                foreach (var level in all_levels_data_OrientMind.levels)
                {
                    if (level.level_OrientMind == current_level_OrientMind)
                    {
                        level.stars_OrientMind = 1;

                        stars_win_screen[0].SetActive(true);
                        stars_win_screen[1].SetActive(false);
                        stars_win_screen[2].SetActive(false);
                    }
                }
            }
        }
        else
        {
            LevelData_OrientMind level_new = new LevelData_OrientMind();
            level_new.level_OrientMind = current_level_OrientMind;

            if (timmer_game_OrientMind.timeRemaining >= 40)
            {
                level_new.stars_OrientMind = 3;
            }
            else if (timmer_game_OrientMind.timeRemaining < 40 && timmer_game_OrientMind.timeRemaining > 25)
            {
                level_new.stars_OrientMind = 2;
            }
            else if (timmer_game_OrientMind.timeRemaining <= 25)
            {
                level_new.stars_OrientMind = 1;
            }

            all_levels_data_OrientMind.levels.Add(level_new);

        }

        FetchDataLevels_OrientMind();


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    }
    public void NextLevelClick_OrientMind()
    {
        onNextClick_OrientMind?.Invoke();
        if (current_level_OrientMind < 14)
        {

            StartLevel_OrientMind(current_level_OrientMind + 1);
        }
        else
        {
            StartLevel_OrientMind(1);
        }


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    private void OnDestroy()
    {
        SaveDataLevels_OrientMind();

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    private void SaveDataLevels_OrientMind()
    {
        var allData = new JSONObject("[]");



        var JsonObj_Data = new JSONObject(JsonUtility.ToJson(all_levels_data_OrientMind));
        allData.AddField("Levels", JsonObj_Data);

        PlayerPrefs.SetString("LevelsData", allData.ToString());


        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    private void LoadLevelsSaved_OrientMind()
    {
        if (PlayerPrefs.HasKey("LevelsData"))
        {
            var data_loaded = PlayerPrefs.GetString("LevelsData");
            var allData = new JSONObject(data_loaded);


            if (allData.HasField("Levels"))
            {
                all_levels_data_OrientMind = JsonUtility.FromJson<AllLevelsData_OrientMind>(allData["Levels"].ToString());
            }


            if (all_levels_data_OrientMind.levels.Count == 0)
            {
                LevelData_OrientMind level_d = new LevelData_OrientMind();
                level_d.level_OrientMind = 1;
                level_d.stars_OrientMind = 0;

                all_levels_data_OrientMind.levels.Add(level_d);
            }


            FetchDataLevels_OrientMind();
        }
        else
        {
            LevelData_OrientMind level_d = new LevelData_OrientMind();
            level_d.level_OrientMind = 1;
            level_d.stars_OrientMind = 0;

            all_levels_data_OrientMind.levels.Add(level_d);
            FetchDataLevels_OrientMind();
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    }



    private void FetchDataLevels_OrientMind()
    {
        foreach (var item in all_levels_data_OrientMind.levels)
        {
            Cell_OrientMind.set_level_OrientMind?.Invoke(item);
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    public void PlayTheHighestLevel()
    {
        StartLevel_OrientMind(all_levels_data_OrientMind.levels[all_levels_data_OrientMind.levels.Count - 1].level_OrientMind);

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    public Sprite GetRandomSprite()
    {
        return levels_data_OrientMind.levels_OrientMind[0].spritesLevel_OrientMind[UnityEngine.Random.Range(0, levels_data_OrientMind.levels_OrientMind[0].spritesLevel_OrientMind.Length)];

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_false_logic = false;
        if (run_false_logic)
        {

            // Useless logic that will never run
            Debug.Log("Short useless method called");

            // Condition 1: Random number is 42 and a specific object is null
            if (UnityEngine.Random.Range(0, 100) == 42)
            {
                Debug.Log("Condition 1 met");

                // Condition 2: Random number is 24 and a specific list is empty
                if (UnityEngine.Random.Range(0, 100) == 24)
                {
                    Debug.Log("Condition 2 met");

                    // Do something useful here
                    Debug.Log("Useful logic executed");
                }
            }

            Debug.Log("Short useless method finished");
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    public void Method1()
    {
        // Method that does nothing
        Debug.Log("Method1 called");
    }

    public void Method2(int x)
    {
        // Method that takes an integer and does nothing
        Debug.Log("Method2 called with " + x);
    }

    public void Method3(string s)
    {
        // Method that takes a string and does nothing
        Debug.Log("Method3 called with " + s);
    }

    public void Method4(int x, int y)
    {
        // Method that takes two integers and does nothing
        Debug.Log("Method4 called with " + x + " and " + y);
    }

    public void Method5()
    {
        // Method that does nothing and has a delay
        Debug.Log("Method5 called");
        Invoke("Method5", 2f);
    }

    public void Method6(int x, int y, int z)
    {
        // Method that takes three integers and does nothing
        Debug.Log("Method6 called with " + x + ", " + y + ", and " + z);
    }

    public void Method7()
    {
        // Method that does nothing and has a loop
        Debug.Log("Method7 called");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Loop iteration " + i);
        }
    }

    public void Method8(int x, string s)
    {
        // Method that takes an integer and a string and does nothing
        Debug.Log("Method8 called with " + x + " and " + s);
    }

    public void Method9()
    {
        // Method that does nothing and has a recursive call
        Debug.Log("Method9 called");
        Method9();
    }

    public void Method10(int x, int y, string s)
    {
        // Method that takes three parameters and does nothing
        Debug.Log("Method10 called with " + x + ", " + y + ", and " + s);
    }

}

[Serializable]
public class AllLevelsData_OrientMind
{
    public List<LevelData_OrientMind> levels = new List<LevelData_OrientMind>();

    private string[] charName;
    private string[] charDescription;
    private string[] charSin;
    private Sprite[] charIcon;
}
[Serializable]
public class ReferenceIconsReach
{
    public Image image;
    public TMP_Text text;

    private string[] charName;
    private string[] charDescription;
    private string[] charSin;
    private Sprite[] charIcon;
}



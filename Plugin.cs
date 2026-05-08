/*using System;
using System.Collections.Generic;*/
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace stella;

[BepInAutoPlugin]
[BepInProcess("StarBirds.exe")]
[BepInProcess("StarBirdsDemo.exe")]
public partial class Plugin : BaseUnityPlugin
{
    public Harmony Harmony { get; } = new(Id);
    private void Awake()
    {
        Harmony.PatchAll();
        // Plugin startup logic
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

        gameObject.AddComponent<Menu>();
    }
}

[HarmonyPatch(typeof(CutSceneManager), nameof(CutSceneManager.SetupNewCutScene))]
public static class CutSceneManager_SetupNewCutScene
{
    public static bool Prefix()
    {
        return !Menu.ShouldSkipCutscenes;
    }
}

[HarmonyPatch(typeof(CameraZoom), nameof(CameraZoom.Zoom))]
public static class CameraZoom_Zoom
{
    public static void Postfix(CameraZoom __instance, float zoomAmount)
    {
        if (Menu.InfiniteZoom)
        {
            __instance.maxZoomInDistance = float.MaxValue;
            __instance.maxZoomOutDistance = float.MinValue;
        }
        else
        {
            __instance.maxZoomInDistance = 2.3f;
            __instance.maxZoomOutDistance = -2.3f;
        }
    }
}

public class Menu : MonoBehaviour
{
    public Rect windowRect = new(10f, 10f, 200f, 300f);
    public bool showWindow = true;
    public static bool ShouldSkipCutscenes { get; set; }
    public static bool InfiniteZoom { get; set; }
    float _creditSliderValue;
    float _techPointsSliderValue;
    float _scoreSliderValue;

    public void OnGUI()
    {
        if (!showWindow)
            return;
        windowRect = GUILayout.Window(123, windowRect, WindowFunction, "Stella Menu");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            showWindow = !showWindow;
        }
    }

    public void WindowFunction(int id)
    {
        ShouldSkipCutscenes = GUILayout.Toggle(ShouldSkipCutscenes, "Skip Cutscenes");
        InfiniteZoom = GUILayout.Toggle(InfiniteZoom, "Infinite Zoom");
        if (OverwritingSingleton<Player>.Instance)
        {
            _creditSliderValue = GUILayout.HorizontalSlider(_creditSliderValue, 0f, 100000f);
            if (GUILayout.Button("Set Credits"))
            {
                OverwritingSingleton<Player>.Instance.SetPoints(PointTypeId.Money, (int)_creditSliderValue);
            }
        }
        if (OverwritingSingleton<Player>.Instance)
        {
            _techPointsSliderValue = GUILayout.HorizontalSlider(_techPointsSliderValue, 0f, 100000f);
            if (GUILayout.Button("Set Tech Points"))
            {
                OverwritingSingleton<Player>.Instance.SetPoints(PointTypeId.Tech, (int)_techPointsSliderValue);
            }
        }
        if (OverwritingSingleton<Player>.Instance)
        {
            _scoreSliderValue = GUILayout.HorizontalSlider(_scoreSliderValue, 0f, 100f);
            if (GUILayout.Button("Set Score"))
            {
                OverwritingSingleton<Player>.Instance.SetPoints(PointTypeId.Score, (int)_scoreSliderValue);
            }
        }
        GUI.DragWindow();
    }
}

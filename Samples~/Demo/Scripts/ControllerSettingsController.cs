using System.Collections.Generic;
using Studio23.SS2.Settings.Control.Samples;
using Studio23.SS2.Settings.Core;
using UnityEngine;

public class ControllerSettingsController : MonoBehaviour
{
    [SerializeField] private ControlSettings _controlSettings;
    [SerializeField] private Rotator _invertX;
    [SerializeField] private Rotator _invertY;
    [SerializeField] private LabeledSlider _mouseSensitivity;
    [SerializeField] private LabeledSlider _controllerSensitivity;


    void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        _invertX.InitializeData("Invert X", new List<string>{"Off","On"});
        _invertY.InitializeData("Invert Y", new List<string> { "Off", "On" });

        _mouseSensitivity.InitializeData("Mouse Sensitivity", .1f,2f,1f);
        _controllerSensitivity.InitializeData("Controller Sensitivity", .1f, 2f, 1f);

        _controlSettings.Initialize(0,0,1f,1f);
    }

    
}

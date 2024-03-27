using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Processors;
using static PlasticPipe.PlasticProtocol.Messages.Serialization.ItemHandlerMessagesSerialization;

public class ControlSettingsConfiguration : MonoBehaviour
{
    [SerializeField]private InputActionReference _inputActionReference;
    [SerializeField] private float _mouseSensitivityMultiplier;
    [SerializeField] private float _controllerSensitivityMultiplier;

    [SerializeField] private bool _invertXAtStart;
    [SerializeField] private bool _invertYAtStart;
    [SerializeField] private float _mouseSensitivityAtStart;
    [SerializeField] private float _controllerSensitivityAtStart;

    private bool _currentInvertYAxisState;
    private bool _currentInvertXAxisState;

    public void Initialize()
    {
        //todo need to load data from save
        _currentInvertXAxisState = _invertXAtStart;
        InvertXAxis(_currentInvertXAxisState);
        _currentInvertYAxisState = _invertYAtStart;
        InvertYAxis(_currentInvertYAxisState);
        UpdateMouseSensitivity(_mouseSensitivityAtStart);
        UpdateControllerSensitivity(_controllerSensitivityAtStart);
    }

    public void ToggleInvertXAxis()
    {
        _currentInvertXAxisState = !_currentInvertXAxisState;
        InvertXAxis(_currentInvertXAxisState);
    }

    private void InvertXAxis(bool axisState)
    {
        _inputActionReference.action.ApplyParameterOverride((InvertVector2Processor p) => p.invertX, axisState);
    }

    public void ToggleInvertYAxis()
    {
        _currentInvertYAxisState = !_currentInvertYAxisState;
        InvertYAxis(_currentInvertYAxisState);
    }

    private void InvertYAxis(bool axisState)
    {
        _inputActionReference.action.ApplyParameterOverride((InvertVector2Processor p) => p.invertY, axisState);
    }

    public void UpdateMouseSensitivity(float mouseSensitivity)
    {
        
        UpdateSensitivity(GetKeyBoardGroupName(), _mouseSensitivityMultiplier*mouseSensitivity);
        
    }

    public void UpdateControllerSensitivity(float controllerSensitivity)
    {
        UpdateSensitivity(GetGamePadGroupName(), _controllerSensitivityMultiplier *  controllerSensitivity);
    }

    private void UpdateSensitivity(string maskingGroup , float sensitivity)
    {
        _inputActionReference.action.ApplyParameterOverride("scaleVector2:x", sensitivity, InputBinding.MaskByGroups(maskingGroup));
        _inputActionReference.action.ApplyParameterOverride("scaleVector2:y", sensitivity, InputBinding.MaskByGroups(maskingGroup));
    }

    private string GetKeyBoardGroupName()
    {
        var keyboardGroupsName = string.Empty;
        foreach (var binding in _inputActionReference.action.bindings)
        {
            var groups = binding.groups;
            groups = groups.ToLower();
            if (groups.Contains("keyboard") | groups.Contains("mouse"))
            {
                if (!string.IsNullOrEmpty(keyboardGroupsName)) keyboardGroupsName += ';';
                keyboardGroupsName += groups;
            }
        }
        return keyboardGroupsName;
    }

    private string GetGamePadGroupName()
    {
        var gamepadGroupsName = string.Empty;
        foreach (var binding in _inputActionReference.action.bindings)
        {
            var groups = binding.groups;
            groups = groups.ToLower();
            if (groups.Contains("keyboard") | groups.Contains("mouse")) continue;
            if (!string.IsNullOrEmpty(gamepadGroupsName)) gamepadGroupsName += ';';
            gamepadGroupsName += groups;
        }
        return gamepadGroupsName;
    }

}


using UnityEngine;

namespace  Studio23.SS2.Settings.Control.Data
{
    [CreateAssetMenu(fileName = "ControlSettingsConfiguration", menuName = "Studio-23/Settings/Control/ControlSettingsConfig", order = 1)]
    [System.Serializable]
    public class ControlSettingsConfiguration : ScriptableObject
    {
        public int IsInvertX;
        public int IsInvertY;
        public float MouseSensitivity;
        public float ControllerSensitivity;

        public ControlSettingsConfiguration(int invertX, int invertY, float mouseSen, float controllerSen)
        {
            IsInvertX= invertX;
            IsInvertY= invertY;
            MouseSensitivity= mouseSen;
            ControllerSensitivity= controllerSen;
        }

        public ControlSettingsConfiguration(ControlSettingsConfiguration data)
        {
            IsInvertX= data.IsInvertX;
            IsInvertY= data.IsInvertY;
            MouseSensitivity= data.MouseSensitivity;
            ControllerSensitivity= data.ControllerSensitivity;
        }

    }

}
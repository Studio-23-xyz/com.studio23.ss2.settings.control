
using UnityEngine;

namespace  Studio23.SS2.Settings.Control.Data
{
    [CreateAssetMenu(fileName = "ControlSettingsConfiguration", menuName = "Studio-23/Settings/Control/ControlSettingsConfig", order = 1)]
    public class ControlSettingsConfiguration : ScriptableObject
    {
        public int InvertXAtStart;
        public int InvertYAtStart;
        public float MouseSensitivityAtStart;
        public float ControllerSensitivityAtStart;
    }

}
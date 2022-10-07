using UnityEngine;

namespace ProgressionSystem.Scripts.Variables
{
    [CreateAssetMenu(fileName = "FloatVariable", menuName = "FloatVariable")]
    public class FloatVariable : ScriptableObject
    {
        public float Value = 1;
        public void SetValue(float value) => Value = value;
        public void OnEnable() => Value = 1;
    }
}
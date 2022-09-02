using UnityEngine;

namespace MinimalCoin3D.Scripts
{
    [CreateAssetMenu]
    public class IntVariable : ScriptableObject
    {
        public float InitialValue;
        public bool SetInitialValueOnEnable = true;
        public float Value { get; private set; }

        private void OnEnable()
        {
            if (SetInitialValueOnEnable) Value = InitialValue;
        }

        public void Increment()
        {
            Value++;
        }
    }
}

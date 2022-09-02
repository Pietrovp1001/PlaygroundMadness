using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace MinimalCoin3D.Scripts
{
    public class IntVariableText : MonoBehaviour
    {
        public IntVariable IntVariable;
        private Text _text;

        private void Awake()
        {
            _text = GetComponent<Text>();
        }

        private void Update()
        {
            _text.text = IntVariable.Value.ToString(CultureInfo.InvariantCulture);
        }
    }
}

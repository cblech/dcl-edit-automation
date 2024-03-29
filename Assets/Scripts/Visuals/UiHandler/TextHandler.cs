using System;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Visuals.UiHandler
{
    public class TextHandler : MonoBehaviour
    {
        public enum TextStyle
        {
            Normal,
            PrimarySelection,
            SecondarySelection,
            Disabled
        }

        [SerializeField]
        public TMP_ColorGradient NormalColorGradient;

        [SerializeField]
        public TMP_ColorGradient PrimaryColorGradient;

        [SerializeField]
        public TMP_ColorGradient SecondaryColorGradient;
        
        [SerializeField]
        public TMP_ColorGradient DisabledColorGradient;

        [Header("Scene References")]
        [SerializeField]
        public TextMeshProUGUI TextComponent;

        public string text
        {
            get => TextComponent.text;
            set => TextComponent.text = value;
        }

        public TextStyle textStyle
        {
            get
            {
                if (TextComponent.colorGradientPreset == NormalColorGradient)
                {
                    return TextStyle.Normal;
                }
                
                if (TextComponent.colorGradientPreset == PrimaryColorGradient)
                {
                    return TextStyle.PrimarySelection;
                }

                if (TextComponent.colorGradientPreset == SecondaryColorGradient)
                {
                    return TextStyle.SecondarySelection;
                }

                if (TextComponent.colorGradientPreset == DisabledColorGradient)
                {
                    return TextStyle.Disabled;
                }

                throw new ArgumentOutOfRangeException();
            }

            set => TextComponent.colorGradientPreset = value switch
            {
                TextStyle.Normal => NormalColorGradient,
                TextStyle.PrimarySelection => PrimaryColorGradient,
                TextStyle.SecondarySelection => SecondaryColorGradient,
                TextStyle.Disabled => DisabledColorGradient,
                _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
            };
        }
    }
}

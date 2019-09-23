﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Microsoft.MixedReality.Toolkit.Experimental.UI
{
    [RequireComponent(typeof(TMP_InputField))]
    public class TMP_KeyboardInputField : KeyboardInputFieldBase<TMP_InputField>
    {
#if WINDOWS_UWP
    protected override void ClearText() => inputField.text = string.Empty;
    protected override void UpdateText(string text) => inputField.text = text;
#endif

        protected override Graphic Text(TMP_InputField inputField) => inputField.textComponent;
        protected override Graphic PlaceHolder(TMP_InputField inputField) => inputField.placeholder;
    }
}
﻿using Neutronium.Core.WebBrowserEngine.JavascriptObject;
using Neutronium.MVVMComponents;

namespace Neutronium.Core.Binding.GlueObject.Mapped
{
    public class JsMappableSimpleCommand: JsSimpleCommand, IJsCsMappedBridge
    {
        private IJavascriptObject _MappedJsValue;

        public override IJavascriptObject CachableJsValue => _MappedJsValue;

        public void SetMappedJsValue(IJavascriptObject jsobject)
        {
            _MappedJsValue = jsobject;
            UpdateJsObject(_MappedJsValue);
        }

        public JsMappableSimpleCommand(HtmlViewContext context, IJavascriptToCSharpConverter converter, ISimpleCommand resultCommand)
            :base(context, converter, resultCommand)
        {
        }
    }
}
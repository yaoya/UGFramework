using System;

namespace UGFramework.Editor.Inspector
{
    [AttributeUsageAttribute(
        AttributeTargets.Property | AttributeTargets.Field, 
        Inherited = true, 
        AllowMultiple = false)]
    public class ShowInInspector : Attribute
    {
        bool _isReadonly = false;
        public bool IsReadonly 
        { 
            get
            {
                return _isReadonly;
            }
            set
            {
                _isReadonly = value;
            }
        }

        public ShowInInspector() {}
    }

    [AttributeUsageAttribute(
        AttributeTargets.Property | AttributeTargets.Field, 
        Inherited = true, 
        AllowMultiple = false)]
    public class InspectorTooltip : Attribute
    {
        public string Tooltip { get; private set; }
        public InspectorTooltip(string tooltip)
        {
            this.Tooltip = tooltip;
        }
    }
}
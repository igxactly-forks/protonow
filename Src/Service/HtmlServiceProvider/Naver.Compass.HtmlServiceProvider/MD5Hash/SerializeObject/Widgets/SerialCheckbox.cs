﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naver.Compass.Service.Document;
using System.Windows;

namespace Naver.Compass.Service.Html
{
    [Serializable]
    internal class SerialCheckbox : SerialWidgetBase
    {
        [NonSerialized]
        private ICheckbox _element;

        #region public interface functions
        public SerialCheckbox(ICheckbox wdg) : base(wdg)
        {
            _element = wdg;
            InitializeProperty();
        }

        public void Update(ICheckbox newWdg)
        {
            _element = newWdg;
            base.Update(newWdg);
            InitializeProperty();
        }
        #endregion

        #region private functions
        private void InitializeProperty()
        {
            ShapeType = _element.WidgetType;
            Tooltip = _element.Tooltip;
            IsDisabled = _element.IsDisabled;
            Name = _element.Name;

            Text = _element.Text;
            IsSelected=_element.IsSelected;
            AlignButton = _element.AlignButton;
        }

        #endregion

        #region Serialize Data
        public WidgetType ShapeType;
        public string Tooltip;
        public bool IsDisabled;
        public string Name;

        public string Text;
        public bool IsSelected;
        public AlignButton AlignButton;
        #endregion
    }
}

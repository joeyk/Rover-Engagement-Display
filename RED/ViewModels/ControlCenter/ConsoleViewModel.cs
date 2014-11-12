﻿namespace RED.ViewModels.ControlCenter
{
    using Caliburn.Micro;
    using Models.ControlCenter;
    using System;
    using System.Globalization;

    public class ConsoleViewModel : PropertyChangedBase
    {
        private readonly ConsoleModel _model = new ConsoleModel();

        public string ConsoleText
        {
            get
            {
                return _model.ConsoleText;
            }
            set
            {
                _model.ConsoleText = value;
                NotifyOfPropertyChange();
            }
        }

        public void WriteToConsole(string text)
        {
            var timeStamp = DateTime.Now.ToString("HH:mm:ss.ff", CultureInfo.InvariantCulture);
            var newText = String.Format("{0}: {1} {2}", timeStamp, text, Environment.NewLine);
            ConsoleText += newText;
        }
    }
}

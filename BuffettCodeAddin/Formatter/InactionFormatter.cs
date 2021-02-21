﻿namespace BuffettCodeAPIAdapter.Formatter
{
    /// <summary>
    /// 値をそのまま返すだけのフォーマッタ
    /// </summary>
    public class InactionFormatter : IFormatter
     {
        private static InactionFormatter _instance = new InactionFormatter();

        public static InactionFormatter GetInstance()
        {
            return _instance;
        }

        /// <inheritdoc/>
        public string Format(string value, PropertyDescrption description)
        {
            return value;
        }

        private InactionFormatter()
        {
            // do nothing.
        }

    }
}

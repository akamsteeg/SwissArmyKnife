using System;
using System.Text;

namespace SwissArmyKnife
{
    /// <summary>
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Appends a line by processing a composite format string, which
        /// contains zero of more format items
        /// </summary>
        /// <param name="provider">
        /// An object that supplies culture-specific formatting information
        /// </param>
        /// <param name="format">
        /// A composite format string
        /// </param>
        /// <param name="args">
        /// An object array that contains zero or more objects to format
        /// </param>
        public static StringBuilder AppendFormatLine(this StringBuilder sb, IFormatProvider provider, string format, params object[] args)
        {
            sb.AppendFormat(provider, format, args);
            return sb.AppendLine();
        }

        /// <summary>
        /// Appends a line by processing a composite format string, which
        /// contains zero of more format items
        /// </summary>
        /// <param name="format">
        /// A composite format string
        /// </param>
        /// <param name="arg0">
        /// The object to format
        /// </param>
        public static StringBuilder AppendFormatLine(this StringBuilder sb, string format, object arg0)
        {
            sb.AppendFormat(format, arg0);
            return sb.AppendLine();
        }

        /// <summary>
        /// Appends a line by processing a composite format string, which
        /// contains zero of more format items
        /// </summary>
        /// <param name="format">
        /// A composite format string
        /// </param>
        /// <param name="arg0">
        /// The first object to format
        /// </param>
        /// <param name="arg1">
        /// The second object to format
        /// </param>
        public static StringBuilder AppendFormatLine(this StringBuilder sb, string format, object arg0, object arg1)
        {
            sb.AppendFormat(format, arg0, arg1);
            return sb.AppendLine();
        }

        /// <summary>
        /// Appends a line by processing a composite format string, which
        /// contains zero of more format items
        /// </summary>
        /// <param name="format">
        /// A composite format string
        /// </param>
        /// <param name="arg0">
        /// The first object to format
        /// </param>
        /// <param name="arg1">
        /// The second object to format
        /// </param>
        /// <param name="arg2">
        /// The third object to format
        /// </param>
        public static StringBuilder AppendFormatLine(this StringBuilder sb, string format, object arg0, object arg1, object arg2)
        {
            sb.AppendFormat(format, arg0, arg1, arg2);
            return sb.AppendLine();
        }

        /// <summary>
        /// Appends a line by processing a composite format string, which
        /// contains zero of more format items
        /// </summary>
        /// <param name="provider">
        /// An object that supplies culture-specific formatting information
        /// </param>
        /// <param name="format">
        /// A composite format string
        /// </param>
        /// <param name="args">
        /// An object array that contains zero or more objects to format
        /// </param>
        public static StringBuilder AppendFormatLine(this StringBuilder sb, string format, params object[] args)
        {
            sb.AppendFormat(format, args);
            return sb.AppendLine();
        }
    }
}

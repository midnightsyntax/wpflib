using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLib.Windows
{
    public static class WindowEvents
    {
        /// <summary>
        /// Contains information about the new size of a resized Window.
        /// </summary>
        public struct WindowResizedEventArgs
        {
            /// <summary>
            ///The new width of the Window.
            /// </summary>
            public readonly double Width;

            /// <summary>
            /// The new height of the Window.
            /// </summary>
            public readonly double Height;

            public WindowResizedEventArgs(double width, double height)
            {
                Width = width;
                Height = height;
            }
        }

        /// <summary>
        /// Contains information about where a Window has been moved to.
        /// </summary>
        public struct WindowMovedEventArgs
        {
            /// <summary>
            /// Horizontal coordinate (x) of the window position.
            /// </summary>
            double X;

            /// <summary>
            /// Vertical coordinate (y) of the window position.
            /// </summary>
            double Y;

            public WindowMovedEventArgs(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
    }
}

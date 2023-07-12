using Android.Util;
using Android.Content.Res;
using AndroidGraphics = Android.Graphics;
using AndroidView = Android.Views;
using AndroidPlatform = Microsoft.Maui.Controls.Compatibility.Platform;

namespace MauiApp1.Platforms.Android
{
    public class ViewHelper : IViewHelper
    {
        /// <summary>
        /// Gets view position rectangle
        /// </summary>
        /// <param name="view">View</param>
        /// <returns>Position rectangle</returns>
        public Rect GetViewGlobalRectangle(View view)
        {
            //Approach#1
            var nativeView = AndroidPlatform.Android.Platform.GetRenderer(view)?.View;
            var viewRectangle = new AndroidGraphics.Rect();
            if (nativeView != null && nativeView.GetGlobalVisibleRect(viewRectangle))
            {

            }

            //Approach#2
            var renderer = AndroidPlatform.Android.Platform.GetRenderer(view);
            if (renderer == null)
            {
                renderer = AndroidPlatform.Android.Platform.CreateRendererWithContext(view, MauiApplication.Context); //Crash here
                AndroidPlatform.Android.Platform.SetRenderer(view, renderer);
            }

            return new Rect();
        }
       }
}

using Android.OS;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class LockActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            // содержимое опущено для краткости
            base.OnCreate(savedInstanceState);

            // определяем графический интерфейс окна приложения
            this.CreatePlatformWindow(MauiApplication.Current.Application, savedInstanceState);
        }
    }
}

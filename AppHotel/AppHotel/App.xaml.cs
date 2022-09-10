using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppHotel.View;
using System.Collections.Generic;
using AppHotel.Model;
using System.Threading;
using System.Globalization;

namespace AppHotel
{
    public partial class App : Application
    {
        public List<Suite> Suites = new List<Suite>
        {
            new Suite()
            {
               Descricao = "Deluxe",
               DiariaAdulto = 110.0,
               DiariaCrianca = 55.0
            },
            new Suite()
            {
               Descricao = "Executive",
               DiariaAdulto = 90.0,
               DiariaCrianca = 45.0
            },
            new Suite()
            {
               Descricao = "Economic",
               DiariaAdulto = 45.0,
               DiariaCrianca = 20.0
            }
        };
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new Protegida());
            else
                MainPage = new NavigationPage(new Login());
        }

        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "fanizzi@etec",
                Nome = "Fanizzi",
                Senha = "123"
            },
            new DadosUsuario()
            {
                Email = "prof@etec",
                Nome = "Professor",
                Senha = "123"
            }
        };

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

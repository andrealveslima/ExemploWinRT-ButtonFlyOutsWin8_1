using GalaSoft.MvvmLight;
using System;

namespace ExemploWinRT_ButtonFlyOutsWin8_1.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// O nome que foi informado pelo usuário.
        /// </summary>
        private string _nome;
        /// <summary>
        /// O nome que foi informado pelo usuário.
        /// </summary>
        public string Nome
        {
            get { return _nome; }
            set 
            { 
                _nome = value;
                RaisePropertyChanged();
            }
        }
        /// <summary>
        /// Comando que mostra o nome que foi informado pelo usuário em uma caixa de diálogo.
        /// </summary>
        public GalaSoft.MvvmLight.Command.RelayCommand MostrarNome { get; private set; }

        /// <summary>
        /// Inicializa uma nova instância da classe MainViewModel.
        /// </summary>
        public MainViewModel()
        {
            MostrarNome = new GalaSoft.MvvmLight.Command.RelayCommand(async () => await new Windows.UI.Popups.MessageDialog(_nome, "Nome digitado").ShowAsync());
        }
    }
}
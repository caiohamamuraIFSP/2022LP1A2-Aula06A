using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_02CollectionView.ViewModel
{
    partial class AppViewModel : ObservableObject
    {
        [ObservableProperty]
        string item;

        [ObservableProperty]
        ObservableCollection<string> lista = new ObservableCollection<string>()
        {
            "Item 1",
            "Outro item"
        };

        [RelayCommand]
        void Adiciona(string valor)
        {
            Lista.Add(valor);
            Item = "";
        }

        [RelayCommand]
        void Limpar()
        {
            Lista.Clear();
        }
    }
}

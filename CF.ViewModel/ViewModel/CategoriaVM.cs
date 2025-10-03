using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CF.Domain.Interfaces.ViewModel;

namespace CF.ViewModel.ViewModel
{
    public class CategoriaVM : ViewModelBase, ICategoriaVM 
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (_nome != value)
                {
                    _nome = value;
                    OnPropertyChanged(); 
                }
            }
        }

        private string _mensagemStatus;
        public string MensagemStatus
        {
            get { return _mensagemStatus; }
            set
            {
                if (_mensagemStatus != value)
                {
                    _mensagemStatus = value;
                    OnPropertyChanged(); 
                }
            }
        }

        public CategoriaVM()
        {
            Nome = "Nova Categoria";
            MensagemStatus = "Pronto.";
        }
    }
}

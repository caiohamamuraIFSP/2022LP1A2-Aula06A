using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_CampoCalculado
{
    partial class MeuViewModel: ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Metros))]
        double? pes = 5;

        public double? Metros
        {
            get { return Pes * 0.3048;  }
            set
            {
                Pes = value / 0.3048;
            }
        }
    }
}

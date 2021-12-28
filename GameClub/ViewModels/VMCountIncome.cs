using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using System.Collections.ObjectModel;
using BLL.Interfaces;

namespace GameClub.ViewModels
{
    public class VMCountIncome : VMBase
    {
        private readonly IIncomeCount incomeCounter;

        private DateTime startDT;
        public DateTime StartDT
        {
            get { return startDT; }
            set
            {
                startDT = value;
                OnPropertyChanged("StartDT");
            }
        }

        private DateTime finishDT;
        public DateTime FinishDT
        {
            get { return finishDT; }
            set
            {
                finishDT = value;
                OnPropertyChanged("FinishDT");
            }
        }

        private ObservableCollection<IncomeCountModel> incomeCount;
        public ObservableCollection<IncomeCountModel> IncomeCount
        {
            get { return incomeCount; }
            set
            {
                incomeCount = value;
                OnPropertyChanged("IncomeCount");
            }
        }

        private IncomeCountModel selectedIncome;
        public IncomeCountModel SelectedIncome
        {
            get { return selectedIncome; }
            set
            {
                selectedIncome = value;
                OnPropertyChanged("SelectedSalary");
            }
        }

        private RelayCommand countIncome;
        public RelayCommand CountIncome
        {
            get
            {
                return countIncome ?? (countIncome = new RelayCommand(obj =>
                {
                    IncomeCount = new ObservableCollection<IncomeCountModel>(incomeCounter.CountIncome(startDT, finishDT));
                },
                    (obj) => (startDT < finishDT && startDT != null & finishDT != null)));
            }
        }

        public VMCountIncome()
        {
            incomeCounter = BLL.ServiceModules.IoC.Get<IIncomeCount>();
            FinishDT = DateTime.Today;
            StartDT = new DateTime(FinishDT.Year, FinishDT.Month, 1);
        }

    }
}

using ViewModel.Data.Implementation;

namespace Admin.ViewModel
{
    public class ButikDataViewModel : DataViewModelBase<Butik>
    {
        public ButikDataViewModel(Butik obj) : base(obj)
        {
        }

        public int ButikID
        {
            get { return DataObject.ButikId; }
        }

        public string Adresse
        {
            get { return DataObject.Adresse; }
        }

        public string Tlf
        {
            get { return DataObject.Tlf; }
        }
        public override string ToString()
        {
            return $"{ButikID}";
        }
    }
}
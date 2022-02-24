using Archive.Core;

namespace Archive.Models
{
    public class LoadDocumentsModel : ObservableObject
    {
        private string _selectedPath;
        private int _documentGeneralCount;
        private int _progressValue;


        public LoadDocumentsModel()
        {
            _selectedPath = string.Empty;
        }


        public string SelectedPath
        {
            get { return _selectedPath; }
            set
            {
                _selectedPath = value;
                OnPropertyChanged("SelectedPath");
            }
        }

        public int DocumentGeneralCount
        {
            get { return _documentGeneralCount; }
            set
            {
                _documentGeneralCount = value;
                OnPropertyChanged("DocumentGeneralCount");
            }
        }

        public int ProgressValue
        {
            get { return _progressValue; }
            set
            {
                _progressValue = value;
                OnPropertyChanged("ProgressValue");
            }
        }
    }
}

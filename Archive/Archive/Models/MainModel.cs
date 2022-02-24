using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

using Archive.Core;
using Archive.EFCore.Models;

namespace Archive.Models
{
    public class MainModel : ObservableObject
    {
        private ObservableCollection<Document> _documents;
        private ObservableCollection<Document> _findedDocuments;
        private string _summary;


        public MainModel()
        {
            Documents = new ObservableCollection<Document>();
            FindedDocuments = new ObservableCollection<Document>();
        }


        public ObservableCollection<Document> Documents
        {
            get { return _documents; }
            set
            {
                _documents = value;
                OnPropertyChanged("Documents");
            }
        }

        public ObservableCollection<Document> FindedDocuments
        {
            get { return _findedDocuments; }
            set
            {
                _findedDocuments = value;
                OnPropertyChanged("FindedDocuments");
            }
        }

        public string Summary
        {
            get { return _summary; }
            set
            {
                _summary = value;
                OnPropertyChanged("Summary");
            }
        }
    }
}

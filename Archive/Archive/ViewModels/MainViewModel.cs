using System.Windows;

using Archive.Core;
using Archive.Views;
using Archive.Services;
using Archive.Models;
using Archive.EFCore.Models;
using System.Windows.Controls;
using System.Collections.Generic;

namespace Archive.ViewModels
{
    public enum SearchMode
    {
        AtDocumentText,
        ByDocumentTitle,
        ByKeyWords
    }

    public class MainViewModel : ObservableObject
    {
        private readonly SearchService _searchService;
        private SearchMode _searchMode;


        private MainViewModel()
        {
            _searchMode = SearchMode.AtDocumentText;

            _searchService = new SearchService();

            OpenLoadDocumentWindowCommand           = new RelayCommand(OpenLoadDocumentWindow);
            ShowApllicationInfoCommand              = new RelayCommand(ShowApllicationInfo);
            PushDocumentToResponseTreeViewCommand   = new RelayCommand(PushDocumentToResponseTreeView);
            ShowChosenDocumentSummaryCommand        = new RelayCommand(ShowChosenDocumentSummary);
            ShowAllDocumentsFromDbCommand           = new RelayCommand(ShowAllDocumentsFromDb);
            SetSearchModeCommand                    = new RelayCommand(SetSearchMode);
            StartSearchCommand                      = new RelayCommand(StartSearch, CanStartSearch);

            Model = new MainModel();
            ShowAllDocumentsFromDb();
        }

        public MainViewModel(Main mainWindow) : this()
        {
            View = mainWindow;
        }


        public RelayCommand OpenLoadDocumentWindowCommand { get; }

        public RelayCommand ShowApllicationInfoCommand { get; }

        public RelayCommand PushDocumentToResponseTreeViewCommand { get; }

        public RelayCommand ShowChosenDocumentSummaryCommand { get; }

        public RelayCommand ShowAllDocumentsFromDbCommand { get; }

        public RelayCommand SetSearchModeCommand { get; }

        public RelayCommand StartSearchCommand { get; }


        public MainModel Model { get; }

        public Window View { get; }


        private void SetSearchMode(object parameter)
        {
            if (parameter is RadioButton button)
            {
                _searchMode = button.Content.ToString() switch
                {
                    "По заголовку" => SearchMode.ByDocumentTitle,
                    "По ключевым словам" => SearchMode.ByKeyWords,
                    _ => SearchMode.AtDocumentText
                };
            }
        }

        private void StartSearch(object parameter)
        {
            string searchRequest = parameter.ToString();

            Model.FindedDocuments.Clear();

            List<Document> findedDocuments = _searchMode switch
            {
                SearchMode.ByDocumentTitle => _searchService.SearchByTitle(searchRequest),
                SearchMode.ByKeyWords => _searchService.SearchByKeyWords(searchRequest),
                _ => _searchService.SearchAtDocumentText(searchRequest)
            };

            foreach (Document document in findedDocuments)
                Model.FindedDocuments.Add(document);
        }

        private bool CanStartSearch(object parameter)
        {
            return parameter is not null && !string.IsNullOrEmpty(parameter.ToString());
        }

        private void ShowApllicationInfo(object parameter)
        {
            string message = "Данная программа разработа под заказ для [ClentName]." +
                "\n\nИсполнитель: Студент ЛФ ПНИПУ Палин Никита\n\n\t\t© Silent Hill";

            _ = MessageBox.Show(message, "О программе",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void PushDocumentToResponseTreeView(object parameter)
        {
            if (parameter is Document document)
            {
                Model.FindedDocuments.Add(document);
            }
        }

        private void ShowChosenDocumentSummary(object parameter)
        {
            string text = string.Empty;

            if (parameter is Document document)
                text = document.Text;

            if (parameter is ReferenceDocument referenceDocument)
                text = referenceDocument.Text;

            Model.Summary = text;
        }

        private void OpenLoadDocumentWindow(object paramater)
        {
            LoadDocuments loadDocuments = new();
            loadDocuments.Owner = View;

            if (loadDocuments.ShowDialog() == true)
            {
                View.Focus();
                Model.FindedDocuments.Clear();
                ShowAllDocumentsFromDbCommand.Execute(null);
            }
        }

        private void ShowAllDocumentsFromDb(object parameter = null)
        {
            var documents = new DbService().GetAllDocuments();
            Model.Documents.Clear();

            foreach (var document in documents)
                Model.Documents.Add(document);
        }
    }
}

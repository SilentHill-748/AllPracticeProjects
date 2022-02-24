using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

using Archive.Core;
using Archive.Documents;
using Archive.Exceptions;
using Archive.Services;
using Archive.Models;

namespace Archive.ViewModels
{
    public class LoadDocumentsViewModel : ObservableObject
    {
        public LoadDocumentsViewModel()
        {
            LoadDocumentsModel = new LoadDocumentsModel();

            LoadFilesCommand    = new RelayCommand(LoadFilesAsync, CanLoadFiles);
            SelectFilesCommand  = new RelayCommand(SetRootPath);
            CancelCommand       = new RelayCommand(CloseView);
        }


        public Window View { get; set; }

        public RelayCommand SelectFilesCommand { get; }

        public RelayCommand LoadFilesCommand { get; }

        public RelayCommand CancelCommand { get; }


        public LoadDocumentsModel LoadDocumentsModel { get; }


        private void SetRootPath(object parameter)
        {
            using FolderBrowserDialog fbd = new();
            if (fbd.ShowDialog() is DialogResult.OK)
                LoadDocumentsModel.SelectedPath = fbd.SelectedPath;
        }

        private bool CanLoadFiles(object parameter)
        {
            return parameter is not null && !string.IsNullOrWhiteSpace(parameter.ToString());
        }

        private async void LoadFilesAsync(object parameter)
        {
            string pathToConfigFile = parameter.ToString() + "\\Конфиг.txt";
            
            try
            {
                if (!File.Exists(pathToConfigFile))
                    throw new ConfigFileNotFoundException($"Configuration file \'{pathToConfigFile}\' is not found!");

                ConfigParser parser = new(pathToConfigFile);

                LoadDocumentsModel.DocumentGeneralCount = parser.DocumentCount;

                await Task.Run(() =>
                {
                    DbService dbService = new();

                    DocumentBuilder builder = new();

                    builder.BuildedDocument += Builder_BuildedDocument;
                    builder.FromDocumentAttributes(parser.GetDocumentsWithAttributes());

                    dbService.AddDocuments(builder.BuildedDocuments);
                    dbService.UpdateRange(builder.BuildedDocuments);

                    builder = null;
                })
                    .ConfigureAwait(true);

                View.DialogResult = true;
                CloseView();
            }
            catch (Exception ex)
            {
                _ = System.Windows.MessageBox.Show("Текст ошибки:\n" + ex.Message);
            }
        }

        private void CloseView(object parameter = null)
        {
            View.Owner.Focus();
            View.Dispatcher.Invoke(View.Close);

            GC.Collect();
        }

        private void Builder_BuildedDocument(int step)
        {
            LoadDocumentsModel.ProgressValue += step;
        }
    }
}

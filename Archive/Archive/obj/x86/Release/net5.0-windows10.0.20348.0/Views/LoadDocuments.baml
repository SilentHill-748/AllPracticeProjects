   M S B A M L   `   `   `  ���� B  >Archive, Version=0.1.1.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Archive.ViewsArchive.Views  !    Archive.Views.LoadDocuments   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:Archive.Views       � Title$.  (Загрузить документы...�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ 	CanResize=�$��15(�$	��470��$	��140��.���  � RowDefinitions �� $��1* ��� $��1* �.+�� $��0�� � ColumnDefinitions �� $��0.25* ��� $��1* ��� $��0.05* ��� $��2* ��� $��0.25* � �� $
��0.5* ��� $��1* ��� $
��0.5* �.+��� -   $��SelectFilesButton��$��1��$��1��$"��Выбрать файлы...��$	��5 0q��� -   $��PathToFilesTextBlock��$��3��$��1�� �� 
IsReadOnly$
 True��
�������$��1q�$��12(�$��Center=�� $��1�� �� $��1* ��� $
��1.5* ��� $��2* ��� $
��1.5* ��� $��1* � �� $
��0.5* ��� $��1* ��� $
��0.5* �.+��� -   $��CancelButton��$��1��$��1��$��Отмена���� -   $��LoadFilesButton��$��3��$��1��$��Загрузить��
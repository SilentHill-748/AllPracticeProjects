   M S B A M L   `   `   `  ���� B  >Archive, Version=0.1.1.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ArchiveArchive      Archive.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Archive       � Title$%  Поиск документов��$	��527��$	��767�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$ ThreeDBorderWindow=�$��15(� � 
ResizeMode$ NoResize=� � Icon$ /Views/icon.png��.��� .+��� $%��Параметры поиска��$
��Left=�$	��Top=�$��
10,20,0,10q�
���   �$	��198��.����  �� Orientation$ Vertical=�$	��Top=�$��0q�.+��� $	��Top=�$��5q�
���   ��� $ Vertical=�$��5q�.+��� $��В документе��$��10,5,0,0q�$��13(��� $,��&В названии документа��$��10,5,0,0q�$��13(��� $(��"По ключевым словам��$��10,5,0,0q�$��13(��� -    ��Name$ 
_searchBut��$��
Найти��$��Right=�$��0,5,20,0q�$��	10,0,10,0q�${�False���� $(��"Список документов:��$��5,15,0,5q�$��0q��� $	��250��$��12(�$��5,0,5,5q�$	��Top=�
���   �o� $	��Top=�$��20��
�������.@�m� $��Файл��.@�m� -   $��LoadDocuments��$+��%Загрузить документы��m� $'��!Добавить документ��m� $%��Удалить документ��m� $��Настройка��.@�m� $��Тема��.@�m� -    m�Name$ _whiteThemeItem��$��Светлая��m� -   $ _darkThemeItem��$��Тёмная��m� $��Справка���� $%��Результат поиска��$��
213,20,0,0q�
���   �$	��Top=�$
��Left=�$	��196��$	��282��.��R� -    R�Name$ _resultOfSearchTreeView��
��������� $)��#Краткое содержание��$��213,216,0,0q�$
��Left=�$	��Top=�
���   �$	��259��$	��282���� $+��%Подборка документов��$��
500,20,0,0q�$
��Left=�$	��Top=�
���   �$	��455��$	��239��.���� $ Vertical=�$��5q�.+��� -   	 ��Name$	 _selectedDocuments��
���   �$	��418��$��12(�.@��� $��Амазония��
 � ContextMenu
 �� .@�m� $	��123��
   M S B A M L   `   `   `  ����B  >Archive, Version=0.1.1.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Archive.ViewsArchive.Views  5   	   !    Archive.Views.LoadDocuments   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Archive.Views     5   	     � Title$.  (Загрузить документы...��5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ 	CanResize=�5
   	   $��15(�5   	   $	��470��5   	   $	��140��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   � $��0��5       � ColumnDefinitions 5      �� 5      $��0.25* �6#   �� 5      $��1* �6#   �� 5      $��0.05* �6#   �� 5      $��2* �6#   �� 5      $��0.25* �6#    5      �� 5      $
��0.5* �6    �� 5       $��1* �6    �� 5!      $
��0.5* �6    .+�5$      �� -   5        $��SelectFilesButton��5'      $��1��5%      $��1��5&      $"��Выбрать файлы...��5(      $	��5 0q�5)      5*      �� 5,      -   5        $��PathToFilesTextBlock��5/      $��3��5-      $��1��5.       �� 
IsReadOnly$
 True��50      
�������$��1q�52      $��12(�53      $��Center=�54      55      � 57   
   $��1��58       59      �� 5:      $��1* �6#   �� 5;      $
��1.5* �6#   �� 5<      $��2* �6#   �� 5=      $
��1.5* �6#   �� 5>      $��1* �6#    5A      �� 5B      $
��0.5* �6    �� 5C      $��1* �6    �� 5D      $
��0.5* �6    .+�5G      �� -   5        $��CancelButton��5J      $��1��5H      $��1��5I      $��Отмена��5K      5L      �� 5N      -   5        $��LoadFilesButton��5Q      $��3��5O      $��1��5P      $��Загрузить��5R      5S      5T      5U      5V      
   M S B A M L   `   `   `  ����I  EUniversityInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:UniversityInfoUniversityInfo  5   	       UniversityInfo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:UniversityInfo     5   	     � Title$  UniversityInfo��5   	   $	��700��6    $
��1000��6-    � WindowStyle$ ThreeDBorderWindow=�5	   	    � 
ResizeMode$ CanMinimize=�5
   	   $��14(�5   	   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   � ���#7CBD40$��2��5       5      �� 5      6%   �� 5      6%   �� 5      6%   �� 5      6%   �� 5      6%   �� 5       6%   �� 5!      6%   �� 5"      6%   �� 5#      6%   �� 5$      6%   .+�5'      �� -   5         ��Name$ HomeBtn��5(      $��🎓 UNIVERSITY INFO��5'       � Cursor$
 Hand��5(   )   
�������$��Center=�5*      $��14(�5+      $
��Bold"�5,      $��3��6*   $��1��6?   $
��Left=�6O   6j   �� 5-      -   5        $ StudentsBtn��5-      $��Students��5.      
�������$��4��50      $��Center=�51      $��Center=�52      $
 Hand��53      6&   �� 54      -   5        $ EmployeesBtn��55      $��	Employees��54      
�������$��5��57      $��Center=�58      $��Center=�59      $
 Hand��5:      6&   �� 5;      -   5        $ 
ModulesBtn��5<      $��Modules��5;      
�������$��6��5>      $��Center=�5?      $��Center=�5@      $
 Hand��5A      6&   �� 5B      -   5        $ PositionsBtn��5C      $��	Positions��5B      
�������$��7��5E      $��Center=�5F      $��Center=�5G      $
 Hand��5H      6&   �� 5I      -   5        $ 	GradesBtn��5J      $��Grades��5I      
�������$��8��5L      $��Center=�5M      $��Center=�5N      $
 Hand��5O      6&   5P      � 5R   
   -   5         �Name$ GRID_CONTAINER��5R      $��1��6'   $��2��64    K� ZIndex$ -1��6H   .+�5T         UniversityInfo.Home  -   5        	  Name$
	 Home��5T   .   $y�Visible=�6   6>      UniversityInfo.Students  5U      -	   5        
  Name$
 Students��5U   4   $y�	Collapsed=�6   6H      UniversityInfo.Employees  5V      -
   5          Name$ 	Employees��5V   5   $y�	Collapsed=�6   6J      UniversityInfo.Modules  5W      -   5          Name$ Modules��5W   3   $y�	Collapsed=�6   6F      UniversityInfo.Positions  5X      -   5          Name$ 	Positions��5X   5   $y�	Collapsed=�6   6J      UniversityInfo.Grades  5Y      -   5          Name$ Grades��5Y   2   $y�	Collapsed=�6   6D   5Z      5\      5]      
   M S B A M L   `   `   `  ����D  @Algorithm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Algorithm.View.adminAlgorithm.View.admin  5      '    !Algorithm.View.admin.CoursesAdmin   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Algorithm.View.admin     5        N� Title$  CoursesAdmin��5
      .��5      �    GradientCatalog#���   6    � RowDefinitions 5   
   �� 5      $	��114 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Курсы:��5      $��36(�5      $��	80 20 0 0q�5        CatalogHeaders#���  5      �� 5   
   -   5        $��Добавить курс��5      $��0��5      $	��250��5      $��60��5      $��18(�5      $��	900 0 0 0q�5        LetsGoButton#���  5        
btTemplate#���  5       5!      �� 5#   
   -   5         ��Name$ CoursesList��5#      $��1��5$      $
��1320��5%      $	��Top=�5&      
������ $��0q�5(      $��Disabled=�5*      $
��Auto=�5+      ��5)      �� *	Courses+��5-      �� 5.       �� 
TargetType" ��6   .�51      -   5        �� 53       �� Property � �� �� Value$	 550��6.   �� 54       � ��$	 180��6/   �� 55       � ��
 ���� 63   �� 56       � ��$ Center=�6C   �� 57       � ��$ Center=�6A   �� 58       � ��$ 	20 0 0 50q�6/   �� 5:       � �� 5;      �� 5<       �� 
TargetType" ��6.   .R�5=   "   �� $��2q�6)   $��Center=�6=    �� CornerRadius$ 10��6Z   
���   ����#393C46._�5?   &   �� #��z��67   #��z��5@   +   #��z��5A   +   #��z��5B   +   5C   #   5D      5F       �� Triggers 5H      P� 5I      	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��69   . �5J      ��  � �� �#99A7B16<   �� 5K       � ��$ 4q�6@   �� 5L       �@J�Effect 5M   "   3  -System.Windows.Media.Effects.DropShadowEffect  5N   &      
BlurRadius$ 50Q�67      Color$ #99A7B1��6G      ShadowDepth$ 15Q�6W   5P      5Q      5T      ��5W      �� 5Y      .R�5[      �  � Orientation$ 
Horizontal=�6    $
��Left=�5\       $
��Auto��5]       ��5^       �� *ActualWidth+ �� ElementName$ CoursesList��5`      ��5d      �� 5f      .R�5j      �� $	��700��6!    �� Orientation$ 
Horizontal=�5l   %   .+�5n      �� $ Vertical=�6%   .+�5p      �� $	��150��6$   $	��130��5q   (   $��10q�5r   (   $��UniformToFill=�5s   (   ��5t   (   �� *IMAGE_SOURCE+�� 5v      $
��Wrap=�5w   ,   $��0 0 0 0q�5x   ,   $��Center=�5y   ,   
�������$��Roboto)�5{   ,   $��20(�5|   ,   $��Medium"�5}   ,   ��5v   (   �� *NAME+5}   ,   5      �� 5�      $ Vertical=�6%   $��	20 20 0 0q�5�   )   $	��325��5�   )   $	��180��5�   )   .+�5�      �� $	��325��5�   ,   $��60��5�   ,   
�������$
��Wrap=�5�   ,   $��Roboto)�5�   ,   $��18(�5�   ,   $��Regular"�5�   ,   ��5�   (   �� *DESCRIPTION+5�   ,   �� 5�      $ 
Horizontal=�6)   $	��325��5�   -   $	��150��5�   -   .+�5�   "   �� $��
Цена: ��6,   
�������$��Roboto)�5�   0   $��20(�5�   0   $��Center=�5�   0   $��0 0 0 20q�5�   0   $��Medium"�5�   0   �� 5�   "   
�������$��Roboto)�5�   0   $��20(�5�   0   $��	0 0 20 20q�5�   0   $��Center=�5�   0   $��Medium"�5�   0   ��5�   ,   �� *PRICE+$5�   G   5�      5�      5�      5�      5�      5�      5�      
   M S B A M L   `   `   `  ����D  @Algorithm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Algorithm.ViewAlgorithm.View  5          Algorithm.View.Courses   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Algorithm.View     5        N� Title$  Courses��5
      .��5      �    GradientCatalog#���   6    � RowDefinitions 5   
   �� 5      $	��114 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Курсы:��5      $��36(�5      $��	80 20 0 0q�5        CatalogHeaders#���  5      �� 5   
   -   5         ��Name$ CoursesList��5      $��1��5      $
��1320��5      $	��Top=�5      
������ $��0q�5      $��Disabled=�5       $
��Auto=�5!      ��5      �� *	Courses+��5#      �� 5$       �� 
TargetType" ��6   .�5'      ��  �� Property � �� �� Value$	 550��6.   �� 5(       � ��$	 180��6/   �� 5)       � ��
 ���� 63   �� 5*       � ��$ Center=�6C   �� 5+       � ��$ Center=�6A   �� 5,       � ��$ 	20 0 0 50q�6/   �� 5.       � �� 5/      �� 50       �� 
TargetType" ��6.   .R�51   "   �� $��2q�6)   $��Center=�6=    �� CornerRadius$ 10��6Z   
���   ����#393C46._�53   &   �� #��z��67   #��z��54   +   #��z��55   +   #��z��56   +   57   #   58      5:       �� Triggers 5<      P� 5=      	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��69   . �5>      ��  � �� �#99A7B16<   �� 5?       � ��$ 4q�6@   �� 5@       �@J�Effect 5A   "   3  -System.Windows.Media.Effects.DropShadowEffect  5B   &      
BlurRadius$ 50Q�67      Color$ #99A7B1��6G      ShadowDepth$ 15Q�6W   5D      5E      5H      ��5K      �� 5M      .R�5O      �  � Orientation$ 
Horizontal=�6    $
��Left=�5P       $
��Auto��5Q       ��5R       �� *ActualWidth+ �� ElementName$ CoursesList��5T      ��5X      �� 5Z      .R�5^      �� $	��700��6%    �� Orientation$ 
Horizontal=�5`   %   .+�5b      �� $ Vertical=�6)   .+�5d   "   �� $	��150��6(   $	��130��5e   (   $��10q�5f   (   $��UniformToFill=�5g   (   ��5h   (   �� *IMAGE_SOURCE+�� 5j   "   $
��Wrap=�5k   ,   $��0 0 0 0q�5l   ,   $��Center=�5m   ,   
�������$��Roboto)�5o   ,   $��20(�5p   ,   $��Medium"�5q   ,   ��5j   ,   �� *NAME+5q   ,   5s      �� 5u      $ Vertical=�6)   $��	20 20 0 0q�5v   )   $	��325��5w   )   $	��180��5x   )   .+�5z   "   �� $	��325��5{   ,   $��60��5|   ,   
�������$
��Wrap=�5~   ,   $��Roboto)�5   ,   $��18(�5�   ,   $��Regular"�5�   ,   ��5z   ,   �� *DESCRIPTION+5�   ,   �� 5�   "   $ 
Horizontal=�6-   $	��325��5�   -   $	��150��5�   -   .+�5�   &   �� $��
Цена: ��60   
�������$��Roboto)�5�   0   $��20(�5�   0   $��Center=�5�   0   $��0 0 0 20q�5�   0   $��Medium"�5�   0   �� 5�   &   
�������$��Roboto)�5�   0   $��20(�5�   0   $��	0 0 20 20q�5�   0   $��Center=�5�   0   $��Medium"�5�   0   ��5�   0   �� *PRICE+$5�   G   �� 5�   &    ��Name$ 	ButtonBuy��6-   -   5        $��Купить��5�   -   $	��175��5�   -   $��50��5�   -   $��20(�5�   -   $��0 0 0 20q�5�   -   $��Center=�5�   -     LetsGoButton#���  5�   -     
btTemplate#���  5�   -   5�   -   5�   #   5�      5�      5�      5�      5�      5�      
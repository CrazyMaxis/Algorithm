   M S B A M L   `   `   `  ����D  @Algorithm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Algorithm.View.adminAlgorithm.View.admin  5      )    #Algorithm.View.admin.QuestionsAdmin   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Algorithm.View.admin     5        N� Title$  QuestionsAdmin��5
      .��5      �    GradientProfile#���   6    � RowDefinitions 5   
   �� 5      $	��114 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Вопросы:��5      $��36(�5      $��	80 20 0 0q�5        CatalogHeaders#���  5      �� 5   
   -   5         ��Name$ QuestionsList��5      $��1��5      $
��1220��5      
������ $��0q�5      $	��Top=�5      $��Disabled=�5       $
��Auto=�5!      ��5      �� *	Questions+��5#      �� 5$       �� 
TargetType" ��6   .�5&      ��  �� Property � �� �� Value
 ���� 63   �� 5'       � ��$ Center=�6C   �� 5(       � ��$ Center=�6A   �� 5)       � ��$ 20 0 0 0q�6/   �� 5+       � �� 5,      �� 5-       �� 
TargetType" ��6.   .R�5.   "   �� $��2q�6)   $��Center=�6=   
���   �#��z��6n   ._�5/   &   �� #��z��67   #��z��50   +   #��z��51   +   #��z��52   +   53   #   54      56       �� Triggers 58      P� 59       P� Property �@J�IsMouseOver	 P� Value$
	 True��69   . �5:      ��  � �� �#99A7B16<   �� 5;       � ��$ 4q�6@   �� 5<       �@J�Effect 5=   "   3  -System.Windows.Media.Effects.DropShadowEffect  5>   &   
   
BlurRadius$
 50Q�67      Color$ #99A7B1��6G      ShadowDepth$ 15Q�6W   5@      5A      5C      ��5F      �� 5H      .R�5J      �  � Orientation$ 
Horizontal=�6    $��0 0 0 50q�5K       $
��Left=�5L       $
��Auto��5M       ��5N       �� *ActualWidth+ �� ElementName$ QuestionsList��5P      ��5T      �� 5V      .R�5X      �� $
��1100��6!    �� Orientation$ 
Horizontal=�5Y   !   .+�5[      �� $	��200��6%   .+�5]      �� $��0 10 0 0q�6(   $
��Wrap=�5^   $   $��Center=�5_   $   $��Roboto)�5`   $   $
��Bold"�5a   $   $��18(�5b   $   
�������$!��ID пользователя��5d   $   �� 5f      $��0 20 0 0q�6(   $
��Wrap=�5g   $   $��Center=�5h   $   $��Roboto)�5i   $   $��Medium"�5j   $   $��24(�5k   $   
���������5m   $   �� *	ID_USER+5o      �� 5q      $	��690��6%   $��20 0 0 0q�5r   %   $��Center=�5s   %   .+�5u      �� $��0 10 0 0q�6(   $
��Wrap=�5v   $   $��Center=�5w   $   $��Roboto)�5x   $   $
��Bold"�5y   $   $��18(�5z   $   
�������$��Вопрос��5|   $   �� 5~      $��0 10 0 0q�6(   $
��Wrap=�5   $   $��Center=�5�   $   $��Roboto)�5�   $   $��Medium"�5�   $   $��16(�5�   $   
���������5�   $   �� *
QUESTION+5�      �� 5�      -   5        $��Ответить��5�   !   $	��180��5�      $��50��5�      $��18(�5�      $��0 0 0 0q�5�        LetsGoButton#���  5�        
btTemplate#���  5�      5�      5�      5�      5�      5�      5�      
   M S B A M L   `   `   `  ����D  @Algorithm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Algorithm.ViewAlgorithm.View  5          Algorithm.View.Tests   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Algorithm.View     5      -   5          N�Name$  	TestsPage��5       N� Title$ Tests��5      .��5      �    GradientProfile#���   6    � RowDefinitions 5   
   �� 5      $	��114 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Тесты:��5      $��36(�5      $��	80 20 0 0q�5        CatalogHeaders#���  5      �� 5   
   -   5         ��Name$ 	TestsList��5      $��1��5      $
��1220��5      $	��Top=�5      
������ $��0q�5       $��Disabled=�5"      $
��Auto=�5#      ��5!      �� *Tests+��5%      �� 5&       �� 
TargetType" ��6   .�5(      -   5        �� 5*       �� Property � �� �� Value
 ���� 63   �� 5+       � ��$ Center=�6C   �� 5,       � ��$ Center=�6A   �� 5-       � ��$ 20 0 0 0q�6/   �� 5/       � �� 50      �� 51       �� 
TargetType" ��6.   .R�52   "   �� $��0q�6)   $��Center=�6=   
������ #��z��6t   ._�53   &   �� #��z��67   #��z��54   +   #��z��55   +   #��z��56   +   57   #   58      5:       �� Triggers 5<      P� 5=      	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��69   . �5>      ��  � �� �#99A7B16<   �� 5?       � ��$ 4q�6@   �� 5@       �@J�Effect 5A   "   3  -System.Windows.Media.Effects.DropShadowEffect  5B   &      
BlurRadius$ 50Q�67      Color$ #99A7B1��6G      ShadowDepth$ 15Q�6W   5D      5E      5G      ��5J      �� 5L      .R�5N      �  � Orientation$ 
Horizontal=�6    $��0 0 0 50q�5O       $
��Left=�5P       $
��Auto��5Q       ��5R       �� *ActualWidth+ �� ElementName$ 	TestsList��5T      ��5X      �� 5Z      .R�5^      �� $	��250��6%   .+�5`      �� $	��200��6$   $	��170��5a       $��0q�5b       $
��Fill=�5c       ��5d       �� *IMAGE_SOURCE+�� 5f      $��0 10 0 0q�6(   $
��Wrap=�5g   $   $��Center=�5h   $   $��Roboto)�5i   $   $��Medium"�5j   $   $��16(�5k   $   
���������5m   $   �� *NAME+5o      5r      5v      5x      5z      
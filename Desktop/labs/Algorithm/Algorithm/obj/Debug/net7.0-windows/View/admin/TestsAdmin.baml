   M S B A M L   `   `   `  ����D  @Algorithm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Algorithm.View.adminAlgorithm.View.admin  5      %    Algorithm.View.admin.TestsAdmin   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Algorithm.View.admin     5        N� Title$  
TestsAdmin��5
      .��5      �    GradientProfile#���   6    � RowDefinitions 5   
   �� 5      $	��114 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Тесты:��5      $��36(�5      $��	80 20 0 0q�5        CatalogHeaders#���  5      �� 5   
   -   5        $��Добавить тест��5      $��0��5      $	��250��5      $��60��5      $��18(�5      $��	900 0 0 0q�5        LetsGoButton#���  5        
btTemplate#���  5       5!      �� 5#   
   -   5         ��Name$ 	TestsList��5#      $��1��5$      $
��1220��5%      
������ $��0q�5'      $	��Top=�5(      $��Disabled=�5*      $
��Auto=�5+      ��5)      �� *Tests+��5-      �� 5.       �� 
TargetType" ��6   .�50      -   5        �� 52       �� Property � �� �� Value
 ���� 63   �� 53       � ��$ Center=�6C   �� 54       � ��$ Center=�6A   �� 55       � ��$ 20 0 0 0q�6/   �� 57       � �� 58      �� 59       �� 
TargetType" ��6.   .R�5:   "   �� $��0q�6)   $��Center=�6=   
������ #��z��6t   ._�5;   &   �� #��z��67   #��z��5<   +   #��z��5=   +   #��z��5>   +   5?   #   5@      5B       �� Triggers 5D      P� 5E       P� Property �@J�IsMouseOver	 P� Value$
	 True��69   . �5F      ��  � �� �#99A7B16<   �� 5G       � ��$ 4q�6@   �� 5H       �@J�Effect 5I   "   3  -System.Windows.Media.Effects.DropShadowEffect  5J   &   
   
BlurRadius$
 50Q�67      Color$ #99A7B1��6G      ShadowDepth$ 15Q�6W   5L      5M      5O      ��5R      �� 5T      .R�5V      �  � Orientation$ 
Horizontal=�6    $��0 0 0 50q�5W       $
��Left=�5X       $
��Auto��5Y       ��5Z       �� *ActualWidth+ �� ElementName$ 	TestsList��5\      ��5`      �� 5b      .R�5f      �� $	��250��6!   .+�5h      �� $	��200��6    $	��170��5i       $��0q�5j       $
��Fill=�5k       ��5l       �� *IMAGE_SOURCE+�� 5n      $��0 10 0 0q�6$   $
��Wrap=�5o   $   $��Center=�5p   $   $��Roboto)�5q   $   $��Medium"�5r   $   $��16(�5s   $   
���������5u   $   �� *NAME+5w      5z      5~      5�      5�      
   M S B A M L   `   `   `  ����D  @Algorithm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Algorithm.ViewAlgorithm.View  5          Algorithm.View.Profile   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Algorithm.View     5      -   5          N�Name$  ProfilePage��5       N� Title$ Profile��5      .��5      �    GradientProfile#���   6   .+�5   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��Center=�5      $��0 100 550 30q�5      .+�5      �� $	��225��5      $	��225��5      ��5      �� *User.IMAGE_SOURCE+5      �� 5      
�������$��Roboto)�5      $��52(�5      $
��Bold"�5      $��55��5      $��30 0 0 0q�5       ��5      �� *
User.LOGIN+5       5"      �� 5$      $-��'Изменить изображение��6   $	��300��5%      $��60��5&      $��22(�5'      $��	0 0 540 0q�5(        LetsGoButton#���  5)        
btTemplate#���  5*      ��5+      �� *ChangeImage+�� 5-      $ 
Horizontal=�6   $��	0 175 0 0q�5.      $��65��5/      $
��1050��50      .+�52      �� $	��800��53      $��60��54        BorderForTextBox#���  55      ._�56      � .+�57      �� -   5         ��Name$ Question��57   &     TextBoxRegister#���  58   &   $��20 0 0 0q�59   &   5:   &   �� 5;      -   5         ��Name$ QuestionPlug��5;   (   $��Ваш вопрос...��5<   (    �� Padding$ 20 0 0 0q�5=   (     TextBlockPlug#���  5>   (   5?      5@      �� 5B      $��Отправить��6   $	��200��5C      $��60��5D      $��22(�5E      $��50 0 0 0q�5F      #���  5G      #���  5H      ��5I      �� *DataContext.AddQuestion+ �� RelativeSource ��  �� AncestorType Page��5J      ��  �� ElementName$ ProfilePage��5L      5N      �� 5P   
   $��300 0 0 120q�6   $	��400��5Q      $��1��5R        Line#���  5S      �� 5U   
   $	��450��6   $	��400��5V      $��Right=�5W      $��	0 0 100 0q�5X      .+�5Z      �� $ 
Horizontal=�6   $��0 25 0 0q�5[      .+�5]      �� $��Level: ��6   $��30(�5^      $
��Bold"�5_      $��Roboto)�5`      
�������5a      �� 5c      $��30(�5d      $
��Bold"�5e      $��Roboto)�5f      
���������5c      �� *
User.LEVEL+5g      5i      �� 5k      $ 
Horizontal=�6   $��0 75 0 0q�5l      .+�5n      �� $-��'Алгоритмов пройдено: ��6   $��30(�5o      $
��Bold"�5p      $��Roboto)�5q      
�������5r      �� 5t      $��30(�5u      $
��Bold"�5v      $��Roboto)�5w      
���������5t      �� *CountAlgorithms+5x      5z      �� 5|      $ 
Horizontal=�6   $��0 75 0 0q�5}      .+�5      �� $#��Курсов куплено: ��6   $��30(�5�      $
��Bold"�5�      $��Roboto)�5�      
�������5�      �� 5�      $��30(�5�      $
��Bold"�5�      $��Roboto)�5�      
���������5�      �� *CountCourses+5�      5�      5�      5�      5�      
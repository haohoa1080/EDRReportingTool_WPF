   M S B A M L   `   `   `  ����O  KEDRReportingTool_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EDRReportingTool_WPFEDRReportingTool_WPF  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5
   	   %    EDRReportingTool_WPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:EDRReportingTool_WPF     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5
   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   .��5      ]� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $	��Top=�5         Mode$ 
PrimaryMid=�5      $��16q�5      .��5      ]� .+�5      d� -   5        $��ckbCDCustReport��5       * &MaterialDesignSwitchAccentToggleButton#��[ 5      $��Center=�5      $��Right=�5      5      �� 5       �� Orientation$ 
Horizontal=�5      +  %MaterialDesignThemes.Wpf.RippleAssist   
IsCentered . .+�5!      d�  ' #MaterialDesignHamburgerToggleButton#���  5"   	     5$      $ Standard=�5%   	   $��8 4 8 4q�5&   	      CornerRadius$ 2��5'   	    K� ZIndex$ 1��5(   	   $��16 0 0 0q�5)   	   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5*   	   .��5+      � 	 � RowDefinitions	 5,      �� 5-   "   $��0* �60   �� 5.   "   
 � ColumnDefinitions
 50      �� 51   "   $��* �52   !   �� 53   "   $
��Auto �54   !   .+�57      �� -   5        $��txtPath��5?      $��0��58      $��8,4,0,4q�59      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Drag and Drop txt or xml file��5:      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5;      $��0q�5<      $	��200��5=      $��Center=�5>      $��2��68   .��5?   ,   C:\Users\user\Desktop\a.xml5A      �� 5B      -   5        $��1��5C   !     MaterialDesignToolButton#���  5D      $��2��6@   .��5F   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Magnify=�5G       J� Opacity$	 .56Q�5H      5I      5K      5L      �� 5M      -   5        $��btnRun��5Q       & "MaterialDesignToolForegroundButton#���  5N      $��8 0 0 0q�5O      $ 0��5P      .��5R        $
 Send=�62   5S      �� 5T      -   5        $��
cbbProject��5Z      $ Select project��5U      $��0q�5V      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Standard=�5W         UnderlineBrush# �  5X      #���  5Y      5\      �� 5]      -   5        $��cbbType��5]      5`      5a      5b      5d      � 5e   
   
 5f      �� 5g      $��3* �6#   �� 5h      $��5* �6#   .+�5j      ]� .+�5k      #	  LiveCharts.Wpf.CartesianChart	  &
   LiveCharts.Wpf.Charts.Base.Chart 
  LegendLocation$ Right=�6I    
  Series 6%   �� *SeriesCollection+ 
  AxisY 5m        LiveCharts.Wpf.Axis     Title$ Sales��6#      LabelFormatter 61   �� *
YFormatter+6Y    
  AxisX 5p        $ Month��6#      Labels 61   �� *Labels+6M   5r      5s      ]� 5t      $��1��6   .+�5u      �� -   5        $��	txtFilter��5x   	   $	��Top=�5v   	   $ Filter��5w   	   5y   	   &   System.Windows.Controls.DataGrid  5z      -   5        $��dataGridView1��5�         CanUserAddRows .     SelectionUnit$
 Cell=�5}         SelectionMode$ Extended=�5~         AutoGenerateColumns .     Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$
 EDID��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *EDID+  5�      $
 Name��6-    6;   �� *Name+  5�      $ Value��6-    6<   �� *Value+  5�      $ Length��6-    6=   �� *Length+ �� 
GroupStyle 5�      (  "System.Windows.Controls.GroupStyle  5�          ContainerStyle  5�      �� 5�   "   ! �� 
TargetType"! ��6(   .�5�   &   �� " �� Property" � ��# �� Value# 5�   *   �� 5�   .   .R�5�   2   9� $ 9� 
IsExpanded$ . ��5�   6   �� 5�   :   $ 
Horizontal=�6E   .+�5�   >   �� $
��Bold"�6^   
�������$��22(�6�   $��Bottom=�6�   ��6H   �� *Name+6�   �� 5�   >   $��22(�6c   
��� � �$
��Bold"�6�   $��Italic$�6�   $��10,0,0,0q�6�   $��Bottom=�6�   ��6H   �� *	ItemCount+6�   �� 5�   >   $�� item(s)��6H   $��22(�6X   
�������$��Italic$�6z   $��Bottom=�6�   5�   ;   .��5�   6   �� 5�   3   5�   /   5�   '   5�   #   5�      5�      5�      5�      5�      5�      
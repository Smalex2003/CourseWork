   M S B A M L   `   `   `  ????E  ACourseWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CourseWork.WindowsCourseWork.Windows  5   	   $    CourseWork.Windows.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CourseWork.Windows     5   	     ? Title$%  Окно регистрации??5   
   $	??800??6#   $	??700??60   ???#D6D7C7.??5	      ? .+?5
   
   ?? $X??RЗдесь вы можете редактировать пользователей??6   $??Center=?6F   $	??Top=?6c   $??Comic Sans MS)?6{   $??20(?6?   $
??Bold"?6?   $??0,10,0,0q?6?   ?? 5   
   -   5         ??Name$ BackBtn??5      ???#FFFF$??Закрыть окно??65   $
??Left=?6L   $??
10,723,0,0q?6g   $	??Top=?6{   ???#929594$??Comic Sans MS)?6?   $??25(?6?   $??Normal"?6?   $	??177??6?   ?? 5   
   $S??Mи просматривать фотографии из базы данных??6   $??Center=?6D   $	??Top=?6a   $??Comic Sans MS)?6y   $??20(?6?   $
??Bold"?6?   $??0,48,0,0q?6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	UsersGrid??5         AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   $??Comic Sans MS)?6d   $	??690??6   $	??300??6?   $??
0,92,0,392q?6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id??6%      Width$ 30 61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6<   ?? *Id+  5      $ 
Логин??6%   $ 70 64   	 6?   ?? *Login+  5      $ Пароль??6%   $ 70 65   	 6@   ?? *
Password+  5      $ Эл.почта??6%   	 67   ?? *Email+  5      $ Роль??6%   $ 50 63   	 6>   ?? *Role+  5      $ Занятый объем??6%   	 6<   ?? *	Storage+  5      $) #Максимальный объем??6%   	 6A   ?? *
MaxStorage+4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      ?? 5      .R?5      ?? $ EditBtn??6%   -   5        ???#fffcd6$ ??Редактировать??5   K   6{   5      5        5      
 5      ?? 5      .R?5       ?? $ 	DeleteBtn??6%   -   5        ???#fffcd6$??Удалить??5    M   6y   5!      5#      5%        5&   
   -   5        $ 	PhotoGrid??5&       .   . $ * 6T   $??Comic Sans MS)?6d   $	??690??6   $	??290??6?   $??
0,410,0,74q?6?    5'        5(      $ 30 6%   $ Id??60   	 6<   ?? *Id+  5)      $ 
Объем??6%   $ 70 64   	 6?   ?? *Size+  5*      $ Формат??6%   $ 60 65   	 6@   ?? *Format+  5+      $ Название??6%   	 67   ?? *Name+  5,      $ Дата добав.??6%   	 6;   ?? *	AddTime+  5-      $ Фото??6%   	 63   ?? *Photo1+  5.      
 5/      ?? 50      .R?51      ?? $ DeletePhotoBtn??6%   -   5        ???#fffcd6$??Удалить??51   R   6d   52      54      56      57      58      
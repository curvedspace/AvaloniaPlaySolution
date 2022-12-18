# AvaloniaPlaySolution
A space for Avalonia testing

This project is trying to use a ComboBox that is bound to a list of objects. The selected object in the ComboBox should be bound 
to one of these objects in a main data record but I can't seem to get the binding to work. Not sure if this is a bug or I am 
doing something wrong.

Here is the output. The DataContext gets set I can see in the debugger that DataRecord object is as expected.  Other bindings to 
a TextBox and DatePicker work as expected, just not the ComboBox.

MainWindow: DataContext has been set.<br>
MainWindow: MyComboBox Name = MyComboBox <br>
MainWindow: MyComboBox SelectedItem is NULL <br>
MainWindowViewModel: MyRecord.MyCodeTable = Item 2 <br>
App: DataContext has been set. <br>
App: MyComboBox Name = MyComboBox <br>
MainWindow: MyComboBox SelectedItem is NULL <br>

<br>
In the Assets folder there are a couple of screenshots showing the problem.

![Output image](/PlaySolution/Assets/avalonia_combobox_bug_output_2022-12-18_09-52.png)

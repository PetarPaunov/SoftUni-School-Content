# GUI "Currency Converter" App
Simple **Windows Forms App** C# implementation of **Currency Converter**

<img alt="Image" src="https://user-images.githubusercontent.com/85368212/169101075-ae783a55-9c39-4ec4-9013-d246f2c26b03.png" />

This is a **graphical application** (GUI application) that **calculates** the value in **Euro** (EUR) of **monetary** amount given in **Bulgarian levs** (BGN). By **changing** the amount in **BGN**, the amount in **EUR** has to be **recalculated** after clicking on the button **Convert** (used a fixed rate BGN / EUR: 1.95583).

## Settings of the Format and the Separate Controls

| Setting                         |  Picture                 |
| --------------------------------|:------------------------:| 
| **FormConverter**:<br>Text = "CurrencyConverter",<br>Font.Size = 12,<br>MaximizeBox = False,<br>MinimizeBox = False,<br>FormBorderStyle = FixedSingle<br>|               ![Screenshot_2](https://user-images.githubusercontent.com/85368212/170478030-3256c9d5-60d8-4a92-aa60-a59928d06cf1.png)                  
| **numericUpDownAmount**:<br>Value = 1, <br>Minimum = -10000,<br> Maximum = 10000,<br>TextAlign = Left,<br>DecimalPlaces = 2<br>                    |                     ![Screenshot_3](https://user-images.githubusercontent.com/85368212/170480739-ead56633-afd2-4168-9a5d-fdf775a4bf05.png)
| **resultButton**:<br>Text = "Convert",<br>Size = Width:94, Height:29<br>               |                                                                                 ![Screenshot_4](https://user-images.githubusercontent.com/85368212/170480991-a3bd4ea6-e6d3-402e-ac40-f0239adfed41.png)
| **resultLable**:<br>AutoSize = False,<br>BackColor = PaleGreen,<br>Font.Size = 14,<br>Font.Bold = true<br>TextAlign = MiddleCenter,<br>|                                 ![Screenshot_5](https://user-images.githubusercontent.com/85368212/170481087-52654e32-dd34-4cae-981f-ffe76dcfec02.png)



## Input and Output
 - Enter the amount for conversion
    - The amount is fixed, it can be between `-10000` and `10000`
 - The application will show the result after conversion

[Form Source Core](ConvertionForm.cs)

## Screenshots

![Screenshot_1](https://user-images.githubusercontent.com/85368212/170481680-258801e2-e182-4210-bfcc-ae8f1a7f37fd.png)

![Screenshot_2](https://user-images.githubusercontent.com/85368212/170481693-0e900872-6762-4f10-881b-ae30401a4dec.png)

![Screenshot_3](https://user-images.githubusercontent.com/85368212/170481705-0c03518a-e402-4446-86fb-15dc8d762d61.png)


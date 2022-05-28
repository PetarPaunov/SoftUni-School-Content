# GUI "Currency Converter" App
Simple **Windows Forms App** C# implementation of **Currency Converter**

<img alt="Image" src="https://user-images.githubusercontent.com/85368212/169101075-ae783a55-9c39-4ec4-9013-d246f2c26b03.png" />


This is a **graphical application** (GUI application) that **calculates** the value in **Euro** (EUR) of **monetary** amount given in **Bulgarian levs** (BGN). By **changing** the amount in **BGN**, the amount in **EUR** has to be **recalculated** after clicking on the button **Convert** (used a fixed rate BGN / EUR: 1.95583).

## Settings of the Format and the Separate Controls

| Setting                         |  Picture                 |
| --------------------------------|:------------------------:| 
| **FormConverter**:<br>Text = "CurrencyConverter",<br>Font.Size = 12,<br>MaximizeBox = False,<br>MinimizeBox = False,<br>FormBorderStyle = FixedSingle<br>|               <img alt="Image" width="400" src="https://user-images.githubusercontent.com/85368212/170547642-d30f7845-3a77-4265-81f7-f0d16846d399.png" />                
| **numericUpDownAmount**:<br>Value = 1, <br>Minimum = -10000,<br> Maximum = 10000,<br>TextAlign = Left,<br>DecimalPlaces = 2<br>                    |                     <img alt="Image" width="200" src="https://user-images.githubusercontent.com/85368212/170549033-4fb214e8-8338-4c8b-9c4c-26c7ba025519.png" />   
| **resultButton**:<br>Text = "Convert",<br>Size = Width:94, Height:29<br>               |                                                                                 <img alt="Image" width="125" src="https://user-images.githubusercontent.com/85368212/170549441-a131ea85-54d6-4641-9ba6-fc33b806d841.png" />   
| **resultLable**:<br>AutoSize = False,<br>BackColor = PaleGreen,<br>Font.Size = 14,<br>Font.Bold = true<br>TextAlign = MiddleCenter,<br>|                                 ![Screenshot_5](https://user-images.githubusercontent.com/85368212/170481087-52654e32-dd34-4cae-981f-ffe76dcfec02.png)



## Input and Output
 - Enter the amount for conversion
    - The amount is fixed, it can be between `-10000` and `10000`
 - The application will show the result after conversion

[Form Source Core](ConvertionForm.cs)

## Screenshots
<kbd>![Screenshot_1](https://user-images.githubusercontent.com/85368212/170481680-258801e2-e182-4210-bfcc-ae8f1a7f37fd.png)</kbd>

<kbd>![Screenshot_2](https://user-images.githubusercontent.com/85368212/170481693-0e900872-6762-4f10-881b-ae30401a4dec.png)</kbd>

<kbd><img alt="Image" width="380" src="https://user-images.githubusercontent.com/85368212/170550465-c5b72fd1-3157-489b-910e-e89d179a07ee.png" /></kbd>


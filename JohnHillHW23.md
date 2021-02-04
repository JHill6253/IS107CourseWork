## John Hill Assignment 23
### IS 107
 1. (T/F) When developing a Visual Basic program, the event procedure code must be 	written before the controls are added to the form. 
    
    **Answer:**   False
 2. Which form property stores the word(s) that would appear in a form’s title bar? 

    **Answer:** Text Property 

3. What effect will the following statement have on lblOne? 
    ```visualbasic
        lblOne.Visible = False 
    ```
    **Answer:** lblOne wil be hidden from the user 

4. What code would be used to change the color of the letters in lblName to red? 

    **Answer:** lblName.ForeColor = Color.Red

5. What statement removes all text from a list box namedlstBox? 

    **Answer:**
    ```visualbasic 
        namedlstBox.items.clear()
    ```

6. (T/F) 1040Bis a valid variable name? 

    **Answer:** No, VB naming conventions require a letter or _ at the start. Numbers are invalid at the start 

7. What is output in the list box after executing the following code:
    ```visualbasic
        Dim a, b As Integer 
        a = 4 
        b = 5 * a 
        lstOutput.Items.Add((a+b) Mod 5) 
    ```
    **Answer:**  (4+20)/5= 4 rm 4; **4**
8. What is output in the list box after executing the following code: 
    ```visualbasic
        Dim x As Integer = 2 
        Dim y As Integer = 3 
        x *= y 
        y = 5 
        x = x + y + 4 
        lstOutput.Items.Add(Math.Sqrt(x + 1)) 
    ```
    **Answer:** sqrt of 16 = **4**
9. In which of the following lines of code is there an error? 
    ```visualbasic
        Dim interest, balance As Decimal 
        0.05D = interest 
        balance = 347.12D 
        lstOutput.Items.Add(interest * balance) 
    ```
    **Answer:** Line 2, the variable needs to be interst = 0.05D not the reverse. 
10. The data entered in a form’s text box are always stored in which data type? 
    **Answer:** Text/String 
11.	Given the following code, what is displayed in the text box after the button is clicked? 
    ```visualbasic
        Private Sub btnOutput_Click ( ... ) Handles btnOutput.Click 
            txtBox.Text = “Goodbye” 
            txtBox.Text = “Hello”  
        End Sub 
    ```
    **Answer:** Initally the value will be "goodbye" and then will switch to "Hello"
12.	What is displayed in the list box after executing the following statement: 
    ```visualbasic
        lstBox.Items.Add(“s” & “t”) 
    ```
    **Answer:** Will concate the two strings, thus the output would be "st"
13.	What index number would be used to access the last letter in the string value “abcdefg”? 
    **Answer:** The index value would be -1. Because the value is stored as a string, we would need to break that sting into a char array thus the code would look like the following: 
    ```visualbasic
        char foo = barr(barr.Length -1)
14.	What will be output by the following statement? 
    ```visualbasic
        txtBox.Text = (1234.56789).ToString("N3") 
    ```
    **Answer:** 1,234.568 the N3 call is defining what formatting of the string we would like to use thus the decimals are rounded and a comma is added. 
15.	Assume that a date variable named firstDay has been declared. What statement would assign the date for the first day of the year 2021 to firstDay? 

    **Answer:** 
    ```visualbasic 
        firstDay = #1/1/2021#
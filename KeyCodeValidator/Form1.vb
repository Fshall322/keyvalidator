Public Class Form1
    ' Key code : B2eBf-R9IRc-N9oNb-A2AAj-I9aIb

    Private Sub NoOfTries()
        'Accumilator to keep track the number of validation tries so the program closes after 2 tries..
        Me.lblNoOfTriesOutput.Text = Val(Me.lblNoOfTriesOutput.Text) + 1
        If Me.lblNoOfTriesOutput.Text = 2 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Call NoOfTries()
        'Code that limits the characters that can be entered in the subcripts of the textbox.
        If (Me.txtKeyBox1.Text Like "[B,R,I,A,N][2,9][A,a,E,e,I,i,O,o,U,u]?[a-j]" And _
            Me.txtKeyBox2.Text Like "[B,R,I,A,N][2,9][A,a,E,e,I,i,O,o,U,u]?[a-j]" And _
            Me.txtKeyBox3.Text Like "[B,R,I,A,N][2,9][A,a,E,e,I,i,O,o,U,u]?[a-j]" And _
            Me.txtKeyBox4.Text Like "[B,R,I,A,N][2,9][A,a,E,e,I,i,O,o,U,u]?[a-j]" And _
            Me.txtKeyBox5.Text Like "[B,R,I,A,N][2,9][A,a,E,e,I,i,O,o,U,u]?[a-j]") Then

            'Code that shows a messagebox when you input the correct key code.
            MessageBox.Show("Correct Key, you may proceed")
            Form2.Show()
            Me.Hide()
        Else
            'Code that shows a messagebox when you input the wrong key code.
            MessageBox.Show("Incorrect, please try again")
        End If
        'Code That closes the program once the 2 try limit is reached.
    End Sub

    Private Sub NextTextBox1()
        'Procedure that moves the cursor to the next text box in line, once the user has reached the max possible charcters in the text box.
        If Me.txtKeyBox1.TextLength = 5 Then
            Me.txtKeyBox2.Focus()
        Else
            Me.txtKeyBox1.Focus()
        End If
    End Sub

    Private Sub NextTextBox2()
        'Procedure that moves the cursor to the next text box in line, once the user has reached the max possible characters in the text box.
        If Me.txtKeyBox2.TextLength = 5 Then
            Me.txtKeyBox3.Focus()
        Else
            Me.txtKeyBox2.Focus()
        End If
    End Sub

    Private Sub NextTextBox3()
        'Procedure that moves the cursor to the next text box in line, once the user has reached the max possible characters in the text box.
        If Me.txtKeyBox3.TextLength = 5 Then
            Me.txtKeyBox4.Focus()
        Else
            Me.txtKeyBox3.Focus()
        End If
    End Sub

    Private Sub NextTextBox4()
        'Procedure that moves the cursor to the next text box in line, once the user has reached the max possible characters in the text box.
        If Me.txtKeyBox4.TextLength = 5 Then
            Me.txtKeyBox5.Focus()
        Else
            Me.txtKeyBox4.Focus()
        End If
    End Sub


    Private Sub txtKeyBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeyBox1.KeyPress
        'Code that prevents characters such as "?", "&" into the text boxes.
        If Asc(e.KeyChar) >= 32 And Asc(e.KeyChar) <= 48 Then
            e.Handled = True
            MessageBox.Show("You can only enter Letters and numbers")
        Else : e.Handled = False
            If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 64 Then
                e.Handled = True
                MessageBox.Show("You can only enter Letters and numbers")
            Else : e.Handled = False
                If Asc(e.KeyChar) >= 90 And Asc(e.KeyChar) <= 96 Then
                    e.Handled = True
                    MessageBox.Show("You can only enter Letters and numbers")
                Else : e.Handled = False
                    If Asc(e.KeyChar) >= 123 And Asc(e.KeyChar) <= 127 Then
                        e.Handled = True
                        MessageBox.Show("You can only enter Letters and numbers")
                    Else : e.Handled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtKeyBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeyBox2.KeyPress
        'Code that prevents characters such as "?", "&" into the text boxes.
        If Asc(e.KeyChar) >= 32 And Asc(e.KeyChar) <= 48 Then
            e.Handled = True
            MessageBox.Show("You can only enter Letters and numbers")
        Else : e.Handled = False
            If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 64 Then
                e.Handled = True
                MessageBox.Show("You can only enter Letters and numbers")
            Else : e.Handled = False
                If Asc(e.KeyChar) >= 90 And Asc(e.KeyChar) <= 96 Then
                    e.Handled = True
                    MessageBox.Show("You can only enter Letters and numbers")
                Else : e.Handled = False
                    If Asc(e.KeyChar) >= 123 And Asc(e.KeyChar) <= 127 Then
                        e.Handled = True
                        MessageBox.Show("You can only enter Letters and numbers")
                    Else : e.Handled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtKeyBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeyBox3.KeyPress
        'Code that prevents characters such as "?", "&" into the text boxes.
        If Asc(e.KeyChar) >= 32 And Asc(e.KeyChar) <= 48 Then
            e.Handled = True
            MessageBox.Show("You can only enter Letters and numbers")
        Else : e.Handled = False
            If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 64 Then
                e.Handled = True
                MessageBox.Show("You can only enter Letters and numbers")
            Else : e.Handled = False
                If Asc(e.KeyChar) >= 90 And Asc(e.KeyChar) <= 96 Then
                    e.Handled = True
                    MessageBox.Show("You can only enter Letters and numbers")
                Else : e.Handled = False
                    If Asc(e.KeyChar) >= 123 And Asc(e.KeyChar) <= 127 Then
                        e.Handled = True
                        MessageBox.Show("You can only enter Letters and numbers")
                    Else : e.Handled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtKeyBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeyBox4.KeyPress
        'Code that prevents characters such as "?", "&" into the text boxes.
        If Asc(e.KeyChar) >= 32 And Asc(e.KeyChar) <= 48 Then
            e.Handled = True
            MessageBox.Show("You can only enter Letters and numbers")
        Else : e.Handled = False
            If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 64 Then
                e.Handled = True
                MessageBox.Show("You can only enter Letters and numbers")
            Else : e.Handled = False
                If Asc(e.KeyChar) >= 90 And Asc(e.KeyChar) <= 96 Then
                    e.Handled = True
                    MessageBox.Show("You can only enter Letters and numbers")
                Else : e.Handled = False
                    If Asc(e.KeyChar) >= 123 And Asc(e.KeyChar) <= 127 Then
                        e.Handled = True
                        MessageBox.Show("You can only enter Letters and numbers")
                    Else : e.Handled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtKeyBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeyBox5.KeyPress
        'Code that prevents characters such as "?", "&" into the text boxes.
        If Asc(e.KeyChar) >= 32 And Asc(e.KeyChar) <= 48 Then
            e.Handled = True
            MessageBox.Show("You can only enter Letters and numbers")
        Else : e.Handled = False
            If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 64 Then
                e.Handled = True
                MessageBox.Show("You can only enter Letters and numbers")
            Else : e.Handled = False
                If Asc(e.KeyChar) >= 90 And Asc(e.KeyChar) <= 96 Then
                    e.Handled = True
                    MessageBox.Show("You can only enter Letters and numbers")
                Else : e.Handled = False
                    If Asc(e.KeyChar) >= 123 And Asc(e.KeyChar) <= 127 Then
                        e.Handled = True
                        MessageBox.Show("You can only enter Letters and numbers")
                    Else : e.Handled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtKeyBox1_TextChanged(sender As Object, e As EventArgs) Handles txtKeyBox1.TextChanged
        'Code To limit max characters in a textbox
        Me.txtKeyBox1.MaxLength = 5
        'Calling the procedure that moves the cursor to the next textbox in line once max characters have been reached.
        Call NextTextBox1()
    End Sub

    Private Sub txtKeyBox2_TextChanged(sender As Object, e As EventArgs) Handles txtKeyBox2.TextChanged
        'Code To limit max characters in a textbox
        Me.txtKeyBox2.MaxLength = 5
        'Calling the procedure that moves the cursor to the next textbox in line once max characters have been reached.
        Call NextTextBox2()
    End Sub

    Private Sub txtKeyBox3_TextChanged(sender As Object, e As EventArgs) Handles txtKeyBox3.TextChanged
        'Code To limit max characters in a textbox
        Me.txtKeyBox3.MaxLength = 5
        'Calling the procedure that moves the cursor to the next textbox in line once max characters have been reached.
        Call NextTextBox3()
    End Sub

    Private Sub txtKeyBox4_TextChanged(sender As Object, e As EventArgs) Handles txtKeyBox4.TextChanged
        'Code To limit max characters in a textbox
        Me.txtKeyBox4.MaxLength = 5
        'Calling the procedure that moves the cursor to the next textbox in line once max characters have been reached.
        Call NextTextBox4()
    End Sub

    Private Sub txtKeyBox5_TextChanged(sender As Object, e As EventArgs) Handles txtKeyBox5.TextChanged
        'Code To limit max characters in a textbox
        Me.txtKeyBox5.MaxLength = 5
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Code that closes the program once Exit is chosen on the menu strip.
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Code that clears all text boxes once the clear button is pressed.
        Me.txtKeyBox1.Text = ""
        Me.txtKeyBox2.Text = ""
        Me.txtKeyBox3.Text = ""
        Me.txtKeyBox4.Text = ""
        Me.txtKeyBox5.Text = ""
    End Sub
End Class

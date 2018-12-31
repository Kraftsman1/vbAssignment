Public Class Form1
    Private Sub Styles_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.ComboBox1.SelectedIndex = 0 Then

        End If
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        TextBox1.Text = NumericUpDown1.Value.ToString * 50
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.Add("Regular Shades")
        Me.ComboBox1.Items.Add("Folding Shades")
        Me.ComboBox1.Items.Add("Roman Shades")
        Me.ComboBox2.Items.Add("25 inches wide")
        Me.ComboBox2.Items.Add("27 inches wide")
        Me.ComboBox2.Items.Add("32 inches wide")
        Me.ComboBox2.Items.Add("40 inches wide")
        Me.ComboBox3.Items.Add("Natural")
        Me.ComboBox3.Items.Add("other")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.SelectedIndex = 0 Then
            Label5.Text = FormatNumber(5.0 * Val(NumericUpDown1.Value), 2)
        ElseIf Me.Combobox1.SelectedIndex = 1 Then
            Label5.Text = FormatNumber(10.0 * Val(NumericUpDown1.Value), 2)
        ElseIf Me.ComboBox1.SelectedIndex = 2 Then
            Label5.Text = FormatNumber(15.0 * Val(NumericUpDown1.Value), 2)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Me.ComboBox2.SelectedIndex = 0 Then
            Label6.Text = FormatNumber(1.0 * Val(NumericUpDown1.Value), 2)
        ElseIf Me.ComboBox2.SelectedIndex = 1 Then
            Label6.Text = FormatNumber(2.0 * Val(NumericUpDown1.Value), 2)
        ElseIf Me.ComboBox2.SelectedIndex = 2 Then
            Label6.Text = FormatNumber(4.0 * Val(NumericUpDown1.Value), 2)
        ElseIf Me.ComboBox2.SelectedIndex = 3 Then
            Label6.Text = FormatNumber(6.0 * Val(NumericUpDown1.Value), 2)
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Me.ComboBox3.SelectedIndex = 0 Then
            Label7.Text = FormatNumber(5.0 * Val(NumericUpDown1.Value), 2)
        ElseIf Me.ComboBox3.SelectedIndex = 1 Then
            Label7.Text = FormatNumber(6.0 * Val(NumericUpDown1.Value), 2)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NumericUpDown1.Value = "0"
        TextBox1.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
    End Sub

    Private Sub TotalCharges_Click(sender As Object, e As EventArgs) Handles TotalCharges.Click
        Form2.TextBox1.Text = Val(Label5.Text) + Val(Label6.Text) + Val(Label7.Text)
        Form2.Label11.Text = FormatNumber(5.0 * Val(NumericUpDown1.Value), 2)
        Form2.ShowDialog()



    End Sub

End Class

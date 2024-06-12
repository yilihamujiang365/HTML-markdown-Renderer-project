Imports System.IO
Imports System.Text
Imports Markdig

Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await WebViewmarkdown.EnsureCoreWebView2Async(Nothing)
        Await WebViewHTML.EnsureCoreWebView2Async(Nothing)
        OpenFileDialog1.Filter = "HTML文件(*.html)|*.html"
        SaveFileDialog1.Filter = "HTML文件(*.html)|*.html"
        OpenFileDialog2.Filter = "MarkDown文件(*.md)|*.md"
        SaveFileDialog2.Filter = "MarkDown文件(*.md)|*.md"
        Me.Text = My.Application.Info.ProductName + String.Format("版本 {0}", My.Application.Info.Version.ToString)
    End Sub


    Private Sub RichTextBoxHTML_Textchanged(sender As Object, e As EventArgs) Handles RichTextBoxHTML.TextChanged
        Dim HTMLcontent As String = RichTextBoxHTML.Text
        WebViewHTML.NavigateToString(HTMLcontent)
    End Sub
    Private Sub RichTextBoxmarkdown_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxmarkdown.TextChanged
        Dim Markdowncontent As String = RichTextBoxmarkdown.Text
        Dim markdownHTMLcontent As String = Markdown.ToHtml(Markdowncontent)
        WebViewmarkdown.NavigateToString(markdownHTMLcontent)
    End Sub

    Private Sub 修改网页渲染编辑器字体选项ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改网页渲染编辑器字体选项ToolStripMenuItem.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            ' 如果用户选择了字体，设置RichTextBox的字体
            RichTextBoxHTML.Font = FontDialog1.Font
        End If
    End Sub








    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        ' 检查RichTextBox1和RichTextBox2是否为空
        If String.IsNullOrWhiteSpace(RichTextBoxHTML.Text) AndAlso String.IsNullOrWhiteSpace(RichTextBoxmarkdown.Text) Then
            ' 如果两个RichTextBox都是空的，关闭窗体
            Me.Close()
        Else
            ' 如果至少有一个RichTextBox不是空的，显示提醒信息
            MessageBox.Show("请确认所有内容已清除后再关闭。")
        End If

    End Sub
    Private closeConfirmed As Boolean = False

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' 如果用户已经确认关闭，则允许关闭
        If closeConfirmed Then
            Return
        End If

        ' 检查RichTextBox1和RichTextBox2是否为空
        If String.IsNullOrWhiteSpace(RichTextBoxHTML.Text) AndAlso String.IsNullOrWhiteSpace(RichTextBoxmarkdown.Text) Then
            ' 如果两个RichTextBox都是空的，允许关闭
            e.Cancel = False
        Else
            ' 如果至少有一个RichTextBox不是空的，显示提醒信息
            Dim result As DialogResult = MessageBox.Show("所有内容未清除，确定要关闭吗?", "确认关闭", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ' 如果用户确认关闭，设置标志并再次尝试关闭窗口
                closeConfirmed = True
                Me.Close()
            Else
                ' 如果用户取消关闭，取消关闭事件
                e.Cancel = True
            End If
        End If
    End Sub





    Private Sub 关于此程序ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于此程序ToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub 网页渲染器DevToolsToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 网页渲染器DevToolsToolToolStripMenuItem.Click
        WebViewHTML.CoreWebView2.OpenDevToolsWindow()
    End Sub

    Private Sub MarkDown渲染器DevToolsToolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkDown渲染器DevToolsToolToolStripMenuItem.Click
        WebViewmarkdown.CoreWebView2.OpenDevToolsWindow()
    End Sub

    Private Sub 修改MarkDown渲染编辑器字体选项ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改MarkDown渲染编辑器字体选项ToolStripMenuItem.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            ' 如果用户选择了字体，设置RichTextBox的字体
            RichTextBoxmarkdown.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub 保存HTML文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存HTML文件ToolStripMenuItem.Click
        ' 显示 SaveFileDialog
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            ' 将 RichTextBox 的内容转换为 HTML 并保存到文件
            saveashtml(RichTextBoxHTML.Text, SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub Saveashtml(content As String, filepath As String)
        '将文本内容转换为简单的 html 格式
        Dim htmlcontent As String = "<html><body><pre>" & content.Replace(vbCrLf, "<br>") & "</pre></body></html>"

        '将 html 内容写入到文件
        System.IO.File.WriteAllText(filepath, htmlcontent)
    End Sub



    Private Sub 打开HTML文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开HTML文件ToolStripMenuItem.Click
        ' 显示 OpenFileDialog
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' 尝试以 UTF-8 编码读取文件内容
            Try
                Using reader As New StreamReader(OpenFileDialog1.FileName, Encoding.UTF8)
                    RichTextBoxHTML.Text = reader.ReadToEnd()
                End Using
            Catch ex As Exception
                ' 如果 UTF-8 编码失败，尝试使用系统默认编码
                Using reader As New StreamReader(OpenFileDialog1.FileName)
                    RichTextBoxHTML.Text = reader.ReadToEnd()
                End Using
            End Try
        End If
    End Sub

    Private Sub 打开MarkDown文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开MarkDown文件ToolStripMenuItem.Click
        ' 显示 OpenFileDialog
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            ' 尝试以 UTF-8 编码读取文件内容
            Try
                Using reader As New StreamReader(OpenFileDialog2.FileName, Encoding.UTF8)
                    RichTextBoxmarkdown.Text = reader.ReadToEnd()
                End Using
            Catch ex As Exception
                ' 如果 UTF-8 编码失败，尝试使用系统默认编码
                Using reader As New StreamReader(OpenFileDialog2.FileName)
                    RichTextBoxmarkdown.Text = reader.ReadToEnd()
                End Using
            End Try
        End If
    End Sub

    Private Sub 保存MarkDown文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存MarkDown文件ToolStripMenuItem.Click
        If SaveFileDialog2.ShowDialog() = DialogResult.OK Then
            ' 保存 RichTextBox2 的内容为 Markdown 文件
            System.IO.File.WriteAllText(SaveFileDialog2.FileName, RichTextBoxmarkdown.Text)
        End If
    End Sub
End Class
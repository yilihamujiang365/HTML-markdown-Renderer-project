<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.FontDialog2 = New System.Windows.Forms.FontDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开HTML文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存HTML文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.选项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改网页渲染编辑器字体选项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改MarkDown渲染编辑器字体选项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Webview选项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.网页渲染器DevToolsToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkDown渲染器DevToolsToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于此程序ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RichTextBoxHTML = New System.Windows.Forms.RichTextBox()
        Me.WebViewHTML = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.RichTextBoxmarkdown = New System.Windows.Forms.RichTextBox()
        Me.WebViewmarkdown = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.打开MarkDown文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存MarkDown文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.WebViewHTML, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.WebViewmarkdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.选项ToolStripMenuItem, Me.Webview选项ToolStripMenuItem, Me.关于ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(876, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开ToolStripMenuItem, Me.保存ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.文件ToolStripMenuItem.Text = "文件"
        '
        '打开ToolStripMenuItem
        '
        Me.打开ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开HTML文件ToolStripMenuItem, Me.打开MarkDown文件ToolStripMenuItem})
        Me.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem"
        Me.打开ToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.打开ToolStripMenuItem.Text = "打开"
        '
        '打开HTML文件ToolStripMenuItem
        '
        Me.打开HTML文件ToolStripMenuItem.Name = "打开HTML文件ToolStripMenuItem"
        Me.打开HTML文件ToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.打开HTML文件ToolStripMenuItem.Text = "打开HTML文件"
        '
        '保存ToolStripMenuItem
        '
        Me.保存ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存HTML文件ToolStripMenuItem, Me.保存MarkDown文件ToolStripMenuItem})
        Me.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem"
        Me.保存ToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.保存ToolStripMenuItem.Text = "保存"
        '
        '保存HTML文件ToolStripMenuItem
        '
        Me.保存HTML文件ToolStripMenuItem.Name = "保存HTML文件ToolStripMenuItem"
        Me.保存HTML文件ToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.保存HTML文件ToolStripMenuItem.Text = "保存HTML文件"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '选项ToolStripMenuItem
        '
        Me.选项ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.修改网页渲染编辑器字体选项ToolStripMenuItem, Me.修改MarkDown渲染编辑器字体选项ToolStripMenuItem})
        Me.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem"
        Me.选项ToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.选项ToolStripMenuItem.Text = "选项"
        '
        '修改网页渲染编辑器字体选项ToolStripMenuItem
        '
        Me.修改网页渲染编辑器字体选项ToolStripMenuItem.Name = "修改网页渲染编辑器字体选项ToolStripMenuItem"
        Me.修改网页渲染编辑器字体选项ToolStripMenuItem.Size = New System.Drawing.Size(341, 26)
        Me.修改网页渲染编辑器字体选项ToolStripMenuItem.Text = "修改网页渲染编辑器字体选项"
        '
        '修改MarkDown渲染编辑器字体选项ToolStripMenuItem
        '
        Me.修改MarkDown渲染编辑器字体选项ToolStripMenuItem.Name = "修改MarkDown渲染编辑器字体选项ToolStripMenuItem"
        Me.修改MarkDown渲染编辑器字体选项ToolStripMenuItem.Size = New System.Drawing.Size(341, 26)
        Me.修改MarkDown渲染编辑器字体选项ToolStripMenuItem.Text = "修改MarkDown渲染编辑器字体选项"
        '
        'Webview选项ToolStripMenuItem
        '
        Me.Webview选项ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.网页渲染器DevToolsToolToolStripMenuItem, Me.MarkDown渲染器DevToolsToolToolStripMenuItem})
        Me.Webview选项ToolStripMenuItem.Name = "Webview选项ToolStripMenuItem"
        Me.Webview选项ToolStripMenuItem.Size = New System.Drawing.Size(120, 25)
        Me.Webview选项ToolStripMenuItem.Text = "webview选项"
        '
        '网页渲染器DevToolsToolToolStripMenuItem
        '
        Me.网页渲染器DevToolsToolToolStripMenuItem.Name = "网页渲染器DevToolsToolToolStripMenuItem"
        Me.网页渲染器DevToolsToolToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.网页渲染器DevToolsToolToolStripMenuItem.Text = "网页渲染器DevTools"
        '
        'MarkDown渲染器DevToolsToolToolStripMenuItem
        '
        Me.MarkDown渲染器DevToolsToolToolStripMenuItem.Name = "MarkDown渲染器DevToolsToolToolStripMenuItem"
        Me.MarkDown渲染器DevToolsToolToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.MarkDown渲染器DevToolsToolToolStripMenuItem.Text = "MarkDown渲染器DevTools"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于此程序ToolStripMenuItem})
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        '关于此程序ToolStripMenuItem
        '
        Me.关于此程序ToolStripMenuItem.Name = "关于此程序ToolStripMenuItem"
        Me.关于此程序ToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.关于此程序ToolStripMenuItem.Text = "关于此程序"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(876, 589)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(868, 559)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.RichTextBoxHTML)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebViewHTML)
        Me.SplitContainer1.Size = New System.Drawing.Size(862, 553)
        Me.SplitContainer1.SplitterDistance = 287
        Me.SplitContainer1.TabIndex = 0
        '
        'RichTextBoxHTML
        '
        Me.RichTextBoxHTML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxHTML.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxHTML.Name = "RichTextBoxHTML"
        Me.RichTextBoxHTML.Size = New System.Drawing.Size(287, 553)
        Me.RichTextBoxHTML.TabIndex = 0
        Me.RichTextBoxHTML.Text = ""
        '
        'WebViewHTML
        '
        Me.WebViewHTML.AllowExternalDrop = True
        Me.WebViewHTML.CreationProperties = Nothing
        Me.WebViewHTML.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebViewHTML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebViewHTML.Location = New System.Drawing.Point(0, 0)
        Me.WebViewHTML.Name = "WebViewHTML"
        Me.WebViewHTML.Size = New System.Drawing.Size(571, 553)
        Me.WebViewHTML.TabIndex = 0
        Me.WebViewHTML.ZoomFactor = 1.0R
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1729, 719)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.RichTextBoxmarkdown)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.WebViewmarkdown)
        Me.SplitContainer2.Size = New System.Drawing.Size(1723, 713)
        Me.SplitContainer2.SplitterDistance = 574
        Me.SplitContainer2.TabIndex = 0
        '
        'RichTextBoxmarkdown
        '
        Me.RichTextBoxmarkdown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxmarkdown.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxmarkdown.Name = "RichTextBoxmarkdown"
        Me.RichTextBoxmarkdown.Size = New System.Drawing.Size(574, 713)
        Me.RichTextBoxmarkdown.TabIndex = 0
        Me.RichTextBoxmarkdown.Text = ""
        '
        'WebViewmarkdown
        '
        Me.WebViewmarkdown.AllowExternalDrop = True
        Me.WebViewmarkdown.CreationProperties = Nothing
        Me.WebViewmarkdown.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebViewmarkdown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebViewmarkdown.Location = New System.Drawing.Point(0, 0)
        Me.WebViewmarkdown.Name = "WebViewmarkdown"
        Me.WebViewmarkdown.Size = New System.Drawing.Size(1145, 713)
        Me.WebViewmarkdown.TabIndex = 0
        Me.WebViewmarkdown.ZoomFactor = 1.0R
        '
        '打开MarkDown文件ToolStripMenuItem
        '
        Me.打开MarkDown文件ToolStripMenuItem.Name = "打开MarkDown文件ToolStripMenuItem"
        Me.打开MarkDown文件ToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.打开MarkDown文件ToolStripMenuItem.Text = "打开MarkDown文件"
        '
        '保存MarkDown文件ToolStripMenuItem
        '
        Me.保存MarkDown文件ToolStripMenuItem.Name = "保存MarkDown文件ToolStripMenuItem"
        Me.保存MarkDown文件ToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.保存MarkDown文件ToolStripMenuItem.Text = "保存MarkDown文件"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 620)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.WebViewHTML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.WebViewmarkdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents FontDialog2 As FontDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents RichTextBoxHTML As RichTextBox
    Friend WithEvents WebViewHTML As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents RichTextBoxmarkdown As RichTextBox
    Friend WithEvents WebViewmarkdown As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents 打开ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 选项ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Webview选项ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 网页渲染器DevToolsToolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkDown渲染器DevToolsToolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于此程序ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改网页渲染编辑器字体选项ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改MarkDown渲染编辑器字体选项ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开HTML文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存HTML文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开MarkDown文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存MarkDown文件ToolStripMenuItem As ToolStripMenuItem
End Class

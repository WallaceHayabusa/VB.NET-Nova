<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.lblHorasExtras = New System.Windows.Forms.Label
        Me.lblEntrada = New System.Windows.Forms.Label
        Me.lblAlmoco = New System.Windows.Forms.Label
        Me.lblSaida = New System.Windows.Forms.Label
        Me.lblMotivo = New System.Windows.Forms.Label
        Me.lblTituloHorasExtras = New System.Windows.Forms.Label
        Me.btnLimparCampos = New System.Windows.Forms.Button
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.imgLogoNovaTendencia = New System.Windows.Forms.PictureBox
        Me.lblTotalHorasExtras = New System.Windows.Forms.Label
        Me.lblNumeroHorasExtras = New System.Windows.Forms.Label
        Me.dtEntrada = New System.Windows.Forms.DateTimePicker
        Me.lblAte = New System.Windows.Forms.Label
        Me.dtSaida = New System.Windows.Forms.DateTimePicker
        Me.txtMotivo = New System.Windows.Forms.TextBox
        Me.txtHorasExtras = New System.Windows.Forms.MaskedTextBox
        Me.txtHoraSaida = New System.Windows.Forms.MaskedTextBox
        Me.txtAlmocoSaida = New System.Windows.Forms.MaskedTextBox
        Me.txtHoraEntrada = New System.Windows.Forms.MaskedTextBox
        Me.txtAlmocoEntrada = New System.Windows.Forms.MaskedTextBox
        CType(Me.imgLogoNovaTendencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHorasExtras
        '
        Me.lblHorasExtras.AutoSize = True
        Me.lblHorasExtras.Location = New System.Drawing.Point(132, 109)
        Me.lblHorasExtras.Name = "lblHorasExtras"
        Me.lblHorasExtras.Size = New System.Drawing.Size(67, 13)
        Me.lblHorasExtras.TabIndex = 0
        Me.lblHorasExtras.Text = "Horas Extras"
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Location = New System.Drawing.Point(133, 145)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(44, 13)
        Me.lblEntrada.TabIndex = 2
        Me.lblEntrada.Text = "Entrada"
        '
        'lblAlmoco
        '
        Me.lblAlmoco.AutoSize = True
        Me.lblAlmoco.Location = New System.Drawing.Point(132, 190)
        Me.lblAlmoco.Name = "lblAlmoco"
        Me.lblAlmoco.Size = New System.Drawing.Size(42, 13)
        Me.lblAlmoco.TabIndex = 3
        Me.lblAlmoco.Text = "Almoço"
        '
        'lblSaida
        '
        Me.lblSaida.AutoSize = True
        Me.lblSaida.Location = New System.Drawing.Point(132, 232)
        Me.lblSaida.Name = "lblSaida"
        Me.lblSaida.Size = New System.Drawing.Size(36, 13)
        Me.lblSaida.TabIndex = 4
        Me.lblSaida.Text = "Saída"
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Location = New System.Drawing.Point(132, 271)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(39, 13)
        Me.lblMotivo.TabIndex = 5
        Me.lblMotivo.Text = "Motivo"
        '
        'lblTituloHorasExtras
        '
        Me.lblTituloHorasExtras.AutoSize = True
        Me.lblTituloHorasExtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloHorasExtras.Location = New System.Drawing.Point(198, 40)
        Me.lblTituloHorasExtras.Name = "lblTituloHorasExtras"
        Me.lblTituloHorasExtras.Size = New System.Drawing.Size(363, 20)
        Me.lblTituloHorasExtras.TabIndex = 6
        Me.lblTituloHorasExtras.Text = "Cálculo de Horas Extras - Nova Tendência ®"
        '
        'btnLimparCampos
        '
        Me.btnLimparCampos.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLimparCampos.Location = New System.Drawing.Point(135, 463)
        Me.btnLimparCampos.Name = "btnLimparCampos"
        Me.btnLimparCampos.Size = New System.Drawing.Size(96, 23)
        Me.btnLimparCampos.TabIndex = 13
        Me.btnLimparCampos.Text = "Limpar Campos"
        Me.btnLimparCampos.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(400, 463)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(96, 23)
        Me.btnEnviar.TabIndex = 14
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'imgLogoNovaTendencia
        '
        Me.imgLogoNovaTendencia.Image = CType(resources.GetObject("imgLogoNovaTendencia.Image"), System.Drawing.Image)
        Me.imgLogoNovaTendencia.Location = New System.Drawing.Point(34, 21)
        Me.imgLogoNovaTendencia.Name = "imgLogoNovaTendencia"
        Me.imgLogoNovaTendencia.Size = New System.Drawing.Size(143, 65)
        Me.imgLogoNovaTendencia.TabIndex = 15
        Me.imgLogoNovaTendencia.TabStop = False
        '
        'lblTotalHorasExtras
        '
        Me.lblTotalHorasExtras.AutoSize = True
        Me.lblTotalHorasExtras.Location = New System.Drawing.Point(132, 401)
        Me.lblTotalHorasExtras.Name = "lblTotalHorasExtras"
        Me.lblTotalHorasExtras.Size = New System.Drawing.Size(109, 13)
        Me.lblTotalHorasExtras.TabIndex = 16
        Me.lblTotalHorasExtras.Text = "Total de Horas Extras"
        '
        'lblNumeroHorasExtras
        '
        Me.lblNumeroHorasExtras.AutoSize = True
        Me.lblNumeroHorasExtras.Location = New System.Drawing.Point(291, 401)
        Me.lblNumeroHorasExtras.Name = "lblNumeroHorasExtras"
        Me.lblNumeroHorasExtras.Size = New System.Drawing.Size(0, 13)
        Me.lblNumeroHorasExtras.TabIndex = 17
        '
        'dtEntrada
        '
        Me.dtEntrada.CustomFormat = ""
        Me.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntrada.Location = New System.Drawing.Point(294, 141)
        Me.dtEntrada.Name = "dtEntrada"
        Me.dtEntrada.Size = New System.Drawing.Size(99, 20)
        Me.dtEntrada.TabIndex = 19
        Me.dtEntrada.Value = New Date(2018, 6, 12, 0, 0, 0, 0)
        '
        'lblAte
        '
        Me.lblAte.AutoSize = True
        Me.lblAte.Location = New System.Drawing.Point(384, 190)
        Me.lblAte.Name = "lblAte"
        Me.lblAte.Size = New System.Drawing.Size(22, 13)
        Me.lblAte.TabIndex = 21
        Me.lblAte.Text = "até"
        '
        'dtSaida
        '
        Me.dtSaida.CustomFormat = ""
        Me.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSaida.Location = New System.Drawing.Point(294, 228)
        Me.dtSaida.Name = "dtSaida"
        Me.dtSaida.Size = New System.Drawing.Size(99, 20)
        Me.dtSaida.TabIndex = 24
        Me.dtSaida.Value = New Date(2018, 6, 12, 0, 0, 0, 0)
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(294, 268)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(202, 71)
        Me.txtMotivo.TabIndex = 25
        '
        'txtHorasExtras
        '
        Me.txtHorasExtras.Enabled = False
        Me.txtHorasExtras.Location = New System.Drawing.Point(294, 106)
        Me.txtHorasExtras.Mask = "00"
        Me.txtHorasExtras.Name = "txtHorasExtras"
        Me.txtHorasExtras.Size = New System.Drawing.Size(202, 20)
        Me.txtHorasExtras.TabIndex = 26
        '
        'txtHoraSaida
        '
        Me.txtHoraSaida.AsciiOnly = True
        Me.txtHoraSaida.Location = New System.Drawing.Point(412, 229)
        Me.txtHoraSaida.Mask = "00:00"
        Me.txtHoraSaida.Name = "txtHoraSaida"
        Me.txtHoraSaida.Size = New System.Drawing.Size(84, 20)
        Me.txtHoraSaida.TabIndex = 28
        Me.txtHoraSaida.ValidatingType = GetType(Date)
        '
        'txtAlmocoSaida
        '
        Me.txtAlmocoSaida.AsciiOnly = True
        Me.txtAlmocoSaida.Location = New System.Drawing.Point(412, 187)
        Me.txtAlmocoSaida.Mask = "00:00"
        Me.txtAlmocoSaida.Name = "txtAlmocoSaida"
        Me.txtAlmocoSaida.Size = New System.Drawing.Size(84, 20)
        Me.txtAlmocoSaida.TabIndex = 30
        Me.txtAlmocoSaida.ValidatingType = GetType(Date)
        '
        'txtHoraEntrada
        '
        Me.txtHoraEntrada.AsciiOnly = True
        Me.txtHoraEntrada.Location = New System.Drawing.Point(412, 142)
        Me.txtHoraEntrada.Mask = "00:00"
        Me.txtHoraEntrada.Name = "txtHoraEntrada"
        Me.txtHoraEntrada.Size = New System.Drawing.Size(84, 20)
        Me.txtHoraEntrada.TabIndex = 27
        Me.txtHoraEntrada.ValidatingType = GetType(Date)
        '
        'txtAlmocoEntrada
        '
        Me.txtAlmocoEntrada.AsciiOnly = True
        Me.txtAlmocoEntrada.Location = New System.Drawing.Point(294, 187)
        Me.txtAlmocoEntrada.Mask = "00:00"
        Me.txtAlmocoEntrada.Name = "txtAlmocoEntrada"
        Me.txtAlmocoEntrada.Size = New System.Drawing.Size(84, 20)
        Me.txtAlmocoEntrada.TabIndex = 29
        Me.txtAlmocoEntrada.ValidatingType = GetType(Date)
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 513)
        Me.Controls.Add(Me.txtAlmocoSaida)
        Me.Controls.Add(Me.txtAlmocoEntrada)
        Me.Controls.Add(Me.txtHoraSaida)
        Me.Controls.Add(Me.txtHoraEntrada)
        Me.Controls.Add(Me.txtHorasExtras)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.dtSaida)
        Me.Controls.Add(Me.lblAte)
        Me.Controls.Add(Me.dtEntrada)
        Me.Controls.Add(Me.lblNumeroHorasExtras)
        Me.Controls.Add(Me.lblTotalHorasExtras)
        Me.Controls.Add(Me.imgLogoNovaTendencia)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnLimparCampos)
        Me.Controls.Add(Me.lblTituloHorasExtras)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.lblSaida)
        Me.Controls.Add(Me.lblAlmoco)
        Me.Controls.Add(Me.lblEntrada)
        Me.Controls.Add(Me.lblHorasExtras)
        Me.Name = "frmPrincipal"
        Me.Text = "Cálculo de Horas - Nova Tendência ®"
        CType(Me.imgLogoNovaTendencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHorasExtras As System.Windows.Forms.Label
    Friend WithEvents lblEntrada As System.Windows.Forms.Label
    Friend WithEvents lblAlmoco As System.Windows.Forms.Label
    Friend WithEvents lblSaida As System.Windows.Forms.Label
    Friend WithEvents lblMotivo As System.Windows.Forms.Label
    Friend WithEvents lblTituloHorasExtras As System.Windows.Forms.Label
    Friend WithEvents btnLimparCampos As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents imgLogoNovaTendencia As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalHorasExtras As System.Windows.Forms.Label
    Friend WithEvents lblNumeroHorasExtras As System.Windows.Forms.Label
    Friend WithEvents dtEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAte As System.Windows.Forms.Label
    Friend WithEvents dtSaida As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents txtHorasExtras As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtHoraSaida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAlmocoSaida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtHoraEntrada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAlmocoEntrada As System.Windows.Forms.MaskedTextBox

End Class

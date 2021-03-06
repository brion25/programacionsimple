Attribute VB_Name = "Module1"
Sub createNewWorkbook()
    'EN: Here we create the variables that will contain the values of the new Book
    'ES: Aqui creamos las variables que contendran los valores del nuevo Libro
    Dim newBook As Workbook
    'EN: We need to add sheets to the new book to work with it since VBA due to the new book will not have any sheet
    'ES: tenemos que agregar hojas al nuevo libro para poder trabajar con el desde VBA debido a que el nuevo Libro no tendra ninguna hoja
    Dim newSheet As Worksheet
    'EN: Here we create a new Input Box to ask for the new Name
    'ES: Aqui creamos una nueva ventana donde pedimos el nuevo nombre
    Dim name As String
    name = InputBox("Enter the Name of the new Workbook") & ".xls"
    'EN: Here we create the new book on the same path as our active document and with the name that we have gave it
    'ES: Aqui creamos el nuevo libro en la misma ruta que nuestro documento activo con el nombre que le dimos antes
    Set newBook = Workbooks.Add
    With newBook
        .Title = name
        .SaveAs FileName:=ActiveDocument.Path & "\" & name
    End With
    'EN: Here we add the new sheet to work with it
    'ES: Aqui creamos la nueva hoja para trabajar con ella
    Set newSheet = newBook.Sheets.Add
    'EN: Here we write on excel on the cell on first Row and First Column
    'ES: Aqui escribimos en excel en la celda en la primer fila y columna
    newSheet.Cells(1, 1).Value = "You have created a new Workbook"
    'EN: Here we close the file and save the changes
    'ES: Aqui cerramos el Libro y guardamos cambios
    newBook.Close (True)
End Sub

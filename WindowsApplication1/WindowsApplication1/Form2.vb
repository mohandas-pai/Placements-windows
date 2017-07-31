Public Class Form2



    Private Sub ADDCutomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub SeeProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()


    End Sub

    Private Sub DELETECustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETECustomerToolStripMenuItem.Click
        delCustomer.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub SeeCustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeeCustomersToolStripMenuItem.Click
        showCustomer.Show()

    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        addProducts.Show()

    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        removeProduct.Show()

    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        updateProduct.Show()

    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        seeOrders.Show()

    End Sub

    Private Sub EditStocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditStocksToolStripMenuItem.Click
        editStocks.Show()

    End Sub

    Private Sub CheckStocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckStocksToolStripMenuItem.Click
        seeStocks.Show()

    End Sub
End Class
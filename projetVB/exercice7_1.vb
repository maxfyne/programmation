Module exercice7_1
	Sub Main()

		Dim montant As Integer

		Console.WriteLine("Entrer le montant :")

		montant = Console.ReadLine()

		If montant <= 500 Then

			Console.WriteLine("Pas de remise")
			Console.WriteLine("le montant net est de :" + montant.ToString())

		ElseIf montant > 2000 And montant < 5000 Then

			montant = montant * 0.99
			Console.WriteLine("Remise de 1%")
			Console.WriteLine("le montant net est de :" + montant.ToString())
		ElseIf 5000 < montant Then

			montant = montant * 0.98
			Console.WriteLine("Remise de 2%")
			Console.WriteLine("le montant net est de :" + montant.ToString())

		End If
		Console.WriteLine("Aurevoir")
		Console.ReadLine()

	End Sub
End Module

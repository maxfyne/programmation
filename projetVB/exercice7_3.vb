Module exercice7_3
    Sub Main()

        Dim h As Double
        Dim Taux_horraire As Double
        Dim salaireHEB As Double

        Console.WriteLine("Nombre d'heures hebdomadaire ?")
        h = Console.ReadLine()

        Taux_horraire = 15

        If h < 39 Then
            salaireHEB = 0
            Console.WriteLine("Vous ne travaillez pas assez")
        Else
            Console.WriteLine("Taux horaire ?")
            Taux_horraire = Console.ReadLine()
            If h < 48 Then
                salaireHEB = h * Taux_horraire * 1.25
            Else
                salaireHEB = h * Taux_horraire * 1.5
            End If
        End If

        Console.WriteLine("Salaire hebdomadaire " + salaireHEB.ToString())
        Console.WriteLine("Au revoir")
    End Sub
End Module
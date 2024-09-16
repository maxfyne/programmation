Module exercice7_2
    Sub Main()
        Dim nbjour As Integer
        Dim distance As Integer
        Dim prixessence As Double
        Dim prixdiesel As Double

        Console.WriteLine("Nombre de jours de location ?")
        nbjour = Console.ReadLine()
        Console.WriteLine("Distance a parcourir en kms ?")
        distance = Console.ReadLine()

        prixdiesel = nbjour * 35 + distance * 0.65
        prixessence = nbjour * 30 + distance * 0.85

        If prixessence < prixdiesel Then

            Console.WriteLine("Meilleur choix : Essence")
            Console.WriteLine("Pour un total de " + prixessence.ToString())

        ElseIf prixessence > prixdiesel Then

            Console.WriteLine("Meilleur choix : Diesel")
            Console.WriteLine("Pour un total de " + prixdiesel.ToString())

        ElseIf prixdiesel = prixessence Then

            Console.WriteLine("Il n'y a pas de meilleur choix")
            Console.WriteLine("Le montant est pareil pour les deux formules :" + prixdiesel.ToString + "€")

        End If
    End Sub
End Module

Imports Microshop
Module Module1

    Sub Main()
        Dim f1 As Fabricant = Nothing
        Dim f2 As Fabricant = Nothing
        Dim f3 As Fabricant = Nothing
        Dim f4 As Fabricant = Nothing
        Dim f5 As Fabricant = Nothing
        Dim f6 As Fabricant = Nothing
        Dim f7 As Fabricant = Nothing
        Dim lf As lesFabricants = Nothing
        Dim pr As Processeur = Nothing
        Dim so As Souris = Nothing
        Dim mem As Memoire = Nothing
        Dim dd As DisqueDur = Nothing
        Dim cat As Catalogue = Nothing
        Dim pan As Panier = Nothing
        Dim lig As Ligne = Nothing
        Dim lig1 As Ligne = Nothing
        Dim lig2 As Ligne = Nothing
        Dim lig3 As Ligne = Nothing
        Dim p As Produit = Nothing
        Dim cli1 As Client = Nothing
        Dim cli2 As Client = Nothing
        Dim cli3 As Client = Nothing
        Dim cli4 As Client = Nothing
        Dim lc As lesClients = Nothing
        Dim cmd1 As Commande = Nothing
        Dim cmd2 As Commande = Nothing
        Dim cmd3 As Commande = Nothing
        Dim cmd4 As Commande = Nothing
        Dim lcmd As lesCOmmandes = Nothing


        Console.WriteLine("************** test des classes Fabricant et LesFabricants  ******************")
        Console.WriteLine("* 1.1 creation d'une instance de la classe Fabricant avec juste le nom   (samsung)")
        Try
            f1 = New Fabricant("samsung")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("* creation OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 1.2 affichage de l'instance creee avec la fonction toString ")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(f1.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 1.3 creation d'une instance de la classe Fabricant avec le nom (toshiba) + adresse")
        Try
            f2 = New Fabricant("toshiba", New adresse("rue des fleurs", "nantes", "france"))
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("* creation OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 1.4 affichage de l'instance creee avec la fonction toString ")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(f2.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 1.5 creation de la liste des fabricants")
        Try
            lf = New lesFabricants
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("* creation OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 1.6 ajout des fabricants a la liste")
        Try
            lf.ajouter(f1)
            lf.ajouter(f2)
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("* ajout OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 1.7 recherche et affichage d'un fabricant (toshiba)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(lf.rechercher("toshiba").tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 1.8 affichage de la liste des fabricants")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(lf.ToString)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("************** test de la classe Processeur  ******************")
        Console.WriteLine("* 2.1 creation d'une instance de la classe Processeur")
        Try
            pr = New Processeur(100, 15.5, "pentium", 50, 1, f1, "socket 133", 466)
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("* creation OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 2.2 affichage de l'instance creee avec la fonction toString ")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(pr.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("************** test de la classe Souris  ******************")
        Console.WriteLine("* 3.1 creation d'une instance de la classe Souris")
        Try
            so = New Souris(101, 5.75, "optique", 10, 0.75, f2, "sans fil", "usb")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("* creation OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 3.2 affichage de l'instance creee avec la fonction toString ")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(so.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("************** test de la classe Memoire  ******************")
        Console.WriteLine("* 4.1 creation d'une instance de la classe Memoire")
        Try
            mem = New Memoire(102, 23.56, "barette memoire", 83, 1, f1, "SDRAM", 512, 400)
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("* creation OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 4.2 affichage de l'instance creee avec la fonction toString ")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(mem.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("************** test de la classe DisqueDur  ******************")
        Console.WriteLine("* 5.1 creation d'une instance de la classe DisqueDur")
        Try
            dd = New DisqueDur(103, 123.56, "disque 7200 t/min", 33, 1, f2, "SATA", 500000)
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("* creation OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 5.2 affichage de l'instance creee avec la fonction toString ")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(dd.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("************** test du lien entre produit et fabricant  ******************")
        Console.WriteLine("* 6.1 affichage du fabricant du processeur")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(pr.fabricant.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 6.2 affichage du fabricant de la souris")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(so.fabricant.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 6.3 affichage du fabricant de la memoire")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(mem.fabricant.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 6.4 affichage du fabricant du disque dur")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(dd.fabricant.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("************** test du lien entre fabricant et produit ******************")
        Console.WriteLine("* 7.1 affichage des produits de samsung")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            For Each p In f1.lesProduits
                Console.WriteLine(p.tostring & vbCrLf)
            Next
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("************** test du catalogue ******************")
        cat = New Catalogue
        Console.WriteLine("* 8.1 ajout des produits au catalogue")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cat.ajout(pr)
            cat.ajout(so)
            cat.ajout(mem)
            cat.ajout(dd)
            Console.WriteLine("* ajout OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 8.2 affichage des produits du catalogue")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(cat.toString)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 8.3 affichage du premier produit du catalogue (processeur)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(cat.premier.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 8.4 affichage du produit suivant du catalogue (souris)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(cat.suivant.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 8.5 affichage du dernier du catalogue (disque dur)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(cat.dernier.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 8.6 affichage du produit precedent du catalogue (memoire)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(cat.precedent.tostring)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 8.7 test des limites du catalogue (debut)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cat.premier()
            p = cat.precedent
            If IsNothing(p) Then
                Console.WriteLine("debut du catalogue")
                Console.ForegroundColor = ConsoleColor.Gray
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("* ca marche po!")
                Console.ForegroundColor = ConsoleColor.Gray
            End If
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 8.8 test des limites du catalogue (fin)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cat.dernier()
            p = cat.suivant
            If IsNothing(p) Then
                Console.WriteLine("fin du catalogue")
                Console.ForegroundColor = ConsoleColor.Gray
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("* ca marche po!")
                Console.ForegroundColor = ConsoleColor.Gray
            End If
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 8.9 supression d'un produit du catalogue (souris)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cat.supprimer(1)
            Console.WriteLine(cat.toString)
            Console.WriteLine("il reste {0} produit(s) dans le catalogue", cat.nbproduits)
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 8.10 supression d'un produit du catalogue (memoire)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cat.supprimer(1)
            Console.WriteLine(cat.toString)
            Console.WriteLine("il reste {0} produit(s) dans le catalogue", cat.nbproduits)
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 8.11 supression d'un produit du catalogue (disque dur)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cat.supprimer(1)
            Console.WriteLine(cat.toString)
            Console.WriteLine("il reste {0} produit(s) dans le catalogue", cat.nbproduits)
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 8.11 supression d'un produit inexistant du catalogue ")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cat.supprimer(1)
            Console.WriteLine(cat.toString)
            Console.WriteLine("il reste {0} produit(s) dans le catalogue", cat.nbproduits)
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 8.12 supression du dernier produit du catalogue")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cat.supprimer(0)
            Console.WriteLine(cat.toString)
            Console.WriteLine("il reste {0} produit(s) dans le catalogue", cat.nbproduits)
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try
        Console.WriteLine("* 8.13 affichage des produits du catalogue (pour le fun)")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(cat.toString)
            Console.WriteLine("y en a plus !!! ")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("************** test du système de recherche ******************")
        Console.WriteLine("* 9.1 ajout des produits au catalogue")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cat.ajout(pr)
            cat.ajout(so)
            cat.ajout(mem)
            cat.ajout(dd)
            Console.WriteLine("* ajout OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 9.2 recherche par ref")
        Try
            Dim result As ArrayList
            result = New ArrayList()
            result = cat.recherche("100", "ref")
            Console.ForegroundColor = ConsoleColor.Green
            For i = 0 To result.Count - 1
                Console.WriteLine(result(i).ToString())
            Next
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 9.3 recherche par categorie")
        Try
            Dim result As ArrayList
            result = New ArrayList()
            result = cat.recherche("Souris", "cat")
            Console.ForegroundColor = ConsoleColor.Green
            For i = 0 To result.Count - 1
                Console.WriteLine(result(i).ToString())
            Next
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 9.4 recherche par fabricant")
        Try
            Dim result As ArrayList
            result = New ArrayList()
            result = cat.recherche("samsung", "fab")
            Console.ForegroundColor = ConsoleColor.Green
            For i = 0 To result.Count - 1
                Console.WriteLine(result(i).ToString())
            Next
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 9.5 recherche par promotion")
        Try
            Dim result As ArrayList
            result = New ArrayList()
            result = cat.recherche("", "pro")
            Console.ForegroundColor = ConsoleColor.Green
            For i = 0 To result.Count - 1
                Console.WriteLine(result(i).ToString())
            Next
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 9.6 recherche par tout")
        Try
            Dim result As ArrayList
            result = New ArrayList()
            result = cat.recherche("", "tou")
            Console.ForegroundColor = ConsoleColor.Green
            For i = 0 To result.Count - 1
                Console.WriteLine(result(i).ToString())
            Next
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 9.7 recherche par mot clef")
        Try
            Dim result As ArrayList
            result = New ArrayList()
            result = cat.recherche("pentium", "cle")
            Console.ForegroundColor = ConsoleColor.Green
            For i = 0 To result.Count - 1
                Console.WriteLine(result(i).ToString())
            Next
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("************** test du panier ******************")
        pan = New Panier()
        Console.WriteLine("* 10.1 ajout d'une ligne")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            lig = New Ligne(so, 2)
            Console.WriteLine("* ajout ok")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 10.2 Affichage de la ligne")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(lig.ToString)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 10.3 ajout de la ligne dans le panier")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            pan.ajout_ligne(lig)
            Console.WriteLine("* ajout ok")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 10.4 affichage du panier")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(pan.ToString())
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 10.5 mise a jour du montant de la ligne")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            so.Prix = 10
            lig.majMontant()
            Console.WriteLine(lig.ToString)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 10.6 Suppression d'une ligne dans le panier")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            pan.supprimer_ligne(lig)
            Console.WriteLine(pan.ToString)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 10.7 Recherche dans le catalogue")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            lig1 = New Ligne(dd, 3)
            lig2 = New Ligne(pr, 1)
            lig3 = New Ligne(mem, 4)
            pan.ajout_ligne(lig1)
            pan.ajout_ligne(lig2)
            pan.ajout_ligne(lig3)
            Console.WriteLine(pan.recherche(2))
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try


        Console.WriteLine("************** test des clients ******************")
        Console.WriteLine("* 11.1 ajout d'un utilisateur")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cli1 = New Client(Guid.NewGuid(), "Torvald", "Linus", "0203040506", "linus.torvald@libre.org", _
                         New Adresse("rue de la Liberte", "Helinsky", "Norvege"))
            Console.WriteLine("* ajout OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 11.2 afficher un utilisateur")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cli1 = New Client(Guid.NewGuid(), "Torvald", "Linus", "0203040506", "linus.torvald@libre.org", _
                         New Adresse("rue de la Liberte", "Helinsky", "Norvege"))
            Console.WriteLine("* ajout OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 11.3 Ajout d'utilisateurs dans lesClients")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cli2 = New Client(Guid.NewGuid(), "Stallman", "Richard", "0203040506", "richard.stallman@libre.org", _
                         New Adresse("rue de la Liberte", "Washington", "USA"))
            cli3 = New Client(Guid.NewGuid(), "Gates", "bill", "0203040506", "bill.gates@merdosoft.com", _
                         New Adresse("rue du pognon", "Redmond", "USA"))
            cli4 = New Client(Guid.NewGuid(), "Jobs", "Steve", "0203040506", "steve.jobs@macintosh.org", _
                         New Adresse("Istreet", "Cupertino", "USA"))

            lc = New lesClients()
            lc.ajouter(cli1)
            lc.ajouter(cli2)
            lc.ajouter(cli3)
            lc.ajouter(cli4)
            Console.WriteLine("* ajout OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 11.4 Afficher la liste des utilisateurs")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(lc.ToString)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("************** test des commandes ******************")
        Console.WriteLine("* 12.1 ajout d'une commande")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cmd1 = New Commande(cli1, pan)
            Console.WriteLine("* ajout OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 12.2 afficher la commande")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(cmd1.ToString)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 12.3 Ajout de la commande dans lesCommandes")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            lcmd = New lesCommandes()
            lcmd.ajouter(cmd1)
            Console.WriteLine("* ajout OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 12.4 Afficher la liste des commandes")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            cmd2 = New Commande(cli2, pan)
            cmd3 = New Commande(cli3, pan)
            cmd4 = New Commande(cli4, pan)
            lcmd.ajouter(cmd2)
            lcmd.ajouter(cmd3)
            lcmd.ajouter(cmd4)
            Console.WriteLine(lcmd.ToString)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 12.4 Recherche d'une commande")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(lcmd.rechercher(cmd1.numero).ToString)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("************** test du Tri ******************")
        Console.WriteLine("* 13.1 Test du tri sur Produit")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("* ajout OK")
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.WriteLine("* 13.2 afficher la commande")
        Try
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(cmd1.ToString)
            Console.ForegroundColor = ConsoleColor.Gray
        Catch e As Exception
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("* ca marche po!")
            Console.ForegroundColor = ConsoleColor.Gray
        End Try

        Console.ReadLine()

    End Sub

End Module

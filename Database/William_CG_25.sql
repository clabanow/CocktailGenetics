
	--1
	insert into Cocktail values ('Cuba Libre', 'cubalibre')

	--2
	insert into Cocktail values ('Margarita', 'margarita')
	
	--3
	insert into Cocktail values ('Old Fashioned', 'oldfashioned')
	
	--4
	insert into Cocktail values ('Martinez', 'martinez')
	
	--5
	insert into Cocktail values ('Martini', 'martini')
	
	--6
	insert into Cocktail values ('Manhattan', 'manhattan')
	
	--7
	insert into Cocktail values ('Brooklyn', 'brooklyn')
	
	--8
	insert into Cocktail values ('Daiquiri', 'daiquiri')
	
	--9
	insert into Cocktail values ('Sidecar','sidecar')
	
	--10
	insert into Cocktail values ('French 75','french75')
	
	--11
	insert into Cocktail values ('Bloody Mary','bloodymary')
	
	--12
	insert into Cocktail values ('Irish Coffee','irishcoffee')
	
	--13
	insert into Cocktail values ('Negroni','negroni')
	
	--14
	insert into Cocktail values ('Boulevardier','boulevardier')
	
	--15
	insert into Cocktail values ('Sazerac','sazerac')
	
	--16
	insert into Cocktail values ('Vieux Carre','vieuxcarre')
	
	--17
	insert into Cocktail values ('Ramos Fizz','ramosfizz')
	
	--18
	insert into Cocktail values ('Mint Julep','mintjulep')
	
	--19
	insert into Cocktail values ('Whiskey Sour','whiskeysour')
	
	--20
	insert into Cocktail values ('Mai Tai','maitai')
	
	--21
	insert into Cocktail values ('Planter''s Punch','planterspunch')
	
	--22
	insert into Cocktail values ('Pisco Sour','piscosour')
	
	--23
	insert into Cocktail values ('Cosmopolitan','cosmopolitan')
	
	--24
	insert into Cocktail values ('Tom Collins','tomcollins')
	
	--25
	insert into Cocktail values ('Last Word', 'lastword')

	--26
	insert into Cocktail values ('Mojito', 'mojito')

	--27
	insert into Cocktail values ('Caipirinha', 'caipirinha')

	--28
	insert into Cocktail values ('Improved', 'improved')

	--29
	insert into Cocktail values ('Corpse Reviver #2', 'corpsereviver')

	--30
	insert into Cocktail values ('Pegu Club', 'peguclub')


	insert into Ingredient values ('Cola', 0) 				--1
	insert into Ingredient values ('White Rum', 1) 			--2
	insert into Ingredient values ('Lime Juice', 0) 		--3
	insert into Ingredient values ('Tequila', 1) 			--4
	insert into Ingredient values ('Triple Sec', 1) 		--5
	insert into Ingredient values ('Bourbon', 1) 			--6
	insert into Ingredient values ('Sugar', 0)  			--7
	insert into Ingredient values ('Angostura Bitters', 1) 	--8
	insert into Ingredient values ('Gin', 1)  				--9
	insert into Ingredient values ('Sweet Vermouth', 1) 	--10
	insert into Ingredient values ('Maraschino', 1) 		--11
	insert into Ingredient values ('Orange Bitters', 1) 	--12
	insert into Ingredient values ('Lemon', 0) 				--13
	insert into Ingredient values ('Dry Vermouth', 1) 		--14
	insert into Ingredient values ('Rye Whiskey', 1) 		--15
	insert into Ingredient values ('Cognac', 1) 			--16
	insert into Ingredient values ('Cointreau', 1) 			--17
	insert into Ingredient values ('Lemon Juice', 0) 		--18
	insert into Ingredient values ('Champagne', 1) 			--19
	insert into Ingredient values ('Vodka', 1) 				--20
	insert into Ingredient values ('Tomato Juice', 0) 		--21
	insert into Ingredient values ('Black Pepper', 0) 		--22
	insert into Ingredient values ('Worcestershire Sauce',0) --23
	insert into Ingredient values ('Soy Sauce', 0) 			--24
	insert into Ingredient values ('Celery Salt', 0) 		--25
	insert into Ingredient values ('Hot Sauce', 0) 			--26
	insert into Ingredient values ('Celery', 0) 			--27
	insert into Ingredient values ('Horse Raddish', 0) 		--28
	insert into Ingredient values ('Irish Whiskey', 1) 		--29
	insert into Ingredient values ('Coffee', 0) 			--30
	insert into Ingredient values ('Simple Syrup', 0) 		--31
	insert into Ingredient values ('Cream', 0) 				--32
	insert into Ingredient values ('Campari', 1) 			--33
	insert into Ingredient values ('Absinthe', 1) 			--34
	insert into Ingredient values ('Peychaud''s Bitters', 1) --35
	insert into Ingredient values ('Water', 0) 				--36
	insert into Ingredient values ('Benedictine', 0) 		--37
	insert into Ingredient values ('Egg White', 0) 			--38
	insert into Ingredient values ('Orange Flower Water', 0) --39
	insert into Ingredient values ('Seltzer', 0) 			--40
	insert into Ingredient values ('Mint', 0) 				--41
	insert into Ingredient values ('Dark Rum', 1) 			--42
	insert into Ingredient values ('Curacao', 1) 			--43
	insert into Ingredient values ('Orgeat', 0) 			--44
	insert into Ingredient values ('Vanilla Extract', 0) 	--45
	insert into Ingredient values ('Lime', 0) 				--46
	insert into Ingredient values ('Club Soda', 0) 			--47
	insert into Ingredient values ('Cranberry Juice', 0)	--48
	insert into Ingredient values ('Citrus Vodka', 1) 		--49
	insert into Ingredient values ('Pisco', 1) 				--50
	insert into Ingredient values ('Green Charteuse',1)		--51
	insert into Ingredient values ('Cachaca', 1)            --52
	insert into Ingredient values ('Genever', 1)            --53
	insert into Ingredient values ('Lillet', 1)             --54
	
	
	--Cuba Libre/1 *need to make it work with lime
	insert into CocktailIngredient values (1, 1, '10 oz')
	insert into CocktailIngredient values (1, 2, '2 oz')
	insert into CocktailIngredient values (1, 3, '1/2')
	
	--Margarita/2
	insert into CocktailIngredient values (2, 3, '1 oz')
	insert into CocktailIngredient values (2, 4, '1 1/2 oz')
	insert into CocktailIngredient values (2, 5, '1/2 oz oz')
	
	--Old Fashioned/3
	insert into CocktailIngredient values (3, 6, '2 oz')
	insert into CocktailIngredient values (3, 7, '1 tsp')
	insert into CocktailIngredient values (3, 8, '4 dashes')
	
	--Martinez/4
	insert into CocktailIngredient values (4, 9, '2 oz')
	insert into CocktailIngredient values (4, 10, '3/4 oz')
	insert into CocktailIngredient values (4, 11, '1/4 oz')
	insert into CocktailIngredient values (4, 12, '1 dash')
	insert into CocktailIngredient values (4, 13, '1')
	
	--Martini/5
	insert into CocktailIngredient values (5, 9, '2 1/2 oz')
	insert into CocktailIngredient values (5, 12, '1 dash')
	insert into CocktailIngredient values (5, 14, '1/2 oz')
	
	--Manhattan/6
	insert into CocktailIngredient values (6, 15, '2 oz')
	insert into CocktailIngredient values (6, 10, '1/2 oz')
	insert into CocktailIngredient values (6, 8, '2-3 dashes')
	
	--Brooklyn/7
	insert into CocktailIngredient values (7, 15, '2 oz')--rye whiskey
	insert into CocktailIngredient values (7, 14, '1 oz')--dry vermouth
	insert into CocktailIngredient values (7, 11, '1/4 oz')--maraschino
	insert into CocktailIngredient values (7, 8, 'a few dashes')--angostura

	insert into Recipe values (7, 1, 'Combine ingredients with ice and stir until well-chilled')
	insert into Recipe values (7, 2, 'Strain into a chilled cocktail glass')
	
	--Daiquiri/8
	insert into CocktailIngredient values (8, 2, '1 1/2 oz')--light rum
	insert into CocktailIngredient values (8, 3, '3/4 oz')--lime juice
	insert into CocktailIngredient values (8, 7, '1/4 oz')--sugar

	insert into Recipe values (8, 1, 'Pour the light rum, lime juice and sugar syrup into a cocktail shaker with ice cubes')
	insert into Recipe values (8, 2, 'Shake well')
	insert into Recipe values (8, 3, 'Strain into a chilled cocktail glass')
	
	--Sidecar/9
	insert into CocktailIngredient values (9, 16, '1 1/2 oz')--cognac
	insert into CocktailIngredient values (9, 17, '3/4 oz')--cointreau
	insert into CocktailIngredient values (9, 18, '3/4 oz')--lemon juice
	insert into CocktailIngredient values (9, 7, '1/4 oz')--sugar

	insert into Recipe values (9, 1, 'Coat the rim of a cocktail glass with sugar and set aside (Do this a few minutes ahead of time so the sugar can dry and adhere well to the glass)')
	insert into Recipe values (9, 2, 'Add the remaining ingredients to a shaker and fill with ice')
	insert into Recipe values (9, 3, 'Shake, and strain into the prepared glass')
	
	--French75/10
	insert into CocktailIngredient values (10, 9, '1 oz')--gin
	insert into CocktailIngredient values (10, 18, '1/2 oz')--lemon juice
	insert into CocktailIngredient values (10, 7, '1/4 oz')--sugar
	insert into CocktailIngredient values (10, 19, '3 oz')--champagne
	insert into CocktailIngredient values (10, 13, '1 twist')--lemon

	insert into Recipe values (10, 1, 'Add all the ingredients except the Champagne to a shaker and fill with ice')
	insert into Recipe values (10, 2, 'Shake well and strain into a Champagne flute')
	insert into Recipe values (10, 3, 'Top with the Champagne and garnish with a lemon twist')
	
	--Bloody Mary/11
	insert into CocktailIngredient values (11, 20, '2 oz')--vodka
	insert into CocktailIngredient values (11, 21, '4 oz')--tomato juice
	insert into CocktailIngredient values (11, 22, '1/2 tsp')--black pepper
	insert into CocktailIngredient values (11, 23, '1/2 tsp')--Worcestershire sauce
	insert into CocktailIngredient values (11, 24, '1/4 tsp')--soy sauce
	insert into CocktailIngredient values (11, 13, '1/4 whole')--lemon
	insert into CocktailIngredient values (11, 25, '1 tbsp')--celery salt
	insert into CocktailIngredient values (11, 26, '1/4 tsp')--hot sauce
	insert into CocktailIngredient values (11, 27, '1 stick')--celery
	insert into CocktailIngredient values (11, 28, '1/2 tsp')--horse radish

	insert into Recipe values (11, 1, 'Place celery salt in a shallow saucer. Rub rim of 12-ounce tumbler with 1 lemon wedge and coat wet edge with celery salt. Place lemon wedge on rim of glass. Fill glass with ice.')
	insert into Recipe values (11, 2, 'Add Worcestershire, soy, black pepper, cayenne pepper, hot sauce, and horseradish to bottom of cocktail shaker. Fill shaker with ice and add vodka, tomato juice, and juice of remaining lemon wedge. Shake vigorously, taste for seasoning and heat, and adjust as necessary.')
	insert into Recipe values (11, 3, 'Strain into ice-filled glass. Garnish with celery stalk and serve immediately.')
	
	--Irish Coffee/12
	insert into CocktailIngredient values (12, 29, '1 1/2 oz')--irish whiskey
	insert into CocktailIngredient values (12, 30, '4 oz')--coffee
	insert into CocktailIngredient values (12, 31, '1/4 oz')--simple syrup
	insert into CocktailIngredient values (12, 32, '1 dollop')--cream

	insert into Recipe values (12, 1, 'Combine the coffee, whiskey, and sugar in a hot Irish coffee mug; then float whipped cream on top')
	
	--Negroni/13
	insert into CocktailIngredient values (13, 9, '1 1/2 oz')--gin
	insert into CocktailIngredient values (13, 33, '1 1/2 oz')--campari
	insert into CocktailIngredient values (13, 10, '1 1/2 oz')--sweet vermouth

	insert into Recipe values (13, 1, 'Pour the ingredients into an old-fashioned glass with ice cubes, and stir well')
	
	--Boulevardier/14
	insert into CocktailIngredient values (14, 6, '1 1/4 oz')--bourbon
	insert into CocktailIngredient values (14, 33, '1 oz')--campari
	insert into CocktailIngredient values (14, 10, '1 oz')--sweet vermouth

	insert into Recipe values (14, 1, 'Pour the ingredients into an old-fashioned glass with ice cubes, and stir well')
	
	--Sazerac/15
	insert into CocktailIngredient values (15, 15, '1 1/2 oz')--rye whiskey
	insert into CocktailIngredient values (15, 34, '1 dash')--absinthe
	insert into CocktailIngredient values (15, 35, '2 dashes')--Peychaud's bitters
	insert into CocktailIngredient values (15, 36, '1 splash')--water
	insert into CocktailIngredient values (15, 7, '1 cube')--sugar
	insert into CocktailIngredient values (15, 13, '1 twist')--lemon

	insert into Recipe values (15, 1, 'Fill an Old Fashioned glass with ice. Put the sugar cube in a second Old Fashioned glass with just enough water to moisten it; then crush the cube.')
	insert into Recipe values (15, 2, 'Add the rye, the two bitters, and a few cubes of ice, and stir. Discard the ice from the first glass, and pour in the absinthe.')
	insert into Recipe values (15, 3, 'Turn the glass to coat the sides with the absinthe; then pour out the excess. Strain the rye mixture into the absinthe-coated glass. Twist and squeeze a lemon peel over the glass. Rub the rim of the glass with the peel, discarding it when finished.')
	
	--Vieux Carre/16 done
	insert into CocktailIngredient values (16, 37, '4 dashes')--benedictine
	insert into CocktailIngredient values (16, 35, '2 dashes')--peychauds bitters
	insert into CocktailIngredient values (16, 8, '2 dashes')--angostura bitters
	insert into CocktailIngredient values (16, 15, '1/2 oz')--rye whiskey
	insert into CocktailIngredient values (16, 16, '1/2 oz')--cognac
	insert into CocktailIngredient values (16, 10, '1/2 oz')--sweet vermouth

	insert into Recipe values (16, 1, 'Combine the whiskey, Cognac, vermouth, Bénédictine D.O.M., and both bitters in a cocktail mixer, then fill with ice.')
	insert into Recipe values (16, 2, 'Stir until chilled through, then strain into a chilled cocktail glass.')
	
	--Ramos Fizz/17 *need to make it work with lemons and/or limes
	insert into CocktailIngredient values (17, 9, '2 oz')--gin
	insert into CocktailIngredient values (17, 32, '1 oz')--cream
	insert into CocktailIngredient values (17, 38, '1')--egg white
	insert into CocktailIngredient values (17, 18, '1/2 oz')--lemon juice
	insert into CocktailIngredient values (17, 3, '1/2 oz')--lime juice
	insert into CocktailIngredient values (17, 7, '2 tsp')--sugar
	insert into CocktailIngredient values (17, 39, '1/2 tsp')--orange flower water
	insert into CocktailIngredient values (17, 40, '3 oz')--seltzer

	insert into Recipe values (17, 1, 'Vigorously shake the gin, lemon juice, lime juice, egg white, cream, sugar, and orange flower water with ice')
	insert into Recipe values (17, 2, 'Strain into a 10-ounce highball glass without ice. Pour in club soda to fill')
	
	--Mint Julep/18 done
	insert into CocktailIngredient values (18, 6, '2 1/2 oz')--bourbon
	insert into CocktailIngredient values (18, 7, '1/2 oz')--sugar
	insert into CocktailIngredient values (18, 41, '4-5 sprigs')--mint

	insert into Recipe values (18, 1, 'Place the mint and simple syrup or sugar into a julep cup, collins glass, or double old-fashioned glass.')
	insert into Recipe values (18, 2, 'Muddle well to dissolve the sugar and to release the oil and aroma of the mint.')
	insert into Recipe values (18, 3, 'Add the bourbon.')
	insert into Recipe values (18, 4, 'Fill with crushed ice and stir well until the glass becomes frosty.')
	insert into Recipe values (18, 5, 'Garnish with the mint sprig.')
	
	--Whiskey Sour/19 *need to make it work with lemons and with any type of whiskey
	insert into CocktailIngredient values (19, 6, '1 1/2 oz')--bourbon
	insert into CocktailIngredient values (19, 18, '3/4 oz')--lemon juice
	insert into CocktailIngredient values (19, 7, '1/2 oz')--sugar

	insert into Recipe values (19, 1, 'Add all the ingredients to a shaker and fill with ice')
	insert into Recipe values (19, 2, 'Shake, and strain into a rocks glass filled with fresh ice')
	
	--Mai Tai/20 done
	insert into CocktailIngredient values (20, 42, '2 oz')--dark rum
	insert into CocktailIngredient values (20, 46, '1 oz')--lime
	insert into CocktailIngredient values (20, 43, '1/2 oz')--curacao
	insert into CocktailIngredient values (20, 44, '1/4 oz')--orgeat
	insert into CocktailIngredient values (20, 31, '1/4 oz')--simple syrup
	insert into CocktailIngredient values (20, 41, 'A few sprigs')--mint

	insert into Recipe values (20, 1, 'Pour all ingredients into a cocktail shaker and fill with ice')
	insert into Recipe values (20, 2, 'Shake well for 10 seconds and strain into a double old-fashioned glass filled with crushed ice')
	
	--Planter's Punch/21 *should I add jamaican rum as a category? also make it work with lime
	insert into CocktailIngredient values (21, 42, '3 oz')--Dark rum
	insert into CocktailIngredient values (21, 31, '1 oz')--simple syrup
	insert into CocktailIngredient values (21, 3, '3/4 oz')--lime juice
	insert into CocktailIngredient values (21, 8, '3 dashes')--angostura bitters

	insert into Recipe values (21, 1, 'Combine ingredients in a tall glass and fill with crushed ice. ')
	insert into Recipe values (21, 2, 'Swizzle with a bar spoon until a frost forms on the outside of the glass. The ice will settle as you do this; add more crushed ice to fill, garnish with a mint sprig.')
	
	--Pisco Sour/22 **can also be made with another type of bitters.  also add lime as well
	insert into CocktailIngredient values (22, 50, '3 oz')--pisco
	insert into CocktailIngredient values (22, 3, '1 oz')--lime juice
	insert into CocktailIngredient values (22, 31, '3/4 oz')--simple syrup
	insert into CocktailIngredient values (22, 38, '1')--egg white
	insert into CocktailIngredient values (22, 8, '1 dash')--angostura

	insert into Recipe values (22, 1, 'Combine everything except bitters in a cocktail shaker and seal. Shake vigorously until egg white is foamy, about 10 seconds. ')
	insert into Recipe values (22, 2, 'Add ice to shaker and shake again very hard until well-chilled, about 10 seconds.')
	insert into Recipe values (22, 3, 'Strain into chilled cocktail glass; dash bitters atop the egg-white foam.')
	
	--Cosmopolitan/23 *add it with limes and with cointreau
	insert into CocktailIngredient values (23, 49, '1 1/2 oz')--citrus vodka
	insert into CocktailIngredient values (23, 5, '1/2 oz')--triple sec
	insert into CocktailIngredient values (23, 48, '1/2 oz')--cranberry juice
	insert into CocktailIngredient values (23, 3, '1/4 oz')--lime juice

	insert into Recipe values (23, 1, 'Fill a cocktail shaker with ice. Add vodka, triple sec, cranberry, and lime, and shake well.')
	insert into Recipe values (23, 2, 'Strain into a chilled cocktail glass and garnish with orange twist')
	
	--Tom Collins/24 *need to make it work with lemon
	insert into CocktailIngredient values (24, 9, '2 oz')--gin
	insert into CocktailIngredient values (24, 18, '1/2 oz')--lemon juice
	insert into CocktailIngredient values (24, 7, '1 tsp')--sugar
	insert into CocktailIngredient values (24, 47, '4-6 oz')--club soda

	insert into Recipe values (24, 1, 'Add gin, lemon and sugar to a Collins glass and stir to dissolve sugar')
	insert into Recipe values (24, 2, 'Fill glass with large chunks of ice and top with chilled club soda')
	
	--Last Word/25 *need to make it work with lime
	insert into CocktailIngredient values (25, 9, '3/4 oz')--gin
	insert into CocktailIngredient values (25, 3, '3/4 oz')--lime juice
	insert into CocktailIngredient values (25, 11, '3/4 oz')--maraschino
	insert into CocktailIngredient values (25, 51, '3/4 oz')--Green Charteuse

	insert into Recipe values (25, 1, 'Combine ingredients in a cocktail shaker. Fill with ice, and shake briskly for 10 seconds. Strain into a chilled cocktail glass.')
	
	--Mojito/26
	insert into CocktailIngredient values (26, 2, '1 1/2 oz')--white rum
	insert into CocktailIngredient values (26, 7, '1 tsp')--sugar
	insert into CocktailIngredient values (26, 41, '10 leaves')--mint
	insert into CocktailIngredient values (26, 3, '3/4 oz')--lime juice
	insert into CocktailIngredient values (26, 47, '4 oz')--club soda
	insert into CocktailIngredient values (26, 46, '1 twist')--lime
	
	insert into Recipe values (26, 1, 'Place sugar and mint leaves in a serving glass, and gently muddle just until the leaves release their oils.')
	insert into Recipe values (26, 2, 'Fill glass with ice. Add rum and lime juice. Stir to combine.')
	insert into Recipe values (26, 3, 'Top with club soda and add mint sprigs and lime twist for garnish.')

	--Caipirinha/27
	insert into CocktailIngredient values (27, 52, '2 oz')--Cachaca
	insert into CocktailIngredient values (27, 7, '1-2 tsp')--sugar
	insert into CocktailIngredient values (27, 46, '1/2')--lime
	
	insert into Recipe values (27, 1, 'Place the lime pieces and sugar in the cocktail shaker and crush with the muddler. Add cachaça and a handful of ice;')
	insert into Recipe values (27, 2, 'shake well and pour, unstrained, into a rocks or old fashioned glass.')
	
	--Improved/28
	insert into CocktailIngredient values (28, 53, '2 oz')--genever
	insert into CocktailIngredient values (28, 31, '1/2 tsp')--simple syrup
	insert into CocktailIngredient values (28, 17, '1 tsp')--cointreau
	insert into CocktailIngredient values (28, 8, '2 dashes')--angostura
	insert into CocktailIngredient values (28, 13, '1 peel')--lemon

	insert into Recipe values (28, 1, 'Combine genever, simple syrup, Cointreau (or maraschino), and bitters in a mixing glass and fill with ice. Stir well to chill, about 15 seconds.')
	insert into Recipe values (28, 2, 'Strain into a chilled cocktail glass. Twist a piece of lemon peel over the drink and rub around the rim of the glass.')

	--Corpse Reviver #2/29
	insert into CocktailIngredient values (29, 9, '1 oz')--gin
	insert into CocktailIngredient values (29, 54, '1 oz')--lillet
	insert into CocktailIngredient values (29, 18, '1 oz')--lemon juice
	insert into CocktailIngredient values (29, 17, '1 oz')--cointreau
	insert into CocktailIngredient values (29, 34, '1 drop')--absinthe

	insert into Recipe values (29, 1, 'Add all ingredients to a cocktail shaker; fill with ice and shake well. Strain into a chilled cocktail glass.')

	--Pegu Club/30
	insert into CocktailIngredient values (30, 9, '2 oz')--gin
	insert into CocktailIngredient values (30, 3, '3/4 oz')--lime juice
	insert into CocktailIngredient values (30, 43, '3/4 oz')--curacao
	insert into CocktailIngredient values (30, 8, '1 dash')--angostura

	insert into Recipe values (30, 1, 'Combine ingredients in a cocktail shaker, and fill with ice. Shake well, and strain into a chilled cocktail glass.')
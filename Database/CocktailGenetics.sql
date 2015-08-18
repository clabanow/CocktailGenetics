use FutureCodrDB;

create table Cocktail(
	CocktailId int identity(1,1) not null primary key,
	Name varchar(50) not null,
	ImgUrl varchar(200) null
)
go

create table Ingredient(
	IngredientId int identity(1,1) not null primary key,
	Name varchar(50) not null,
	IsLiquor bit not null
)
go

create table CocktailIngredient(
	CocktailIngredientId int identity(1,1) primary key,
	CocktailId int not null foreign key references Cocktail(CocktailId),
	IngredientId int not null foreign key references Ingredient(IngredientId),
	Amount varchar(30) not null
)
go

create table Recipe(
	RecipeId int identity(1,1) primary key,
	CocktailId int not null foreign key references Cocktail(CocktailId),
	StepNumber int not null,
	[Text] varchar(500) not null
)
go

alter procedure DbReset as
begin
	drop table Recipe
	drop table CocktailIngredient
	drop table Cocktail
	drop table Ingredient

	create table Cocktail(
	CocktailId int identity(1,1) not null primary key,
	Name varchar(50) not null,
	ImgUrl varchar(200) null
	)
	

	create table Ingredient(
		IngredientId int identity(1,1) not null primary key,
		Name varchar(50) not null,
		IsLiquor bit not null
	)
	

	create table CocktailIngredient(
		CocktailIngredientId int identity(1,1) primary key,
		CocktailId int not null foreign key references Cocktail(CocktailId),
		IngredientId int not null foreign key references Ingredient(IngredientId),
		Amount varchar(30) not null
	)

	create table Recipe(
	RecipeId int identity(1,1) primary key,
	CocktailId int not null foreign key references Cocktail(CocktailId),
	StepNumber int not null,
	[Text] varchar(500) not null
    )

	insert into Cocktail values ('Cuba Libre', 'cubalibre')
	insert into Cocktail values ('Margarita', 'margarita')
	insert into Cocktail values ('Old Fashioned', 'oldfashioned')
	insert into Cocktail values ('Martinez', 'martinez')
	insert into Cocktail values ('Martini', 'martini')
	insert into Cocktail values ('Manhattan', 'manhattan')

	insert into Ingredient values ('Coca Cola', 0)
	insert into Ingredient values ('White Rum', 1)
	insert into Ingredient values ('Lime Juice', 0)
	insert into Ingredient values ('Tequila', 1)
	insert into Ingredient values ('Triple Sec', 1)
	insert into Ingredient values ('Bourbon', 1)
	insert into Ingredient values ('Sugar', 0)
	insert into Ingredient values ('Angostura Bitters', 1)
	insert into Ingredient values ('Gin', 1) --9
	insert into Ingredient values ('Sweet Vermouth', 1)
	insert into Ingredient values ('Maraschino', 1)
	insert into Ingredient values ('Orange Bitters', 1)
	insert into Ingredient values ('Lemon Twist', 0)
	insert into Ingredient values ('Dry Vermouth', 1)
	insert into Ingredient values ('Rye Whiskey', 1) --15

	insert into CocktailIngredient values (1, 1, '10 oz')
	insert into CocktailIngredient values (1, 2, '2 oz')
	insert into CocktailIngredient values (1, 3, '1/2')
	insert into CocktailIngredient values (2, 3, '1 oz')
	insert into CocktailIngredient values (2, 4, '1 1/2 oz')
	insert into CocktailIngredient values (2, 5, '1/2 oz oz')
	insert into CocktailIngredient values (3, 6, '2 oz')
	insert into CocktailIngredient values (3, 7, '1 tsp')
	insert into CocktailIngredient values (3, 8, '4 dashes')
	insert into CocktailIngredient values (4, 9, '2 oz')
	insert into CocktailIngredient values (4, 10, '3/4 oz')
	insert into CocktailIngredient values (4, 11, '1/4 oz')
	insert into CocktailIngredient values (4, 12, '1 dash')
	insert into CocktailIngredient values (4, 13, '1')
	insert into CocktailIngredient values (5, 9, '2 1/2 oz')
	insert into CocktailIngredient values (5, 12, '1 dash')
	insert into CocktailIngredient values (5, 14, '1/2 oz')
	insert into CocktailIngredient values (6, 15, '2 oz')
	insert into CocktailIngredient values (6, 10, '1/2 oz')
	insert into CocktailIngredient values (6, 8, '2-3 dashes')

	insert into Recipe values (1, 1, 'Squeeze the juice of half a lime into a collins glass')
	insert into Recipe values (1, 2, 'Add ice cubes')
	insert into Recipe values (1, 3, 'Pour the rum and cola into the glass')
	insert into Recipe values (1, 4, 'Stir well')

	insert into Recipe values (2, 1, 'Pour ingredients into a cocktail shaker with ice cubes')
	insert into Recipe values (2, 2, 'Shake well and pour into glass')

	insert into Recipe values (3, 1, 'Muddle sugar and bitters in an old-fashioned glass')
	insert into Recipe values (3, 2, 'Add bourbon and ice')
	insert into Recipe values (3, 3, 'Stir all ingredients together')

	insert into Recipe values (4, 1, 'Combine ingredients in cocktail shaker with ice')
	insert into Recipe values (4, 2, 'Stir with bar spoon until chilled, about 30 seconds')
	insert into Recipe values (4, 3, 'Strain into a chilled glass and garnish with lemon twist')

	insert into Recipe values (5, 1, 'Combine ingredients in cocktail shaker with ice')
	insert into Recipe values (5, 2, 'Stir with bar spoon until chilled, about 30 seconds')
	insert into Recipe values (5, 3, 'Strain into a chilled glass')

	insert into Recipe values (6, 1, 'Combine ingredients in cocktail shaker with ice')
	insert into Recipe values (6, 2, 'Stir with bar spoon until chilled, about 30 seconds')
	insert into Recipe values (6, 3, 'Strain into a chilled glass')
end

exec dbreset

--Recipe---------------------------------------

create procedure RecipeGetAll as
begin
	select * from Recipe
end
go

create procedure RecipeGetById(
	@RecipeId int
) as
begin
	select * from Recipe where RecipeId = @RecipeId
end
go

create procedure RecipeGetAllByCocktailId(
	@CocktailId int
) as
begin
	select * from Recipe 
	where CocktailId = @CocktailId 
	order by StepNumber
end
go

create procedure RecipeAdd(
	@RecipeId int output,
	@CocktailId int,
	@StepNumber int,
	@Text varchar(500)
) as
begin
	insert into Recipe values (@CocktailId, @StepNumber, @Text)

	set @RecipeId = scope_identity()
end
go

create procedure RecipeEdit(
	@RecipeId int,
	@CocktailId int,
	@StepNumber int,
	@Text varchar(500)
) as
begin
	update Recipe
	set CocktailId = @CocktailId,
	    StepNumber = @StepNumber,
		[Text] = @Text
	where RecipeId = @RecipeId
end
go

create procedure RecipeDelete(
	@RecipeId int
) as 
begin
	delete from Recipe where RecipeId = @RecipeId
end
go

--Cocktail-------------------------------------

create procedure CocktailGetAll as
begin
	select * from cocktail
end
go

create procedure CocktailGetById(
	@CocktailId int
) as
begin
	select *
	from Cocktail 
	where CocktailId = @CocktailId
end
go

alter procedure CocktailAdd(
	@CocktailId int output,
	@Name varchar(50),
	@ImgUrl varchar(200)
) as
begin
	insert into Cocktail values (@Name, @ImgUrl)
	set @CocktailId = scope_identity();
end
go

alter procedure CocktailEdit(
	@CocktailId int,
	@Name varchar(50),
	@ImgUrl varchar(200)
) as
begin
	update Cocktail
		set Name = @Name,
		    ImgUrl = @ImgUrl
		where CocktailId = @CocktailId
end
go

create procedure CocktailDelete(
	@CocktailId int
) as
begin
	begin transaction
		delete from CocktailIngredient where CocktailId = @CocktailId
		delete from Recipe where CocktailId = @CocktailId
		delete from Cocktail where CocktailId = @CocktailId
	commit transaction
end
go

--CocktialIngredient-----------------------------------

create procedure CocktailIngredientGetAll as
begin
	select * from CocktailIngredient
end

create procedure CocktailIngredientGetById(
	@CocktailIngredientId int
) as
begin
	select * from CocktailIngredient 
	where CocktailIngredientId = @CocktailIngredientId
end

alter procedure CocktailIngredientAdd(
	@CocktailIngredientId int output,
	@CocktailId int,
	@IngredientId int,
	@Amount varchar(30)
) as
begin
	insert into CocktailIngredient values (@CocktailId, @IngredientId, @Amount)

	set @CocktailIngredientId = scope_identity();
end

alter procedure CocktailIngredientEdit(
	@CocktailIngredientId int,
	@CocktailId int,
	@IngredientId int,
	@Amount varchar(30)
) as
begin
	update CocktailIngredient
		set CocktailId = @CocktailId,
		    IngredientId = @IngredientId,
			Amount = @Amount
		where CocktailIngredientId = @CocktailIngredientId
end

alter procedure CocktailIngredientIngredientIdGetAllByCocktailId(
	@CocktailId int
) as
begin
	select *
	from CocktailIngredient
	where CocktailId = @CocktailId
	order by CocktailId
end

create procedure CocktailIngredientDelete(
	@CocktailIngredientId int
) as
begin
	delete from CocktailIngredient
	where CocktailIngredientId = @CocktailIngredientId
end

--Ingredient---------------------------

CREATE PROCEDURE IngredientGetAll AS
BEGIN
    SELECT *
    FROM Ingredient
END

CREATE PROCEDURE IngredientGetById(
    @IngredientId int
) AS
BEGIN
    SELECT *
    FROM Ingredient
    WHERE IngredientId=@IngredientId
END


create PROCEDURE IngredientAdd(
    @IngredientId int output,
    @Name varchar(50),
	@IsLiquor bit
) AS
BEGIN
    INSERT INTO Ingredient values(@Name, @IsLiquor)
    SET @IngredientId=scope_identity();
END


create PROCEDURE IngredientEdit(
    @IngredientId int,
    @Name varchar(50),
	@IsLiquor bit
) AS
BEGIN
    UPDATE     Ingredient
    SET     Name=@Name, IsLiquor=@IsLiquor
    WHERE    IngredientId=@IngredientId
END

CREATE PROCEDURE IngredientDelete(
    @IngredientId int
) AS
BEGIN
    begin transaction
    DELETE FROM CocktailIngredient
    WHERE    IngredientId=@IngredientId

    DELETE FROM    Ingredient
    WHERE IngredientId=@IngredientId
    commit transaction
END
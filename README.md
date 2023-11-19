# BarConsoleApp
This program implements a functioning Bar App, which takes in a 
list of customers and has a bartender that serves drinks
recipes are accessed from database tables and built
from the RecipeBuilder class which implements IRecipeBuilder
implementing the adapter design pattern.  Recipes consist of
a Recipe (header) ,  Ingredient list , Instruction list.


Model Builder for the database:



            //Tom Collins:
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 1, RecipeId = 1 ,  IngredientName= "Gin",  Quantity=2d,  Unit="oz"   });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 2, RecipeId = 1, IngredientName = "Lemon Juice", Quantity = 1d, Unit = "oz" });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 3, RecipeId = 1, IngredientName = "Simple Syrup", Quantity = .5d, Unit = "oz" });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 4, RecipeId = 1, IngredientName = "Club Soda", Quantity = .5d, Unit = "oz" });


            //ScrewDriver
            modelBuilder.Entity<Ingredient>().HasData(
              new Ingredient { IngredientId = 5, RecipeId = 2, IngredientName = "Vodka", Quantity = .5d, Unit = "oz" });
            modelBuilder.Entity<Ingredient>().HasData(
              new Ingredient { IngredientId = 6, RecipeId = 2, IngredientName = "Orange Juice", Quantity = 2.5d, Unit = "oz" });


            //Rum and coke
            modelBuilder.Entity<Ingredient>().HasData(
              new Ingredient { IngredientId = 7, RecipeId = 3, IngredientName = "Rum", Quantity = .5d, Unit = "oz" });
            modelBuilder.Entity<Ingredient>().HasData(
              new Ingredient { IngredientId = 8, RecipeId = 3, IngredientName = "Coke", Quantity = 2.5d, Unit = "oz" });



            //Martini
            modelBuilder.Entity<Ingredient>().HasData(
              new Ingredient { IngredientId = 9, RecipeId = 4, IngredientName = "Gin", Quantity = 2.5d, Unit = "oz" });
            modelBuilder.Entity<Ingredient>().HasData(
              new Ingredient { IngredientId = 10, RecipeId = 4, IngredientName = "Dry VermouthCoke", Quantity = .5d, Unit = "oz" });           
            modelBuilder.Entity<Ingredient>().HasData(
              new Ingredient { IngredientId = 11, RecipeId = 4, IngredientName = "Orange Bitters", Quantity = .5d, Unit = "oz" });
            modelBuilder.Entity<Ingredient>().HasData(
              new Ingredient { IngredientId = 12, RecipeId = 4, IngredientName = "Lemon Juice", Quantity = .5d, Unit = "oz" });



            //Instructions

            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                //make tom collins
                Id = 1,
                RecipeId = 1,
                StepNumber = 1,
                Description = "Fill glass with ice, combine all ingredients "
               
            }); 

            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                Id = 2,
                RecipeId = 1,
                StepNumber = 2,
                Description = "add ice and shake, strain ,  place in glass with ice"

            }); 

            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                Id = 3,
                RecipeId = 1,
                StepNumber = 3,
                Description = "top with club soda.  Enjoy  "
            });



            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                Id = 4,
                RecipeId = 2,
                StepNumber = 1,
                Description = " fill glass with ice,  combine ingredients, pour over ice  "
            }); 


            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                Id = 5,
                RecipeId = 2,
                StepNumber = 2,
                Description = " stir well,  serve,  Enjoy  ",

            });


            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                Id = 6,
                RecipeId = 3,
                StepNumber = 1,
                Description = " fill glass with ice,  combine ingredients,  Enjoy  ",

            });


            modelBuilder.Entity<Instruction>().HasData(new Instruction
            {
                Id = 7,
                RecipeId = 4,
                StepNumber = 1,
                Description = " fill glass with ice,  combine ingredients, pour over ice  ",

            });



            //Recipes
            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 1,
                Title = "Tom Collins",                
                Description = "Cool and Refreshing",
            });

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 2,
                Title = "Screw Driver",
                Description = "Fruity and Refreshing"
            });

            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 3,
                Title = "Rum and Coke",
                Description = "Exotic - Good for Pool Party"
            });


            modelBuilder.Entity<Recipe>().HasData(new Recipe
            {
                RecipeId = 4,
                Title = "Martini",
                Description = "Good for Happy Hour "
            });

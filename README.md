# PromotionsEngine
.NET Core C# Console based Promotion Engine app with it Test project

PromotionEngine .NET Core C# Console application =>

IMPORTENT: This is console (an exe) application, developed on .NET Core with Unit Test cases in C# programing language by implementing 2 design patterns (1) Composit pattern and (2) Interface Repository pattern. This app can be run on any plateform like Windows. Mac, Linux etc.

Promotion Engine Console Application Description =>

(A) This application is currently having 3 Promotion types classes. But based upon business requirement we can add more promotion types without interacting\modifying an end user iterface of this application. 
   (1) 3 of A's for 130 
   (2) 2 of B's for 45 
   (3) C & D for 30

(B) These promotion types are having an Interface - IProductPack which is being used to have common method need to be implemented in promotion type and product pack class to leverage [Composit Pattern].

(C) Application is having one service class - CartService with interface - ICartService implementation. This service class is responsible to perform 2 task. 
   (1) Adding the products to oreder list based upon SKU Ids. 
   (2) Calculating the total order value after applying 2 promotion type (currently these 2 promotion types are - (1) and (2) from above point (A))

(D) Service ICartService can be injected as dependency to an end user class to offer its services. So here [Interface Repository] patern is being implemented.

Promotion Engine Test Application Description =>

(A) Test application is having 3 test methods for total order value validation based on those 3 promotion types. These methods calls to AddProduct() method to add products to order list and then returning valid order value equal to an expected value to get successfully passed these test casses.

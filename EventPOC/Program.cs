
using EventPOC.Entitie;
using EventPOC.Service;

var order = new Order { Item = "Pizza with extra cheese" };

var orderingService = new FoodOrderService();
var appService = new AppService();
var mailService = new MailService();

orderingService.FoodPrepared += appService.OnFoodRepared;
orderingService.FoodPrepared += mailService.OnFoodPrepared;



orderingService.OrderCanBeGerated += appService.OnOrderCanBeGerated;

orderingService.PrepareOrder(order);

Console.ReadKey();

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using Xunit;


namespace SportsStore.Tests
{
    public class OrderControllerTests
    {
        [Fact]
        public void Cannot_Checkout_Empty_Cart() {
            //Arrange
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
            //Arrangwe
            Cart cart = new Cart();
            Order order = new Order();
            OrderController target = new OrderController(mock.Object,cart);

            //Act
            ViewResult result = target.Checkout(order) as ViewResult;

            //Assert
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()),Times.Never);

            Assert.True(string.IsNullOrEmpty(result.ViewName));
            Assert.False(result.ViewData.ModelState.IsValid);
        }

        [Fact]
        public void Cannot_chekout_Invalid_ShippingDetails() {
            //Arrange
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
            Cart cart = new Cart();
            cart.AddItem(new Product(), 1);

            OrderController target = new OrderController(mock.Object, cart);
            target.ModelState.AddModelError("error","error");

            //Act
            ViewResult result = target.Checkout(new Order()) as ViewResult;

            //Assert
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()),Times.Never);
            Assert.True(string.IsNullOrEmpty(result.ViewName));
            Assert.False(result.ViewData.ModelState.IsValid);
        }

        [Fact]
        public void Can_checkout_And_submit_order() {
            //Arrange
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
            Cart cart = new Cart();
            cart.AddItem(new Product(),1);

            OrderController target = new OrderController(mock.Object, cart);
                

            //Act
            RedirectToActionResult result = target.Checkout(new Order()) as RedirectToActionResult;


            //Assert
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()), Times.Once);
            Assert.Equal("Completed", result.ActionName);
        }
    }
}

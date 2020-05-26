using GiJoStock.DataModel;
using GiJoStock.DataModel.Data;
using System;

namespace GiJoStock.ViewModel
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public int OrderId => Order.Id;
        public string OrderUser => $"{Order.User.Username}, {Order.User.RoleDesc}";
        public string OrderOffice => $"{Order.Office.Name}";
        public string OrderStatus => $"{(OrderStatus)Order.Status}";
        public DateTime OrderDate => Order.Date;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PCCC.Repositories;

namespace PCCC.Services
{
    class BUS_City
    {//city nam trong dal
        //dung entity đi 
        //no khac gi????
        //nó nhiều tính năng hơn và update của linq to sql
        //Tách model đc còn hiện tại model e đang nằm trong dal luôn rồi
        //vậy làm sao tách ra
        //Code first hay db first ?
        //db lam xong roi ma, gio chi co code thoi.dung code first đi đã lắm

        public IEnumerable<City> LayDsTP()
        {
            return new DAO_City().All();

        }
        public bool ThemMoiTP(int id, string name, string codeCity)
        {
            return new DAO_City().ThemTP(id, name, codeCity);
        }
        public bool SuaTP(int id, string name, string ccity)
        {
            return new DAO_City().SuaTP(id, name, ccity);
        }
        public bool XoaTP(int id)
        {
            return new DAO_City().XoaTP(id);
        }
        public void LoadData(ComboBox cbx)
        {
            var city = new DAO_City().All();
            cbx.DataSource = city;
            cbx.ValueMember = "CCity";
            cbx.DisplayMember = "Name";
        }
    }
}

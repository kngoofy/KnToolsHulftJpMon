using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace KnToolsHulftJpMon
{
    class PrefList
    {
        //
        public ObservableCollection<string> ServerName { get; } = new ObservableCollection<string>();
        public PrefList()
        {
            this.ServerName.Add("サーバ01");
            this.ServerName.Add("サーバ02");
            this.ServerName.Add("サーバ03");
            this.ServerName.Add("サーバ04");
            this.ServerName.Add("サーバ05");
            this.ServerName.Add("サーバ06");
            this.ServerName.Add("サーバ07");
            this.ServerName.Add("サーバ08");
            this.ServerName.Add("サーバ09");
            this.ServerName.Add("サーバ10");
            this.ServerName.Add("サーバ11");
            this.ServerName.Add("サーバ12");

            this.ServerName.Add("サーバ01");
            this.ServerName.Add("サーバ02");
            this.ServerName.Add("サーバ03");
            this.ServerName.Add("サーバ04");
            this.ServerName.Add("サーバ05");
            this.ServerName.Add("サーバ06");
            this.ServerName.Add("サーバ07");
            this.ServerName.Add("サーバ08");
            this.ServerName.Add("サーバ09");
            this.ServerName.Add("サーバ10");
            this.ServerName.Add("サーバ11");
            this.ServerName.Add("サーバ12");

            this.ServerName.Add("サーバ01");
            this.ServerName.Add("サーバ02");
            this.ServerName.Add("サーバ03");
            this.ServerName.Add("サーバ04");
            this.ServerName.Add("サーバ05");
            this.ServerName.Add("サーバ06");
            this.ServerName.Add("サーバ07");
            this.ServerName.Add("サーバ08");
            this.ServerName.Add("サーバ09");
            this.ServerName.Add("サーバ10");
            this.ServerName.Add("サーバ11");
            this.ServerName.Add("サーバ12");

        }

        public void AddNewItem(string server)
        {
            this.ServerName.Add(server);

        }

    }
}

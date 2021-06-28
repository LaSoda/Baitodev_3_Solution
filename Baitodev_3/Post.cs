using System;
using System.Collections.Generic;
using System.Text;

namespace Baitodev_3
{
    public class Post
    {
        /*{
    "id": 1,
    "name": "Leanne Graham",
    "username": "Bret",
    "email": "Sincere@april.biz",
    "address": {
      "street": "Kulas Light",
      "suite": "Apt. 556",
      "city": "Gwenborough",
      "zipcode": "92998-3874",
      "geo": {
        "lat": "-37.3159",
        "lng": "81.1496"
      }*/

        public int id { get; set; }
        public String name { get; set; }
        public String username { get; set; }
        public String email { get; set; }
        public Ob_address address { get; set; }


    }
}

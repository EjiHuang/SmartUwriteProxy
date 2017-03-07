using System;
using BIMT.Util.Serialiaze;
using BIMT.Util.RestAPI;

namespace GoogleSearchApplication
{
    public class BimtProxyService<T>
    {


        T entity;
        public BimtProxyService(string url)
        {
            try
            {
                RestHelper rh = new RestHelper(url, string.Empty, string.Empty);
                string json = rh.SendGet();
                ResponseEntity<T> tt = DeserialiazeClass.Deserialize<ResponseEntity<T>>(json);
                Entity =tt.GetResponse();
            }

            catch (Exception)
            {
                throw;
            }
        }

        public T Entity
        {
            get
            {
                return entity;
            }

            set
            {
                entity = value;
            }
        }

        //public ResponseEntity<T> Tt
        //{
        //    get
        //    {
        //        return tt;
        //    }

        //    set
        //    {
        //        tt = value;
        //    }
        //}
    }
}

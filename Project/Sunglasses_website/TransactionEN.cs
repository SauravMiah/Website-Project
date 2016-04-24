using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace Sunglasses_website
{
    public class TransactionEN
    {
        public TransactionEN()
        {
        }

        public TransactionEN(int transactionId, ,ProductEN product, Datetime transactionDate)
        {
            this.transactionId =  transactionId ;
            this.product =  product ;
            this.transactionDate =  transactionDate ;
        }

        public DataSet searchTransaction(int transactionId)
        {
            TransactionCAD c = new TransactionCAD();
            DataSet datSet = c.searchTransaction(transactionId);

            return datSet;
        }

        private int transactionId;
        private ProductEN product;
        private Datetime transactionDate;

        public int transactionId
        {
            get { return transactionId; }
            set { transactionId = value; }
        }

        public ProductEN Product
        {
            get { return product; }
            set { product = value; }
        }

        public Datetime TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }
    }
}

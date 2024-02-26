// criação de pedido de compra. etapas: confirmação do pagamento, emissão de nota fiscal, envio para trasnprotadora, confirmação de recebimento

namespace ChainOfResponsibility
{


    interface IOrderHandler
    {
        void setNext(IOrderHandler next);
        void handle();
    }

    class OrderbaseHandler : IOrderHandler
    {
        protected string status;
        protected IOrderHandler next;

        public void setNext(IOrderHandler next)
        {
            this.next = next;
        }

        public virtual void handle()
        {
            if (this.next != null)
            {
                Console.WriteLine("HandlingRequest");
                this.next.handle();
            }

        }
    }

    class CheckPayment : OrderbaseHandler
    {
        public override void handle()
        {
            if (this.paymentReceived())
            {
                this.status = "PAYMENT_RECEIVED";
                base.handle();
            }
            else
            {
                throw new Exception("Error while processing payment");
            }
        }

        private bool paymentReceived()
        {
            Console.WriteLine("Reads datafrom DB, queue, other service or API");
            return true;
        }
    }

    class IssueInvoice : OrderbaseHandler
    {
        public override void handle()
        {
            if (this.invoiceIssued())
            {
                this.status = "INVOICE_ISSUED";
                base.handle();
            }
            else
            {
                throw new Exception("Error while trying to issue invoice");
            }
        }

        private bool invoiceIssued()
        {
            Console.WriteLine("Reads datafrom DB, queue, other service or API");
            return true;
        }

    }
    class SendToShiping : OrderbaseHandler
    {
        public override void handle()
        {
            if (this.shippingReceivedPackage())
            {
                this.status = "SENT_TO_SHIPPING";
                base.handle();
            }
            else
            {
                throw new Exception("Error while sending order to shipping");
            }
        }

        private bool shippingReceivedPackage()
        {
            Console.WriteLine("Reads datafrom DB, queue, other service or API");
            return true;
        }
    }
}
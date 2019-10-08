using System;
using System.Collections.Generic;
using System.Linq;
using Payment_API.Model;

namespace Payment_API.Business.Implementation
{
    public class PaymentsDataBusinessImpl : IPaymentsData
    {
        private readonly IClient _client;
        private readonly IBuyer  _buyer;
        private readonly ICard  _card;
        private readonly IPayment _payment;

        public PaymentsDataBusinessImpl(IClient client, IBuyer buyer, ICard card, IPayment payment)
        {
            _client = client;
            _buyer = buyer;
            _card = card;
            _payment = payment;
        }

        public string Create(PaymentsData paymentDados)
        {
            try
            {
                string codBarras ="";

                //Verifica o ID do Cliente
                if (paymentDados.Id_Client <= 0)
                    return "Cliente Inválido!";

                //Verifica já o Buyer já está cadastrado, caso não esteja já cadastra
                var buyer = _buyer.FindAll().Where(p => p.CPF == paymentDados.CPF).FirstOrDefault();
                if (buyer == null)
                {
                    buyer = _buyer.Create(new Buyer
                    {
                        Id_Client = paymentDados.Id_Client,
                        CPF = paymentDados.CPF,
                        Email = paymentDados.Email,
                        Name = paymentDados.Name_Buyer
                    });
                }
                else if (buyer.Name != paymentDados.Name_Buyer || buyer.Email != buyer.Email)
                {
                    return "CPF informado do buyer já existe para outro buyer!";
                }

                //card
                if (paymentDados.Type == "Cartao")
                {
                    var card = _card.FindAll().Where(c => c.Id_Buyer == buyer.Id).FirstOrDefault();
                    if (card == null)
                    {
                        card = _card.Create(new Card
                        {
                            Holder_name = paymentDados.Holder_name,
                            Number = paymentDados.Number,
                            Expiration_date = paymentDados.Expiration_date,
                            CVV = Convert.ToInt32(paymentDados.CVV),
                            Id_Buyer = Convert.ToInt64(buyer.Id)
                        });
                    }

                    //pagamento com cartão
                    var payment = _payment.Create(new Payment()
                    {
                        Id_Buyer = Convert.ToInt64(buyer.Id),
                        Id_Card = Convert.ToInt64(card.Id),
                        Amount = paymentDados.Amount,
                        Type = paymentDados.Type,
                        Card = paymentDados.Card,
                        Status = (buyer.Name != card.Holder_name ? "Pendente" : "Efetivado"),
                        Cod_barras = ""
                    });
                }
                else //Boleto
                {
                    //pagamento no boleto
                    codBarras = GerarCod();
                    var payment = _payment.Create(new Payment()
                    {
                        Id_Buyer = Convert.ToInt64(buyer.Id),
                        Amount = paymentDados.Amount,
                        Type = paymentDados.Type,
                        Card = paymentDados.Card,
                        Status = "Aguardando Pagamento",
                        Cod_barras = codBarras
                    });
                }

                return (codBarras == "" ? "Pagamento cadastrado!" : codBarras);
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Payment> FindAll()
        {
            try
            {
                return _payment.FindAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GerarCod()
        {

            Random rand = new Random();

            string Banco = rand.Next(100, 999).ToString();
            string DigitoBanco = rand.Next(1, 9).ToString();

            string PrimeiraParte = Banco + rand.Next(10, 99).ToString();
            string SegundaParte = rand.Next(10000, 99999).ToString();

            string TerceiraParte = rand.Next(10000, 99999).ToString();
            string QuataParte = rand.Next(100000, 999999).ToString();

            string QuintaParte = rand.Next(10000, 99999).ToString();
            string SextaParte = rand.Next(100000, 999999).ToString();

            string SetimaParte = rand.Next(1, 9).ToString();

            string OitavaParte = rand.Next(1000000, 9999999).ToString() + rand.Next(1000000, 9999999).ToString();

            return String.Format("|{0}-{1}| {2}.{3}   {4}.{5}   {6}.{7}   {8}   {9}", 
                                Banco, DigitoBanco, PrimeiraParte, SegundaParte, TerceiraParte, QuataParte, 
                                QuintaParte, SextaParte, SetimaParte, OitavaParte);
        }

    }
}

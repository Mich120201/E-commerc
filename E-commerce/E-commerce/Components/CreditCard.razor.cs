using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Checkout.Common;
using Checkout.Payments;
using Checkout.Payments.Request;
using Checkout.Payments.Request.Source;
using NuGet.Protocol;
using System.Text;
using ecommerce.Models.CardDetailsInputModel;
using Microsoft.AspNetCore.Components;

namespace ecommerce.Components
{
    public partial class CreditCard
    { 
        private string? applicationUrl { get; set; }
        private async Task ProcessRequestPayment(CardDetailsInputModel cardDetailsInputModel)
        {
            HttpClient client = new HttpClient();

            applicationUrl = Environment.GetEnvironmentVariable("ASPNETCORE_URLS");

            cardDetailsInputModel.Amount = Amount;
            HttpResponseMessage response = new();
            if (applicationUrl != null)
            {
                response = await client.PostAsJsonAsync($"{applicationUrl.Split(";")[0] ?? applicationUrl.Split(";")[1]}/api/CheckoutPaymentRequest", cardDetailsInputModel);
            }

            if(response == null) SuccessPaymentCode = 0;
            if(response != null)
            {
                if(response.IsSuccessStatusCode) SuccessPaymentCode = 1;
                else SuccessPaymentCode = 0;
            }
        }
        private void FormatName(string? Value)
        {
            if (Value == null) return;
            string input = new string(Value.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());
            if(input.Length == 0) nameClass = "form-control credit-form-input is-invalid";
            if (input.Length > 0 && input.Length < 51) nameClass = "form-control credit-form-input is-valid";
            creditCardModel.Name = input;
        }

        private void FormatSurname(string? Value)
        {
            if (Value == null) return;
            string input = new string(Value.Where(char.IsLetter).ToArray());
            if(input.Length == 0) surnameClass = "form-control credit-form-input is-invalid";
            if (input.Length > 0 && input.Length < 51) surnameClass = "form-control credit-form-input is-valid";
            creditCardModel.Surname = input;
        }

        private void FormatCreditCardNumber(string? Value)
        {
            if (Value == null) return;
            string input = new string(Value.Where(char.IsDigit).ToArray());
            bool valid = ValidateCreditCard(input);
            cardNumberClass = valid && input.Length == 0 ? "form-control credit-form-input" : "form-control credit-form-input is-invalid";
            if (input.Length == 15 || input.Length == 16 && valid) cardNumberClass = "form-control credit-form-input is-valid";
            creditCardModel.CardNumber = string.Join(" ", Enumerable.Range(0, (input.Length + 3) / 4).Select(i => input.Substring(i * 4, Math.Min(4, input.Length - i * 4))));
        }

        private void FormatCvvNumber(string? Value)
        {
            if (Value == null) return;
            string input = new string(Value.Where(char.IsDigit).ToArray());
            bool valid = ValidateCvv(input);
            CvvNumberCLass = valid && input.Length == 0 ? "form-control credit-form-input" : "form-control credit-form-input is-invalid";
            if (input.Length > 2 && input.Length < 5 && valid) CvvNumberCLass = "form-control credit-form-input is-valid";

            creditCardModel.Cvv = input;
        }

        private void FormatExpiryDate(string? Value)
        {
            if (Value == null) return;
            string month, year;
            month = FormatMonth(Value);
            year = FormatYear(Value);
            bool validMonth = ValidateMonth(month);
            bool validYear = ValidateYear(year);
            string input = month + (Value.Length > 1 ? "/" : "") + year;
            creditCardModel.ExpiryDate = input;
            expiryDateClass = validMonth && validYear ? "form-control credit-form-input is-valid" : "form-control credit-form-input is-invalid";
        }

        private string FormatMonth(string? Value)
        {
            if (Value == null) return string.Empty;
            string month;
            if(Value.Contains('/')) month = new string(Value.Split('/').First().Where(char.IsDigit).ToArray());
            else month = new string(Value.Where(char.IsDigit).ToArray());
            if(month.Length == 0) return string.Empty;
            if (int.TryParse(month.First().ToString(), out int IntFirstDigit))
            {
                if(IntFirstDigit > 1) return string.Empty;
            }
            if (int.TryParse(month.Last().ToString(), out int IntSecondDigit))
            {
                if (IntSecondDigit > 2 && IntFirstDigit == 1) return string.Empty;
            }
            if (IntFirstDigit == 0 && IntSecondDigit == 0 && month.Length > 1) return string.Empty;
            return month;
        }

        private string FormatYear(string? Value)
        {
            if(Value == null) return string.Empty;
            string year;
            if (Value.Contains('/')) year = new string(Value.Split('/').Last().Where(char.IsDigit).ToArray());
            else year = string.Empty;
            if(year.Length > 2) year = year.Substring(0, 2);
            return year;
        }

        private bool ValidateCreditCard(string cardNumber)
        {
            if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length < 13 || cardNumber.Length > 16) return false;
            if (cardNumber.All(Char.IsLetter)) return false;
            return true;
        }

        private bool ValidateCvv(string Cvv)
        {
            if (string.IsNullOrWhiteSpace(Cvv) || Cvv.Length > 4) return false;
            if (Cvv.All(Char.IsLetter)) return false;
            return true;
        }

        private bool ValidateMonth(string Month)
        {
            if (string.IsNullOrWhiteSpace(Month) || Month.Length != 2) return false;
            if (int.TryParse(Month, out int IntMonth))
            {
                if (IntMonth < 1) return false;
                if (IntMonth > 12) return false;
                return true;
            }
            return false;
        }

        private bool ValidateYear(string Year)
        {
            if (string.IsNullOrWhiteSpace(Year) || Year.Length != 2) return false;
            if (int.TryParse(Year, out int IntYear))
            {
                if (IntYear < 1) return false;
                if (IntYear > 99) return false;
            }
            return true;
        }
        private async Task HandleValidSubmit()
        {
            paymentSend = true;
            await ProcessRequestPayment(creditCardModel);
        }
    }
}

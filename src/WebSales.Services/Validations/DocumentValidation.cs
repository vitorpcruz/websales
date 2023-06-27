﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using WebSales.Domain.Notifications;

namespace WebSales.Service.Validations
{ 
    public class DocumentValidation : ValidationAttribute
    {
        public const string CpfRegex = @"[0-9]{3}\.[0-9]{3}\.[0-9]{3}\-[0-9]{2}";
        public const string CnpjRegex = @"[0-9]{2}\.[0-9]{3}\.[0-9]{3}\/[0-9]{4}\-[0-9]{2}";
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
                return new ValidationResult(CustomerNotifications.DocumentNullOrWhiteSpaceNotification);

            if (Regex.IsMatch(value.ToString(), CpfRegex))
                return IsCpf(value.ToString()) ? ValidationResult.Success : new ValidationResult(CustomerNotifications.DocumentCpfInvalid);

            if (Regex.IsMatch(value.ToString(), CnpjRegex))
                return IsCnpj(value.ToString()) ? ValidationResult.Success : new ValidationResult(CustomerNotifications.DocumentCnpjInvalid);

            return new ValidationResult(CustomerNotifications.DocumentInvalidNotification);
        }

        // macoratti source code
        // https://www.macoratti.net/11/09/c_val1.htm
        public bool IsCpf(string cpf)
        {
            int[] multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digit;
            int sum;
            int rest;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11) return false;

            tempCpf = cpf.Substring(0, 9);
            sum = 0;

            for (int i = 0; i < 9; i++) sum += int.Parse(tempCpf[i].ToString()) * multiplier1[i];

            rest = sum % 11;

            if (rest < 2) rest = 0;
            else rest = 11 - rest;

            digit = rest.ToString();
            tempCpf = tempCpf + digit;
            sum = 0;

            for (int i = 0; i < 10; i++) sum += int.Parse(tempCpf[i].ToString()) * multiplier2[i];
            rest = sum % 11;

            if (rest < 2) rest = 0;
            else rest = 11 - rest;

            digit = digit + rest.ToString();

            return cpf.EndsWith(digit);
        }

        public bool IsCnpj(string cnpj)
        {
            int[] multiplier1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum;
            int rest;
            string digit;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14) return false;
            tempCnpj = cnpj.Substring(0, 12);
            sum = 0;

            for (int i = 0; i < 12; i++) sum += int.Parse(tempCnpj[i].ToString()) * multiplier1[i];
            rest = sum % 11;

            if (rest < 2) rest = 0;
            else rest = 11 - rest;

            digit = rest.ToString();
            tempCnpj = tempCnpj + digit;
            sum = 0;

            for (int i = 0; i < 13; i++) sum += int.Parse(tempCnpj[i].ToString()) * multiplier2[i];
            rest = sum % 11;

            if (rest < 2) rest = 0;
            else rest = 11 - rest;

            digit = digit + rest.ToString();

            return cnpj.EndsWith(digit);
        }
    }

}
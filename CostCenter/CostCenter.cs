﻿namespace financeAPI.Models
{
    public class CostCenter
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

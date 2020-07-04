using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;


namespace Dev01.Json {
    public class RD {
        public List<Record> leads { get; set; }
    }

    
    public class Record {
        
        [Key]
        public int id {get; set;}

        public string name {get; set;}
        public string email {get; set;}
        //public List<Custom> custom_fields {get; set;}
    }

    public class Custom {

        [JsonProperty("Interesse em")] //interesse em
        public string Interesse {get; set;}
        [JsonProperty("Faixa de investimento OK")] //faixa de investimento OK
        public string FaixaInvest {get; set;}
        [JsonProperty("Mensagem")] // mensagem
        public string Mensagem {get; set;}
    }
}
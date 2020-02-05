namespace webAppCognizantTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Nome é de preenchimento obrigatório")]
        [StringLength(100)]
        public string name { get; set; }

        [Required(ErrorMessage = "Campo Email é de preenchimento obrigatório")]
        [StringLength(50)]
        public string email { get; set; }

        [Required(ErrorMessage = "Campo Celular é de preenchimento obrigatório")]
        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [StringLength(20)]
        public string neighborhood { get; set; }

        [StringLength(20)]
        public string city { get; set; }

        [StringLength(20)]
        public string state { get; set; }
    }
}

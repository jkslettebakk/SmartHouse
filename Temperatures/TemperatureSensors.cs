using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TemperaturesNamespace
{
    public class TemperatureSensors
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TemperatureId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime SensorTankTimeStamp { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal SensorTankTemp { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal SensorVpTurTemp { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal SensorVpReturTemp { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal SensorGulvTurTankTemp { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal SensorGulvReturTankTemp { get; set; }

        [Required]
        [Column(TypeName = "decimal(4,1)")]
        public decimal IndorTemperature { get; set; }

        [Required]
        [Column(TypeName = "decimal(4,1)")]
        public decimal OutdorTemperature { get; set; }
    };

}

namespace PointPositionsNamespace
{

    public class PointPosition
    {
        [Key]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; }
        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Temperature { get; set; }
    };

}

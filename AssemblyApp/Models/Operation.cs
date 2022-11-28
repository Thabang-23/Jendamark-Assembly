using System.ComponentModel.DataAnnotations;

namespace AssemblyApp.Models
{
    public class Operation
    {
        public int OperationID { get; set; }
        [Required(ErrorMessage = "The Name field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int OrderInWhichToPerform { get; set; }
        public byte[] ImageData { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int DeviceID { get; set; }
        public Device Device { get; set; }
    }
}
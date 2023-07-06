using System;
using System.Collections.Generic;

namespace JobManagementService.Data.Entity;

public partial class TbJobType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}

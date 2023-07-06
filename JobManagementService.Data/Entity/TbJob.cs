using System;
using System.Collections.Generic;

namespace JobManagementService.Data.Entity;

public partial class TbJob
{
    public int Id { get; set; }

    public string Job { get; set; } = null!;

    public int JobTypeId { get; set; }

    public string Description { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}

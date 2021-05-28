using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public int SomeProperty { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; }
  }
}
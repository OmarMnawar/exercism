static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id == null)
        {
            if (department == null)            
                return $"{name} - OWNER";
            else
                return $"{name} - {department.ToUpper()}";
        }
        else
        {
            if (department == null)            
                return $"[{id}] - {name} - OWNER"; 
            else            
                return $"[{id}] - {name} - {department.ToUpper()}";        
                
        }
    }
}

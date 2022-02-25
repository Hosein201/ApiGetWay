namespace OrderProcessing.Mapper.Dto.Permission
{
    public class InsertPermissionDto
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string FullUrl { get; set; }
        public int RoleCode { get; set; }
        public string RoleName { get; set; }
        public bool Active { get; set; }
    }
}

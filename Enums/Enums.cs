namespace UniversityManagement.Enums
{
    public enum Gender
    {
        Male = 0,
        Female = 1,
    }
    public enum Department
    {
        ComputerScience = 0,
        Electrical = 1,
        Mechanical = 2,
        Civil = 3,
        BBA = 4,
        Humanities = 5,
        ManagementScience = 6,
        Law = 7,
    }
    public enum Grade
    {
        A = 4, B = 3, C = 2, D = 1, F = 0, un = -1,
    }
    public enum CourseType
    {
        Core = 0,
        Elective = 1
    }
    public enum University
    {
        FAST = 0,
        UOL = 1,
        PU = 2,
        UCP = 3,
        USA = 4,
        LUMS = 5,
        COMSAT = 6,
        NUST = 7,
    }
    public enum SmesterType
    {
        Spring = 0,
        Fall = 1,
        Summer = 2,
    }
}
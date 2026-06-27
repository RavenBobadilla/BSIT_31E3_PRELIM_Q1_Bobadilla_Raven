public static class TransportResolver
{
    public static object Resolve(string transportType)
    {
        switch (transportType.ToLower())
        {
            case "car":
                return new Car();

            case "plane":
                return new Airplane();

            case "boat":
                return new Boat();

            case "helicopter":
                return new Helicopter();

            default:
                return null;
        }
    }
}
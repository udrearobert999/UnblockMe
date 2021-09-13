namespace UnblockMe.Dtos
{

    public class BlockingInteraction
    {
        public BlockingInteraction(string blockedCarLicensePlate, string blockingCarLicensePlate, double blockedCarLat, double blockedCarLng)
        {
            BlockedCarLicensePlate = blockedCarLicensePlate;
            BlockingCarLicensePlate = blockingCarLicensePlate;
            BlockedCarLat = blockedCarLat;
            BlockedCarLng = blockedCarLng;
        }

        public BlockingInteraction()
        {
        }

        public string BlockedCarLicensePlate { get; set; }
        public string BlockingCarLicensePlate { get; set; }
        public double BlockedCarLat { get; set; }
        public double BlockedCarLng { get; set; }
    }

}

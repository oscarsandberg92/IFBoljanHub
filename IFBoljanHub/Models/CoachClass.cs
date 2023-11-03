using System.Net;

namespace IFBoljanHub.Models;

public class CoachClass
{
    public List<Coach> coachList;

    public CoachClass()
    {
        coachList = new List<Coach>();
    }


    public List<Coach> GetAllCoaches()
    {
        coachList.Add(new Coach
        {
            Name = "Jimmy",
            Number = 0722344556,
            Mail = "jimmy@ifboljan.nu",
            Description = "Coachar Flickor ålder 6 till 15",
            Picture =
                "https://media.cnn.com/api/v1/images/stellar/prod/150519161256-44-texas-biker-mugshots.jpg?q=w_2000,h_1125,x_0,y_0,c_fill/h_778"
        });
        coachList.Add(new Coach
        {
            Name = "Jimmy",
            Number = 0722344556,
            Mail = "jimmy@ifboljan.nu",
            Description = "Coachar Flickor ålder 6 till 15",
            Picture =
                "https://media.cnn.com/api/v1/images/stellar/prod/150519161256-44-texas-biker-mugshots.jpg?q=w_2000,h_1125,x_0,y_0,c_fill/h_778"
        });
        coachList.Add(new Coach
        {
            Name = "Jimmy",
            Number = 0722344556,
            Mail = "jimmy@ifboljan.nu",
            Description = "Coachar Flickor ålder 6 till 15",
            Picture =
                "https://media.cnn.com/api/v1/images/stellar/prod/150519161256-44-texas-biker-mugshots.jpg?q=w_2000,h_1125,x_0,y_0,c_fill/h_778"
        });
        coachList.Add(new Coach
        {
            Name = "Jimmy",
            Number = 0722344556,
            Mail = "jimmy@ifboljan.nu",
            Description = "Coachar Flickor ålder 6 till 15",
            Picture =
                "https://media.cnn.com/api/v1/images/stellar/prod/150519161256-44-texas-biker-mugshots.jpg?q=w_2000,h_1125,x_0,y_0,c_fill/h_778"
        });
        coachList.Add(new Coach
        {
            Name = "Jimmy",
            Number = 0722344556,
            Mail = "jimmy@ifboljan.nu",
            Description = "Coachar Flickor ålder 6 till 15",
            Picture =
                "https://media.cnn.com/api/v1/images/stellar/prod/150519161256-44-texas-biker-mugshots.jpg?q=w_2000,h_1125,x_0,y_0,c_fill/h_778"
        });
        coachList.Add(new Coach
        {
            Name = "Jimmy",
            Number = 0722344556,
            Mail = "jimmy@ifboljan.nu",
            Description = "Coachar Flickor ålder 6 till 15",
            Picture =
                "https://media.cnn.com/api/v1/images/stellar/prod/150519161256-44-texas-biker-mugshots.jpg?q=w_2000,h_1125,x_0,y_0,c_fill/h_778"
        });
        coachList.Add(new Coach
        {
            Name = "Jimmy",
            Number = 0722344556,
            Mail = "jimmy@ifboljan.nu",
            Description = "Coachar Flickor ålder 6 till 15",
            Picture =
                "https://media.cnn.com/api/v1/images/stellar/prod/150519161256-44-texas-biker-mugshots.jpg?q=w_2000,h_1125,x_0,y_0,c_fill/h_778"
        });
        coachList.Add(new Coach
        {
            Name = "Jimmy",
            Number = 0722344556,
            Mail = "jimmy@ifboljan.nu",
            Description = "Coachar Flickor ålder 6 till 15",
            Picture =
                "https://media.cnn.com/api/v1/images/stellar/prod/150519161256-44-texas-biker-mugshots.jpg?q=w_2000,h_1125,x_0,y_0,c_fill/h_778"
        });

        return coachList;
    }
}
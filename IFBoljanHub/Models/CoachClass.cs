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
            Name = "Jakob Nilsson",
            Number = 0722344556,
            Mail = "jakob.nilsson@ifboljan.nu",
            Description = "Herr",
            Picture =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSageOcf0rgRFcXJPKCglKQh5cXNH1Kdyl28SsNWKLuAtlIBmMFUXxAOHTxF7y_HCVx2VM&usqp=CAU"
        });
        coachList.Add(new Coach
        {
            Name = "Fredrik Nilsson",
            Number = 072358698,
            Mail = "fredrik.nilsson@ifboljan.nu",
            Description = "Herr",
            Picture =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSW9uAeLVBoahfQVeFDWlrLHEhyCvri4tacDPIqqfboQvzK_-8ZLDvV4DUkoMdTYYQytxM&usqp=CAU"
        });
        coachList.Add(new Coach
        {
            Name = "Josefin Blidberg",
            Number = 0730585698,
            Mail = "josefin.blidberg@ifboljan.nu",
            Description = "Dam",
            Picture =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8shW3VfcPWHjMu-qbiCJA7kzNe_oaWliZpQ&usqp=CAU"
        });
        coachList.Add(new Coach
        {
            Name = "Tobias Josefsson",
            Number = 0724698321,
            Mail = "tobias.josefsson@ifboljan.nu",
            Description = "Dam",
            Picture =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrJ3k9LQ8fQqoiXYkNpYcuk_pWZbJF89IJDEQpdAswAw-BbsyEYAOGCzanx1rbLHB1KEc&usqp=CAU"
        });
        coachList.Add(new Coach
        {
            Name = "Mikael Karlsson",
            Number = 072258215,
            Mail = "mikael.karlsson@ifboljan.nu",
            Description = "Herrjuniorer (P11/12)",
            Picture =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwbREVPF9_BxcBA5zaq1HygofH4w_run2pjMV6qy6HnGudUrjNBdputVnzmm9k1S763uk&usqp=CAU"
        });
        coachList.Add(new Coach
        {
            Name = "Fidan Ibishi",
            Number = 0745955875,
            Mail = "fidan.ibishi@ifboljan.nu",
            Description = "Herrjuniorer (P05/06)",
            Picture =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-Pg-F2YFnlvsAfPsLRuyxwc3i9eccA_hVhjUwhP2bfdRYvruY1kWt0brO7y9awTUZEiI&usqp=CAU"
        });
        coachList.Add(new Coach
        {
            Name = "Joel Nilsson",
            Number = 0726369877,
            Mail = "joel.nillson@ifboljan.nu",
            Description = "Målvaktsgrupp",
            Picture =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTUJZZPuxb8WK1U_ouiG_501-NTHzd-foCe6mANC_VVed0CCESZqi0hZjnCbDCTNTFyuQw&usqp=CAU"
        });
        coachList.Add(new Coach
        {
            Name = "Marcus Gyllenstolpe",
            Number = 0730856974,
            Mail = "marcus.gyllenstolpe@ifboljan.nu",
            Description = "Målvaktsgrupp",
            Picture =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5Qk3puTmWsuH7l5cSEeE1RLFcfWbwRo2-h6g778cfu6KDTJAgp7AGhQhcit4btRWsUjA&usqp=CAU"
        });

        return coachList;
    }
}
// 1
//int[] answer = new int[2];
//for (int i = 0; i < answer.Length; i++)
//{
//    answer[i] = Convert.ToInt32(Console.ReadLine());
//}
//if (answer[0] > answer[1])
//Console.WriteLine("nums1 > nums2");
//else Console.WriteLine("nums2 > nums1");

// 2
//int number = Convert.ToInt32(Console.ReadLine());
//if (5 < number & number < 10)
//{
//    Console.WriteLine($"Bu tegishliy son! {number}");
//}
//else Console.WriteLine($"Bu tegishliy son emas! {number}");

// 3 
//double depozit = Convert.ToDouble(Console.ReadLine());
//double jami1 = (depozit / 100 * 105);
//double jami2 = (depozit / 100 * 107);
//double jami3 = (depozit / 100 * 110);
//if (depozit < 100)
//{
//    Console.WriteLine($"Sizning kiritgan depozitingiz {depozit} => 5% ustama (depozit / 100 * 105) = {jami1}");
//}
//else if (depozit >= 100 & depozit < 200)
//{
//    Console.WriteLine($"Sizning kiritgan depozitingiz {depozit} => 7% ustama (depozit / 100 * 107) = {jami2}");
//}
//else
//{
//    Console.WriteLine($"Sizning kiritgan depozitingiz {depozit} => 10% ustama (depozit / 100 * 110) = {jami3}");
//}

// 4 
//double depozit = Convert.ToDouble(Console.ReadLine());
//double jami1 = (depozit / 100 * 105 + 15);
//double jami2 = (depozit / 100 * 107 + 15);
//double jami3 = (depozit / 100 * 110 + 15);
//if (depozit < 100)
//{
//    Console.WriteLine($"Sizning kiritgan depozitingiz {depozit} => 5% ustama (depozit / 100 * 105) bonus 15 $ = {jami1}");
//}
//else if (depozit >= 100 & depozit < 200)
//{
//    Console.WriteLine($"Sizning kiritgan depozitingiz {depozit} => 7% ustama (depozit / 100 * 107) bonus 15 $ = {jami2}");
//}
//else
//{
//    Console.WriteLine($"Sizning kiritgan depozitingiz {depozit} => 10% ustama (depozit / 100 * 110) bonus 15 $ = {jami3}");
//}
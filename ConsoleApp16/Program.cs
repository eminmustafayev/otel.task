using Core.Models;
using Core.Data;
using Core.Exceptions;
using System;

bool isMainLoop = false;

do
{
    Console.WriteLine("1. Sisteme giris edin || 0. Sistemden cixis edin");
    string secim = Console.ReadLine();
    switch (secim)
    {
        case "0":
            isMainLoop = true;
            Console.WriteLine("Sistemden cixis edilir...");
            break;

        case "1":
            Console.WriteLine("Sisteme giris edilir...");
            bool isHotelLoop = false;

            do
            {
                Console.WriteLine("1. Hotel elave et \n2. Butun hotelleri gor \n3. Hotel sec \n0. Exit");
                string secim2 = Console.ReadLine();
                switch (secim2)
                {
                    case "0":
                        isHotelLoop = true;
                        break;

                    case "1":
                        Console.WriteLine("Hotel elave edilir...");
                        Console.WriteLine("Hotel adi daxil edin:");
                        string hotelName = Console.ReadLine();
                        Hotel hotel = new Hotel(hotelName);
                        AppDbContext.AddHotels(hotel);
                        break;





                    case "2":
                        AppDbContext.ShowHotelNames();
                        break;
                    case "3":
                        Console.WriteLine("Hotel secin:");
                        hotelName = Console.ReadLine();
                        if (AppDbContext.HotelExists(hotelName))
                        {
                            Console.WriteLine("Hotel menyusuna daxil oldunuz...");
                            bool isRoomLoop = false;

                            do
                            {
                                Console.WriteLine("1) Otaq yarat         2) Otaqlari gor   3) Rezervasiya et   4) Evvelki menuya qayit   0) Exit");
                                string roomSecim = Console.ReadLine();
                                switch (roomSecim)
                                {
                                    case "1":
                                        Console.WriteLine("Otaq adi daxil edin:");

                                        string roomName = Console.ReadLine();

                                        Console.WriteLine("Otaq qiymetini daxil edin:");
                                        double roomPrice = Console.ReadLine();
                                        Console.WriteLine("Otaq tutumunu daxil edin:");


                                        int roomCapacity =  Console.ReadLine();
                                        Room room = new Room(roomName, roomCapacity, roomPrice);
                                        AppDbContext.AddRooms(room);
                                        break;

                                    case "2":
                                        AppDbContext.ShowRoomsNames();
                                        break;

                                    case "3":
                                        Console.WriteLine("Rezervasiya üçün otaq ID daxil edin:");
                                        int roomId = Console.ReadLine();
                                        Console.WriteLine("Musteri sayini daxil edin:");
                                        int customerCount = Console.ReadLine();
                                        try
                                        {
                                            AppDbContext.MakeReservation(customerCount, roomId);
                                            Console.WriteLine("Rezervasiya uğurla tamamlandı.");
                                        }
                                        catch (NotAvailableException ex)
                                        {
                                            Console.WriteLine($"Xeta: {ex.Message}");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine($"Xeta: {ex.Message}");
                                        }
                                        break;

                                    case "4":
                                        isRoomLoop = true;
                                        break;


                                    case "0":
                                        isMainLoop = true;
                                        break;
                                }
                            } while (!isRoomLoop);
                        }
                        else
                        {
                            Console.WriteLine("Bele bir otel tapilmadi.");
                        }
                        break;

                    default:
                        break;
                }
            } while (!isHotelLoop);
            break;

        default:
            break;
    }
} while (!isMainLoop);

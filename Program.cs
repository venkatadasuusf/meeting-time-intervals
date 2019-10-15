using System;
using System.Collections.Generic;
using System.Linq;

namespace meeting_time_intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int[,] array2D = new int[,] { { 0, 10 }, { 5, 12 }, { 6, 13 }, { 7, 14 }, { 11, 15 }, { 12, 20 }, { 15, 30 } };
                int[,] array2D = new int[,] { { 0, 30 }, { 5, 10 }, { 15, 20 } };
                int[] start_times = new int[(array2D.Length) / 2];
                int[] end_times = new int[(array2D.Length) / 2];

                for (int i = 0; i < (array2D.Length) / 2; i++)
                {
                    start_times[i] = array2D[i, 0];
                    end_times[i] = array2D[i, 1];
                }

                Array.Sort(start_times);
                Array.Sort(end_times);

                /*
                
                int room_updated = 0;
                Dictionary<int, int> conf_rooms = new Dictionary<int, int>();
                conf_rooms.Add(1, end_times[0]);

                for (int i = 1; i < start_times.Length; i++)
                {
                    room_updated = 0;
                    for (int j = 1; j <= (conf_rooms.Count); j++)
                    {
                        //if (start_times[i] >= conf_rooms[j])
                        if (start_times[i] > conf_rooms[j])
                        {
                            conf_rooms[j] = end_times[i];
                            room_updated = 1;
                            break;
                        }
                    }

                    if (room_updated == 0)
                    {
                        conf_rooms.Add((conf_rooms.Count + 1), end_times[i]);
                    }

                }

                Console.WriteLine(conf_rooms.Count);
                */

                int start = 1, end = 0;
                int conf_rooms_count = 1;

                
                while (start < start_times.Length && end < end_times.Length)
                {
                    if (start_times[start] > end_times[end])
                    {
                        start++;
                        end++;
                    }
                    else
                    {
                        conf_rooms_count++;
                        start++;
                    }
                }

                Console.WriteLine(conf_rooms_count);
                
            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing Intersect()");

            }   // End of catch

        }
    }
}

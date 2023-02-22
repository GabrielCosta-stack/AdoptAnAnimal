using API.Entities;
using API.Persistence;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
               var tiger = await CreateSpecie("Tiger",  @"The tiger is the largest living cat species and a member of the genus Panthera.
                             It is most recognisable for its dark vertical stripes on orange fur with a white underside.
                              An apex predator, it primarily preys on ungulates, such as deer and wild boar.", context);
                
               var africanWildDog = await CreateSpecie("African Wild Dog", @"The African wild dog, also called the painted dog or Cape hunting dog,
                             is a wild canine which is a native species to sub-Saharan Africa." , context);

               var chimpanzee = await CreateSpecie("Chimpanzee",  @"The chimpanzee, also known as simply the chimp, is a 
                            species of great ape native to the forest and savannah of tropical Africa. 
                            It has four confirmed subspecies and a fifth proposed subspecies.", context);          
               
               var blackRhinoceros = await CreateSpecie("Black rhinoceros", @"The black rhinoceros, black rhino or hook-lipped rhinoceros is a species of rhinoceros, native to eastern and southern Africa including Angola,
                             Botswana, Kenya, Malawi, Mozambique, Namibia, South Africa, Eswatini, Tanzania, Zambia, and Zimbabwe" , context);
               
               var javanRhinoceros = await CreateSpecie("Javan rhinoceros", @"The Javan rhinoceros, also known as the Javan rhino, Sunda rhinoceros or lesser one-horned rhinoceros,
                             is a very rare member of the family Rhinocerotidae and one of five extant rhinoceroses.", context);
               
               var giantPanda = await CreateSpecie("Giant Panda", @"The giant panda, is a bear species endemic to China. It is characterised by its bold black-and-white coat and rotund body. 
                            The name 'giant panda' is sometimes used to distinguish it from the red panda, a neighboring musteloid.", context);
               
               var greenSeaTurtle = await CreateSpecie("Green sea turtle", @"The green sea turtle, also known as the green turtle, 
                            black turtle or Pacific green turtle, is a species of large sea turtle of the family Cheloniidae.
                             It is the only species in the genus Chelonia.", context);
               
               var blackFootedFerret = await CreateSpecie("Black-footed ferret", @"The black-footed ferret, also known as the American polecat or prairie dog hunter, is a species of mustelid native to central North America.
                             The black-footed ferret is roughly the size of a mink and is similar in appearance to the European polecat and the Asian steppe polecat.", context);


               var galapagosPenguin = await CreateSpecie("Galapagos penguin", @"The Galápagos penguin is a penguin endemic to the Galápagos Islands, Ecuador. It is the only penguin found north of the equator. 
                            Most inhabit Fernandina Island and the west coast of Isabela Island. The cool waters of the Humboldt and Cromwell Currents allow it to survive despite the tropical latitude.", context);
               
               var asianElephant = await CreateSpecie("Asian elephant", @"The Asian elephant, also known as the Asiatic elephant, is the only living species of the genus Elephas and is distributed throughout the Indian subcontinent and Southeast Asia, from India in the west,
                             Nepal in the north, Sumatra in the south, and to Borneo in the east.", context);
               
               
               var sumatranOrangutan = await CreateSpecie("Sumatran orangutan", @"The Sumatran orangutan is one of the three species of orangutans.
                             Critically Endangered, and found only in the north of the Indonesian island of Sumatra, 
                             it is rarer than the Bornean orangutan but more common than the recently identified Tapanuli orangutan, also found in Sumatra.", context);
               
               var redPanda = await CreateSpecie("Red panda", @"The red panda, also known as the lesser panda,
                             is a small mammal native to the eastern Himalayas and southwestern China. 
                             It has dense reddish-brown fur with a black belly and legs, white-lined ears, a mostly white muzzle and a ringed tail.", context);
               
               
               var lion = await CreateSpecie("Lion", @"The lion is a large cat of the genus Panthera native to Africa and India. It has a muscular, broad-chested body; short, rounded head;
                             round ears; and a hairy tuft at the end of its tail. It is sexually dimorphic; adult male lions are larger than females and have a prominent mane.", context);
               
               var polarBear = await CreateSpecie("Polar bear", @"The polar bear is a hypercarnivorous bear whose native range lies largely within the Arctic Circle,
                             encompassing the Arctic Ocean, its surrounding seas and surrounding land masses, this includes the most northern regions of North America and Eurasia.", context);
               
               var cheetah = await CreateSpecie("Cheetah", @"The cheetah is a large cat native to Africa, Southwest Asia and South Asia.
                             It is the fastest land animal, estimated to be capable of running at 80 to 98 km/h with the fastest reliably recorded speeds ", context);
               
               var hippo = await CreateSpecie("Hippo", @"The hippopotamus or hippo, further qualified as the common hippopotamus, Nile hippopotamus, or river hippopotamus, is a large semiaquatic mammal native to sub-Saharan Africa. 
                            It is one of only two extant species in the family Hippopotamidae, the other being the pygmy hippopotamus.", context);

               var wolf = await CreateSpecie("Wolf", @"The wolf, also known as the gray wolf or grey wolf, is a large canine native to Eurasia and North America. More than thirty subspecies of Canis lupus have been recognized, including the dog, though gray wolves, as popularly understood, only comprise wild subspecies.", context);

               var brownBear = await CreateSpecie("Brown bear", @"The brown bear is a large bear species found across Eurasia and North America. In North America, the populations of brown bears are called grizzly bears, while the subspecies that inhabits the Kodiak Islands of Alaska is known as the Kodiak bear.", context);

               var snowleopard = await CreateSpecie("Snow leopard", @"The snow leopard, also known as the ounce, is a felid in the genus Panthera native to the mountain ranges of Central and South Asia. It is listed as Vulnerable on the IUCN Red List because the global population is estimated to number fewer than 10,000 mature individuals and is expected to decline about 10% by 2040.", context);


               
               var animals = new List<Animal>
                {
                    new Animal{
                       Name = "Sweet Cat",
                       Gender = "Male",
                       CountryOfBirth = "Kenya",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = tiger

                    },
                     new Animal{
                       Name = "Nice Chimp",
                       Gender = "Female",
                       CountryOfBirth = "Congo",
                       Weight = 40f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = chimpanzee

                    },
                     new Animal{
                       Name = "Doggy",
                       Gender = "Male",
                       CountryOfBirth = "Kenya",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = africanWildDog

                    },
                     new Animal{
                       Name = "Hornni",
                       Gender = "Female",
                       CountryOfBirth = "South Africa",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = blackRhinoceros

                    },
                     new Animal{
                       Name = "Javan",
                       Gender = "Male",
                       CountryOfBirth = "Portugal",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = javanRhinoceros

                    },
                     new Animal{
                       Name = "Panda Kung Fu",
                       Gender = "Male",
                       CountryOfBirth = "China",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = giantPanda

                    },
                     new Animal{
                       Name = "Turtle Joe",
                       Gender = "Female",
                       CountryOfBirth = "Galapagos Islands",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = greenSeaTurtle

                    },
                     new Animal{
                       Name = "Ferret Anne",
                       Gender = "Female",
                       CountryOfBirth = "USA",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = blackFootedFerret

                    },
                     new Animal{
                       Name = "Peng Willy",
                       Gender = "Male",
                       CountryOfBirth = "Galapagos Islands",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = galapagosPenguin

                    },
                     new Animal{
                       Name = "Thrombus",
                       Gender = "Female",
                       CountryOfBirth = "India",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = asianElephant

                    },
                     new Animal{
                       Name = "Suman",
                       Gender = "Male",
                       CountryOfBirth = "Indonesia",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = sumatranOrangutan

                    },
                     new Animal{
                       Name = "Redy",
                       Gender = "Male",
                       CountryOfBirth = "China",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = redPanda
                    },
                     new Animal{
                       Name = "Kitty",
                       Gender = "Male",
                       CountryOfBirth = "Kenya",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = lion

                    },
                     new Animal{
                       Name = "Polly",
                       Gender = "Female",
                       CountryOfBirth = "Alaska",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = polarBear

                    },
                     new Animal{
                       Name = "Cheetos",
                       Gender = "Male",
                       CountryOfBirth = "Kenya",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = cheetah

                    },
                     new Animal{
                       Name = "Pippa",
                       Gender = "Female",
                       CountryOfBirth = "Kenya",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = hippo
                    },
                     new Animal{
                       Name = "Wolfy",
                       Gender = "Female",
                       CountryOfBirth = "Canada",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = wolf

                    },
                     new Animal{
                       Name = "Browny",
                       Gender = "Male",
                       CountryOfBirth = "Canada",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = wolf

                    },
                     new Animal{
                       Name = "Sonny",
                       Gender = "Female",
                       CountryOfBirth = "Pakistan",
                       Weight = 50f,
                       BirthDate = new DateTime(2016, 5, 2),
                       Specie = snowleopard

                    }
                };
                    
                await context.Animals.AddRangeAsync(animals);
                await context.SaveChangesAsync();
            }

            public async static Task<Specie> CreateSpecie(string name, string description, DataContext datacontext)
            {
               var specie =  new Specie {
                         Name = name,
                         Description = description
                    };

               datacontext.Species.Add(specie);

               await datacontext.SaveChangesAsync();

               return specie;
            }
        }
    }


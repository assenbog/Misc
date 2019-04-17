namespace iCal
{
    using System;
    using System.IO;
    using System.Text;
    using Ical.Net;
    using Ical.Net.CalendarComponents;
    using Ical.Net.DataTypes;
    using Ical.Net.Serialization;

    public static class NameDays2018
    {
        public static Calendar Calendar { get; }

        // Note: Source: https://imenidni.eu/
        static NameDays2018()
        {
            const string className = "BulgarianNameDays2018";
            const string locationCountry = "Bulgaria";

            Calendar = new Calendar();

            Calendar.Events.AddRange
            (new [] 
            {
                // January
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Васильовден",
                    Description = "Имен ден празнуват: Васил Василен Василена Василий\r\nВасилка Васка Весела Веселин Веселина Вълко Вълчо",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 1))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 1))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Силвестър Римски",
                    Description = "Имен ден празнуват: Горан Горица Огнян Огняна Пламен Пламена Серафим Силва Силвия Силвана Силвестър",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 2))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 2))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Събор на св. 70 апостоли. Прпмчк Онуфрий Габровски. Преп. Теоктист, игумен.",
                    Description = "Имен ден празнуват: Тихомир Тихомира Тихомирка",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 4))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 4))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Зимен Кръстовден (Попова Коледа). Св. мчци Теопемт и Теона",
                    Description = "Имен ден празнуват: Кръстьо Кръстана",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 5))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 5))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Богоявление - Йордановден",
                    Description = "Имен ден празнуват: Банчо Бистра Богдан Богдана Богoлюб Богoлюбa Богомил Божан Божана Божидар Божидара Божил Бончо Борислав Борислава Боян Бояна Данка Данко Данчо Йордан Йордана Йорданкa Найден Теодосий",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 6))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 6))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Ивановден - Св. Йоан Кръстител",
                    Description = "Имен ден празнуват: Ваньо Еньо Енчо Жан Жанa Жанета Ивайла Ивайло Иван Ивана Иванкa Иванинa Ивелин Ивелина Ивета Иво Йоан Йоанa Йовка Йовко Йонка Йонко Йончо Йото Калоян",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 7))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 7))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Теодосий Велики",
                    Description = "Имен ден празнуват: Богдан Богдана Теодосий",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 11))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 11))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Мъченица Татяна",
                    Description = "Имен ден празнуват: Таня Татияна Татяна Траяна",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 12))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 12))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. отци, избити в Синай и Раита. Св. Нина (Отдание на Богоявление)",
                    Description = "Имен ден празнуват: Адам Калчо Нина Нино",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 14))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 14))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Гавриил Лесновски, Прохор Пшински, Павел Тивейски и Йоан Колибар. Св. Герасим, патр. Александрийски",
                    Description = "Имен ден празнуват: Гаврил",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 15))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 15))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Поклонение на честните вериги на св. ап. Петър. Преп. Ромил Видински. Св. свщмчк Дамаскин Габровски",
                    Description = "Имен ден празнуват: Ромил",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 16))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 16))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Антоновден - Св. преподобни Антоний Велики",
                    Description = "Имен ден празнуват: Андон Антоан Антоанета Антон Антонина Антония Донка Донко Дончо Тони Тонка Тончо Тоньо Тоня Тотьо Тотка",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 17))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 17))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Атанасовден",
                    Description = "Имен ден празнуват: Атанас Атанаска Наска Наско Начо Таньо Таню Тинка",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 18))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 18))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Макарий Египетски. Св. Марк, еп. Ефески.",
                    Description = "Имен ден празнува: Макарий",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 19))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 19))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Петльовден - Св. патриарх Евтимий Търновски",
                    Description = "Имен ден празнуват: Евтим Евтимия Ефтим Евтимий Ефтимия",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 20))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 20))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Максим изповедник. Св. мчк. Неофит",
                    Description = "Имен ден празнуват: Валери Валерия Максим Максимилиян Неофит",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 21))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 21))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св.ап. Тимотей. Свщмчк Петър и св. мчк. Сионий Български. Прпмчк Анастасий Перски",
                    Description = "Имен ден празнува: Тимофей",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 22))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 22))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Ксения Римлянка",
                    Description = "Имен ден празнуват: Аксения Аксиния Ксения",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 24))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 1, 24))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // February
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчк Трифон (Трифон Зарезан / Трифоновден)",
                    Description = "Имен ден празнуват: Трифон Трифонка Лозан Лозанка Секул",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 1))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 1))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Симеон Богоприимец и Анна пророчица",
                    Description = "Имен ден празнуват: Симеон Симеона Симеонка Симеонко Симо Симон Симона Симонка Симча Симчо Симян Симяна Симе Сима Симан Симана Мони Моньо Мона Монка Моника",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 3))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 3))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчца Агатия. Св. Полиевкт, патр. Константинополски",
                    Description = "Имен ден празнува: Агата Агатия Добрин Добринка",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 5))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 5))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Фотий, патриарх Цариградски. Преп. Вукол, епископ Смирненски",
                    Description = "Имен ден празнуват: Доротея Огнян Огняна Искра Искрен Пламен Пламена Светла Светлана Светозар Светлозар Светослав Светослава Фотий Фотин Фотина Фотьо",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 6))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 6))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчк Никифор (Отдание на Сретение Господне)",
                    Description = "Имен ден празнува: Никифор",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 9))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 9))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. свещеномъченик Харалампий Магнезийски",
                    Description = "Имен ден празнуват: Харалампий Харалампи Валентин Валентина",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 10))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 10))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Зоя. Св. Евлогий, архиеп. Александрийски. Преп. Мартиниан",
                    Description = "Имен ден празнуват: Евлоги Евлогий Евлогия",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 13))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 13))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Свети Валентин",
                    Description = "Имен ден празнуват: Валентин Валентина Вальо Валю Валя",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 14))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 14))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Евстатий, архиепископ Антиохийски",
                    Description = "Имен ден празнуват: Евстати Евстатий Евстатия",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 21))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 21))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                // подвижен празник
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Тодоров ден, Конски Великден",
                    Description = "Имен ден празнуват: Божидар Божидара Дора Дорина Доротея Теодор Теодора Теодорина Тодор Тодора Тодорка",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 24))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 2, 24))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // March
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. прпмчца Евдокия",
                    Description = "Имен ден празнуват: Евдокия Марта Мартин",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 1))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 1))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Герасим Йордански (Блажи се риба и млечни храни) (Велокоп. служба)",
                    Description = "Имен ден празнува: Герасим",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 4))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 4))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. 42 мчци в Амория",
                    Description = "Имен ден празнуват: Красен Красимир Красимира",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 6))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 6))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. 40 мчци в Севастия. Св. мчк Исихий",
                    Description = "Имен ден празнуват: Вивиан Вивиана",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 9))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 9))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мъченици Кодрат, Саторин, Руфин, Галина и др. - от Коринт († ок. 250)",
                    Description = "Имен ден празнуват: Галя Галина",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 10))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 10))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Алексий, човек Божий",
                    Description = "Имен ден празнуват: Алеко Алекса Алексей Алекси Алексий",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 17))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 17))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Мчци Хрисант и Дария (Злат. литургия)",
                    Description = "Имен ден празнуват: Дария Дарин Дарина Найден Найдa",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 19))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 19))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Яков изповедник",
                    Description = "Имен ден празнува: Яков",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 21))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 21))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. прпмчци Никон и Лука Одрински. Мчца Лидия (Прежд. литургия)",
                    Description = "Имен ден празнува: Лидия",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 23))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 23))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. захария. Св. Артемий Солунски",
                    Description = "Имен ден празнуват: Зарко Захари Захарина Хари",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 24))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 24))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Благовещение",
                    Description = "Имен ден празнуват: Блага Благовеста Благой",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 25))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 25))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Събор на Св. Архангел Гавриил. Св. мчк Георги Софийски",
                    Description = "Имен ден празнуват: Габриел Габриела Гаврил",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 26))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 26))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Иларион. Св. Стефан. Св. свщмчци Георги и Петър. Св. мчк Боян",
                    Description = "Имен ден празнуват: Албена Баян Бойка Бойко Бойчо Боян Бояна Иларион",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 28))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 28))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                // подвижен празник
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Лазаровден",
                    Description = "Имен ден празнуват: Лазар Лазарка Лазарин",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 31))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 3, 31))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // April
                // подвижен празник
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Цветница, Връбница (Преп. Мария Египетска. Св. мчк Аврамий Български)",
                    Description = "Имен ден празнуват: Аврам Аглика Божура ВероникаВиола Виолета Върба Върбан Върбинка Гергин Гроздена Далия Дафина Делян Деляна Дилян Диляна Детелина Елица Жасмина Здравко Здравка Зюмбюла Ива Иглена Иглика Калина Камелия Карамфил Карамфила Китка Латин Латинка Лилия Лиляна Лила Лили Лоза Люлина Магнолия Малина Маргарит Невен Невена Невян Ненка Орхидея Ралица Ренета Роза Росен Росица Ружа Теменужка Трендафил Цено Цвета Цветелина Цветан Цветелин Цветомила Цветомир Цвятко Явор Ясен Ясмина Цветомира Цветанка Маргарита",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 1))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 1))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Велики Понеделник Преп. Йоан, Св. мчк Виктор (Прежд. литургия)",
                    Description = "Имен ден празнуват: Виктор Виктория",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 2))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 2))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Успение на св. Методий Славянобългарски. Св. Ехтихий. Св. мчци Тимотей и Диоген",
                    Description = "Имен ден празнува: Страхил",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 6))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 6))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                // подвижен празник
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Възкресение Христово, Великден",
                    Description = "Имен ден празнуват: Велик Велика Велико Велин Велислав Величка Величко Велка Велко Вельо Вили Витан Велина",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 8))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 8))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                // подвижен празник
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Живоприемни източник – Светли петък след Великден",
                    Description = "Имен ден празнуват: Жива Живка Живко Жишо Зоя",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 13))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 13))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Мартин, папа Римски",
                    Description = "Имен ден празнуват: Марти Мартин",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 14))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 14))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                // подвижен празник
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Томина неделя",
                    Description = "Имен ден празнуват: Тома Томислав Томислава",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 15))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 15))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Йоан. Св. мчк Виктор",
                    Description = "Имен ден празнуват: Виктор Виктория",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 18))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 4, 18))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // May
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. прор. Иеремия. Прпмчк Акакий Серски. Св. Тамара",
                    Description = "Имен ден празнува: Тамара",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 1))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 1))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. цар Борис-Михаил",
                    Description = "Имен ден празнуват: Борис Богорис Борислав Борислава Боряна",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 2))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 2))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мъченица Ирина",
                    Description = "Имен ден празнуват: Ирина Ирена Иринка Ириней Мира Мирослав Мирослава Мирчо",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 5))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 5))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. вмчк Георги Победоносец - Гергьовден",
                    Description = "Имен ден празнуват: Галя Ганка Ганчо Генчо Гео Георги Георгина Гергана Гинка Гиньо Гиргин Гиргина Гоце Гюро Гюрга Гюргелена Йорго Порица Гергина",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 6))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 6))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Св. Кирил и Методий",
                    Description = "Имен ден празнуват: Кирил Кирилка Киро Кирчо Методи Методий",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 11))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 11))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Епифаний Кипърски и Св. Герман Константинополски. Св. мчк Панкратий",
                    Description = "Имен ден празнуват: Герана Герасим Герда Герман Геро Искра Искрен",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 12))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 12))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                // подвижен празник
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Възнесение Господне - Спасовден",
                    Description = "Имен ден празнуват: Спас Спаска Спасена Спасения Спасимир СпасимираСпасуна Сотир",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 17))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 17))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Свети равноапостоли Константин и царица Елена",
                    Description = "Имен ден празнуват: Елена Елеонора Константин Константина Костадин Костадина Костадинка",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 21))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 21))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Исакий Далматски. Св. Емилия",
                    Description = "Имен ден празнува: Емилия",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 30))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 5, 30))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // June
                // подвижен празник
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Неделя на Всички светии",
                    Description = "Имен ден празнуват: Панайот Панталей Панчо",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 3))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 3))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св свщмчк Доротей. Преп. Петър",
                    Description = "Имен ден празнуват: Доротей Доротея",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 5))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 5))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. свщмчк Теодот, еп. Анкирски. Св. мчца Валерия",
                    Description = "Имен ден празнуват: Валери Валерия",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 7))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 7))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Неделя на всички български светии",
                    Description = "Имен ден празнуват: Асен Аспарух Крум Панайот Румен Румяна Чавдар",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 10))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 10))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчца Акилина. Св. Трифилий, еп. Никозийски",
                    Description = "Имен ден празнуват: Асен Аспарух",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 13))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 13))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. прор Амос. Св. мчк Исихий Доростолски",
                    Description = "Имен ден празнува: Августин",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 15))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 15))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Рождество на Йоан Кръстител (Еньовден)",
                    Description = "Имен ден празнуват: Биляна Ивет Ивета Денислав Деница Деян Деяна Янко Янка Янчо Енчо Еньо Янаки Яни Янислав Яна Янина Яница",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 24))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 24))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Свети апостоли Петър и Павел (Петровден)",
                    Description = "Имен ден празнуват: Камен Камена Кремена Павел Павлин Павлина Патриция Петрана Петър Преслава",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 29))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 29))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Събор на 12 апостоли",
                    Description = "Имен ден празнува: Апостол",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 30))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 6, 30))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // July
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. безсребърници Козма и Дамян. Възвръщане честните мощи на преп. Йоан Рилски чудотворец",
                    Description = "Имен ден празнуват: Дамян Кузман",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 1))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 1))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "вмчца Неделя",
                    Description = "Имен ден празнуват: Неделин Неделина Неделчо Недялка Недялко",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 7))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 7))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. ап. Акила. Преп. Никодим Светогорец",
                    Description = "Имен ден празнува: Орлин",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 14))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 14))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчци Кирик и Юлита. Св. равноап. велик княз Владимир",
                    Description = "Имен ден празнуват: Владимир Владимира Господин",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 15))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 15))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. свщмчк Атиноген и 10-те му ученици. Св. мчца Юлия девица",
                    Description = "Имен ден празнуват: Юлия Юлиян",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 16))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 16))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. вмчца Марина",
                    Description = "Имен ден празнуват: Марина Марин Маринчо Маринка Маринела Марчо",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 17))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 17))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "СВ. ПРОРОК ИЛИЯ /ИЛИНДЕН/",
                    Description = "Имен ден празнуват: Илия Илиян Илияна Илкo Илкa Илчо",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 20))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 20))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мироносица и равноапостолна Мария Магдалина",
                    Description = "Имен ден празнуват: Мадлен Мадлена Магдалена Магда Миглена",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 22))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 22))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Успение на св. Анна. Св. дякониса Олимпиада и Евпраксия Девица",
                    Description = "Имен ден празнуват: Анна Анка Ани Анани Яна Янула Янина Блага Добри",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 25))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 25))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. праведни Евдоким",
                    Description = "Имен ден празнуват: Евдоким Евдоки Дочо",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 31))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 7, 31))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // August
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. 7 мчци братята Макавеи, Св. Соломония",
                    Description = "Имен ден празнуват: Макавей Здравко Здравка",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 1))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 1))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "8 Неделя след Петдесетница. Св. прпмчк Дометий. Св. мчца Потамия",
                    Description = "Имен ден празнуват: Валери Валерия",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 7))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 7))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Успение на Пресвета Богородица",
                    Description = "Имен ден празнуват: Мария Мариана Мариела Мариета Марио Марияна Преслава",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 15))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 15))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчци Адриан и Наталия",
                    Description = "Имен ден празнуват: Адриан Адриана Адриян Адрияна Наталия Наташа",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 26))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 26))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Александър, Йоан и Павел, патриарси Константинополски. Пренасяне честните мощи на св. Александър",
                    Description = "Имен ден празнуват: Алеко Александър Александра Александрина",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 30))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 30))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Полагане честния пояс на Пресвета Богородица. Св. свщмчк Киприан Картагенски. Св. Генадий Константинополски",
                    Description = "Имен ден празнуват: Гена Гено",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 31))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 8, 31))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // September
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Симеон Стълпник. Св. Марта. Св. мчци Айтал и Амун дякони",
                    Description = "Имен ден празнуват: Симеон Симона",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 9, 1))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 9, 1))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. прор. Захария и праведна Елисавета",
                    Description = "Имен ден празнуват: Бетина Елза Елисавета Захари Захарий Захаринка Изабела Светлозар",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 9, 5))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 9, 5))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Въздвижение на Светия животворящ Кръст Господен (Кръстовден)",
                    Description = "Имен ден празнуват: Кръстю Кръстьо Кръстенa Кристина Кръстина Кънчо Ставри",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 9, 14))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 9, 14))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчци София, Вяра, Надежда и Любов. Св. мчца Теодотия. Св. Нил Египетски",
                    Description = "Имен ден празнуват: Вера Вяра Надежда Любов",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 9, 17))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 9, 17))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Евфросиния Александрийски. Преп. Сергий Радонежки, чудотворец",
                    Description = "Имен ден празнуват: Ефросиния Сергей",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 9, 25))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 9, 25))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // October
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. свещеномъченик Дионисий Ареопагит, епископ Атински († ок. 96), Презвитер Рустик и дякон Елевтери",
                    Description = "Имен ден празнуват: Денис Денислав Денислава",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 3))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 3))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. ап. Яков Алфеев. Преп. Андроник и Атанасия",
                    Description = "Имен ден празнува: Аврам",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 9))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 9))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Петковден - Св. Параскева-Петка Търновска",
                    Description = "Имен ден празнуват: Параскев Параскева Парашкева Пенка Пенко Петка Петкан Петкана Петко Петя",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 14))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 14))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. ап. и ев. Лука. Св. вмчца Злата Мъгленска",
                    Description = "Имен ден празнуват: Злата Златимира",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 18))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 18))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Димитровден",
                    Description = "Имен ден празнуват: Димитър Димитрина Митко Митьо Димo Димчо Димка Димaнa",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 26))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 26))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Мчк. Нестор (МИШИ ПРАЗНИЦИ)",
                    Description = "Имен ден празнува: Нестор",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 27))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 27))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. великомъченица Параскева",
                    Description = "Имен ден празнуват: Параскева Лъчезар Лъчезара",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 28))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 28))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мъченик Зиновий и сестра му Зиновия",
                    Description = "Имен ден празнуват: Зоран Зорица Зорка Зорница",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 30))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 10, 30))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // November
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. безсребърници и чудотворци Козма и Дамян. Св. прпмчци Яков Костурски, дякон Яков и монах Диониси",
                    Description = "Имен ден празнува: Аргир",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 1))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 1))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Рангел (архангел Михаил) Архангеловден",
                    Description = "Имен ден празнуват: Ангел Ангелина Ангелинка Архангел Гавраил Гаврил Емил Емилия Емилиян Емилияна Лина Мила Миладин Милан Милана Миланка Милен Милена Мильо Михаел Михаела Михаил Михаила Михо Огнян Огняна Пламен Пламена Рада Ради Радивой Радка Радко Радмила Радослав Радослава Радостин Радостина Райко Райна Райчо Рангел Рафаил Рая Руси Руска Руслан Серафим",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 8))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 8))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчци Мина, Виктор и Викентий. Св. мчца Стефанида. Преп. Теодор Студит, изповедник",
                    Description = "Имен ден празнуват: Виктор Виктория Мина Минка Минчо",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 11))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 11))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. ап. Филип. Св. благоверни цар Управда-Юстиниан (Коледни заговезни)",
                    Description = "Имен ден празнуват: Управда Филип Филка Фильо Юстиниан",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 14))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 14))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. апостол и евангелист Матей",
                    Description = "Имен ден празнуват: Матей Матю",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 16))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 16))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Амфилохий, еп. Иконийски. Св. Григорий, еп. Акрагантийски. Св. благоверен княз Александър Невски",
                    Description = "Имен ден празнуват: Александър Александра Сашо Сашка Цанка Цанко",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 23))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 23))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. вмчца Екатерина. Св. вмчк Меркурий",
                    Description = "Имен ден празнуват: Екатерина Катерина Катрин Катя Тинка",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 24))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 24))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп Алипий Стълпник. Св. Стилиян Пафлагонийски. Преп. Яков Отшелник",
                    Description = "Имен ден празнуват: Стилиан Стилиана Стилиян Стилияна Стелян Стела Стилян Щерян Щеряна Щилиан Щилиана Щилиян Щилияна",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 26))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 26))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. всехвален апостол Андрей Първозвани (Андреевден)",
                    Description = "Имен ден празнуват: Андреа Андрей Андрейка Андрея Андриян Андрияна Андро Дешка Първан Силен Храбрин Храбър",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 30))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 11, 30))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },

                // December
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Света мъченица Варвара. Преп. Йоан Дамаскин (Разрешава се риба)",
                    Description = "Имен ден празнуват: Барбара Варвара Варвардан",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 4))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 4))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Сава Освещени. Преп. Нектарий Битолски",
                    Description = "Имен ден празнуват: Венцислав Венцислава Владислав Владислава Десислав Десислава Сабина Сава Савка Савчо Светослав Светослава Слав Слава Славей Славейка Славейко Слави Славка Славчо Станислав Станислава Съби Събина",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 5))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 5))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Николай - Никулден",
                    Description = "Имен ден празнуват: Никол Никола Николай Николина Николинка Николета Ненка Нина Нинка Кольо Нико Ница Нено",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 6))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 6))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Света Анна",
                    Description = "Имен ден празнуват: Ана Анета Анелия Анка Анна Аница Аня Яна Янка Янко",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 9))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 9))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. Спиридон, еп. Тримитунтски чудотворец",
                    Description = "Имен ден празнуват: Спиридон Спиро",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 12))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 12))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчци Евстратий, Авксентий, Евгений, Мардарий и Орест. Св. мчца Лукия девица.",
                    Description = "Имен ден празнуват: Евгений Адам",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 13))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 13))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчци Тирс, Левкий, Филимон",
                    Description = "Имен ден празнуват: Снежа Снежана Снежка Снежи Снежна Снежанка",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 14))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 14))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. свщмчк Елевтерий. Преп. Павел Латрийски",
                    Description = "Имен ден празнуват: Свобода",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 15))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 15))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. прор. Даниил и св. 3 отроци Анания, Азария и Мисаил",
                    Description = "Имен ден празнуват: Анани Данаил Данаила Даниел Даниела Дани Данко",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 17))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 17))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Игнажден",
                    Description = "Имен ден празнуват: Игнат Искра Искрен Огнян Огняна Светла Светослав Пламен Пламена",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 20))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 20))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. мчца Юлиания",
                    Description = "Имен ден празнуват: Юлиан Юлиана Юлиян Юлияна",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 21))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 21))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Св. вмчца Анастасия",
                    Description = "Имен ден празнуват: Анастасия Ася Сийка Сия",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 22))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 22))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Преп. Наум Охридски. Св. 10 мчци в Крит. Св. мчк Геласий. (Утреня, Царски часове, Отпуст)",
                    Description = "Имен ден празнуват: Бисер Бисера Бисерка Бистра Наум",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 23))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 23))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Бъдни вечер. Св. прпмчца Евгения. Преп. Николай войн, българин",
                    Description = "Имен ден празнуват: Евгени Евгений Евгения Бисер Бисера Бистра Благородна Жени Женя Жечка Първан Първана",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 24))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 24))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Рождество Христово, Коледа",
                    Description = "Имен ден празнуват: Емил Ицо Ичо Младен Радомир Радомира Радослав Радослава Радостин Радостина Христалина Христо Христи Христин Христина Христофор",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 25))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 25))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Събор на Пресвета Богородица. Св. Йосиф Обручник. Св. цар Давид. Св. Яков, брат Божий",
                    Description = "Имен ден празнуват: Давид Дацо Дачо Жозеф Йосиф",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 26))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 26))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                },
                new CalendarEvent
                {
                    Class = className,
                    Summary = "Стефановден",
                    Description = "Имен ден празнуват: Венчо Венцислав Венцислава Запрян Стамен Стамена Стан Стана Стане Станимир Станимира Станислав Станислава Станчо Стефан Стефана Стефанка Стефания Стефи Стефка Стефко Стефчо Стоил Стоила Стоилка Стоимен Стоичко Стою Стоян Стояна Стоянка Таня Теки Теньо Фани Цако Цанка Цанко Цано Цанчо Цоко Цона Цонко Цоню Шон Шона",
                    Start = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 27))),
                    End = new CalDateTime(Convert.ToDateTime(new DateTime(2018, 12, 27))),
                    Uid = Guid.NewGuid().ToString(),
                    Location = locationCountry
                }
            });
        }

        public static void Save(string fileName)
        {
            var serialise = new CalendarSerializer(Calendar);

            using (var stream = new StreamWriter(fileName))
            {
                serialise.Serialize(Calendar, stream.BaseStream, Encoding.UTF8);
            }
        }
    }
}

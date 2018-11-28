# cats-and-dogs


Проверил

По коллекции все хорошо.
По атрибуту тоже.
Странный блок 

try
            {
                tiger = new Felidae("Тигра", Felidae.Cat.Big);
            }
            catch (ArgumentException ex)
            {
                logger.Warn($"{ex.Message}" + " Объект создан с параметром по умолчанию");
                tiger = new Felidae("Тигра", Felidae.Cat.Big);
            }
            
            Если код  tiger = new Felidae("Тигра", Felidae.Cat.Big); - падает, писать лог и еще раз прогонять конструктор, который падает?
            
Логер чтобы не писать везде Logger logger = LogManager.GetCurrentClassLogger(); - выносить в статический класс и юзать от туда.
Задание принял

﻿using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Entities.Enum;
using Domain.Entities.Setup;
using System.Linq.Expressions;

namespace Data.DumbData
{
    public static class Storage
    {
        #region Names
        public readonly static List<string> FemaleFirstNames = new List<string>()
        {
            "Аделина",
            "Аделия",
            "Адель",
            "Аделя",
            "Адиля",
            "Азалия",
            "Аида",
            "Аксинья",
            "Александра",
            "Алексия",
            "Алёна",
            "Алеся",
            "Алина",
            "Алиса",
            "Алисия",
            "Алия",
            "Алла",
            "Алсу",
            "Альбина",
            "Амалия",
            "Амелия",
            "Анастасия",
            "Ангелина",
            "Анжела",
            "Анита",
            "Анна",
            "Антонина",
            "Анфиса",
            "Ариадна",
            "Ариана",
            "Арина",
            "Армина",
            "Ася",
            "Белла",
            "Валентина",
            "Варвара",
            "Василина",
            "Василиса",
            "Василь",
            "Вера",
            "Вероника",
            "Видана",
            "Виктория",
            "Вилена",
            "Виолетта",
            "Виталина",
            "Влада",
            "Внучка",
            "Галина",
            "Галия",
            "Гера",
            "Гульназ",
            "Дана",
            "Дания",
            "Данияр",
            "Дария",
            "Дарья",
            "Дея",
            "Диана",
            "Диляра",
            "Динара",
            "Диночка",
            "Ева",
            "Евангелина",
            "Евгения",
            "Екатерина",
            "Елизавета",
            "Есения",
            "Жанна",
            "Жасмин",
            "Зарина",
            "Зиля",
            "Злата",
            "Иделия",
            "Изабелла",
            "Илона",
            "Ильмира",
            "Ильназ",
            "Ильнара",
            "Инга",
            "Ингеборга",
            "Индира",
            "Инесса",
            "Инна",
            "Ирина",
            "Камилла",
            "Камиля",
            "Карина",
            "Каролина",
            "Кира",
            "Кияра",
            "Кристина",
            "Ксения",
            "Лада",
            "Лана",
            "Лариса",
            "Лаура",
            "Лейла",
            "Лейсан",
            "Ленар",
            "Лиана",
            "Лидия",
            "Лилиана",
            "Лилия",
            "Лина",
            "Линара",
            "Лолита",
            "Любава",
            "Любовь",
            "Людмила",
            "Мадина",
            "Майа",
            "Малика",
            "Маргарита",
            "Марианна",
            "Марина",
            "Мария",
            "Маруся",
            "Марьям",
            "Милена",
            "Мирослава",
            "Мия",
            "Моника",
            "Надежда",
            "Наиля",
            "Намлана",
            "Настя",
            "Наталья",
            "Нелли",
            "Нелля",
            "Неля",
            "Николь",
            "Нина",
            "Нинель",
            "Олеся",
            "Ольга",
            "Полина",
            "Радмила",
            "Ралина",
            "Регина",
            "Реналь",
            "Рената",
            "Римма",
            "Ринат",
            "Рита",
            "Розалина",
            "Розалия",
            "Роксана",
            "Рузалина",
            "Руслана",
            "Сабина",
            "Сабрина",
            "Саида",
            "Самира",
            "Сафия",
            "Светлана",
            "Серафима",
            "Снежанна",
            "Соня",
            "Софа",
            "София",
            "Софья",
            "Станислава",
            "Стелла",
            "Стефания",
            "Сюзанна",
            "Таисия",
            "Тамара",
            "Татьяна",
            "Ульяна",
            "Чулпан",
            "Шакир",
            "Эвелина",
            "Элиза",
            "Элина",
            "Эльвина",
            "Эльвира",
            "Эльза",
            "Эльмира",
            "Эмилия",
            "Эмма",
            "Энже",
            "Юлианна",
            "Юлия",
            "Яна",
            "Ярослава"
        };

        public readonly static List<string> MaleFirstNames = new List<string>()
        {
            "Азат", "Айдар",
            "Айнур",
            "Айрат",
            "Аким",
            "Алан",
            "Александр",
            "Алексей",
            "Алим",
            "Алмаз",
            "Альберт",
            "Альфред",
            "Амир",
            "Амирхан",
            "Анатолий",
            "Анвар",
            "Андрей",
            "Антон",
            "Арсен",
            "Арсений",
            "Арслан",
            "Артем",
            "Артемий",
            "Артур",
            "Аскар",
            "Ахат",
            "Богдан",
            "Борис",
            "Булат",
            "Вагиз",
            "Вадим",
            "Валентин",
            "Валерий",
            "Василий",
            "Виктор",
            "Виталий",
            "Влад",
            "Владимир",
            "Владислав",
            "Владлен",
            "Внучек",
            "Всеволод",
            "Вячеслав",
            "Гамид",
            "Геннадий",
            "Георгий",
            "Герман",
            "Глеб",
            "Гордей",
            "Григорий",
            "Гриша",
            "Давид",
            "Далер",
            "Дамир",
            "Данил",
            "Даниль",
            "Данир",
            "Даниэль",
            "Демид",
            "Демьян",
            "Динар",
            "Дмитрий",
            "Евгений",
            "Егор",
            "Елизар",
            "Елисей",
            "Ерофей",
            "Ефим",
            "Захар",
            "Иван",
            "Игнат",
            "Игорь",
            "Ильдан",
            "Ильдар",
            "Ильмир",
            "Ильнар",
            "Ильнур",
            "Ильшат",
            "Илья",
            "Ильяз",
            "Ильяс",
            "Искандер",
            "Ислам",
            "Камиль",
            "Карим",
            "Кирилл",
            "Клим",
            "Климентий",
            "Константин",
            "Лев",
            "Леонид",
            "Макар",
            "Максим",
            "Максимилиан",
            "Мансур",
            "Марат",
            "Марк",
            "Марс",
            "Марсель",
            "Мартин",
            "Матвей",
            "Мирон",
            "Мирослав",
            "Митя",
            "Михаил",
            "Мурат",
            "Муслим",
            "Назар",
            "Наиль",
            "Никита",
            "Николай",
            "Олег",
            "Оскар",
            "Павел",
            "Петенька",
            "Пётр",
            "Платон",
            "Равиль",
            "Радик",
            "Радмир",
            "Раис",
            "Рамазан",
            "Рамис",
            "Юрий",
            "Ян",
            "Яромир",
            "Ярослав",
            "Яша"
        };
        #endregion
    }
}

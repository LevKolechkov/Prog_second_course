class Animal {
  constructor(jsonParsedObject) {
    this.nameOfAnimal = jsonParsedObject.nameOfAnimal;
    this.weight = jsonParsedObject.weight;
    this.weightOfEatenFoodInDay = jsonParsedObject.weightOfEatenFoodInDay;
    this.typeOfFood = jsonParsedObject.typeOfFood;
  }
}

const deer = {
  nameOfAnimal: "Deer",
  weight: 215,
  weightOfEatenFoodInDay: 15,
  typeOfFood: 1,
};
const lion = {
  nameOfAnimal: "Lion",
  weight: 230,
  weightOfEatenFoodInDay: 6,
  typeOfFood: 0,
};
const tiger = {
  nameOfAnimal: "Tiger",
  weight: 200,
  weightOfEatenFoodInDay: 10,
  typeOfFood: 0,
};
const elephant = {
  nameOfAnimal: "Elephant",
  weight: 5000,
  weightOfEatenFoodInDay: 300,
  typeOfFood: 1,
};

const listOfAnimals = [deer, tiger, lion, elephant];

// Создание файла JSON с именами животных
const fs = require("fs");

const saveData = (list) => {
  const finished = (error) => {
    if (error) {
      console.error(error);
      return;
    }
  };

  const jsonData = JSON.stringify(list);
  fs.writeFile("listOfAnimals.json", jsonData, finished);
};

saveData(listOfAnimals);

// Считываем список животных из JSON файла

fs.readFile("./listOfAnimals.json", "utf-8", (error, data) => {
  const listOfAnimalsFromJSON = JSON.parse(data);

  // Вывод всех данных о хищниках
  listOfAnimalsFromJSON.forEach((el) => {
    if (el.typeOfFood === 0) {
      console.log(
        `Name of animal: ${el.nameOfAnimal}\n`,
        `Weight of animal: ${el.weight}\n`,
        `Weight of eaten food: ${el.weightOfEatenFoodInDay}\n`,
        `Type of food: ${el.typeOfFood === 0 ? "meat" : "grass"}\n`
      );
    }
  });

  // Поиск и вывод животного с максимальным количеством съеденной пищи
  let maxWeightOfEatenFood = 0;
  let animalWithMaxOfEatenFood = {};

  listOfAnimalsFromJSON.forEach((el) => {
    if (el.weightOfEatenFoodInDay / el.weight > maxWeightOfEatenFood) {
      animalWithMaxOfEatenFood = el;
    }
  });

  console.log(
    `Name of animal with max of eaten food is ${animalWithMaxOfEatenFood.nameOfAnimal}`
  );
});

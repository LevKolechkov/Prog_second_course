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

// Создаём список животных
const readData = callback(error);
{
  fs.readFile("listOfAnimals.json", "utf8", (err, data) => {
    if (err) {
      console.error(err);
      callback(err, null);
      return;
    }

    try {
      const jsonData = JSON.parse(data);
      callback(null, jsonData);
    } catch (parseError) {
      console.error(parseError);
      callback(parseError, null);
    }
  });
}

readData((error, data) => {
  if (error) {
    console.error("Error reading the JSON file:", error);
    return;
  }

  console.log("Data from the JSON file:", data);
});

const listOfAnimals = [deer, lion, tiger, elephant];

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

// Считывание списка из JSON файла (пока что без чтения)
const myListOfAnimals = [deer, lion, tiger, elephant];

// Вывод всех данных о хищниках
myListOfAnimals.forEach((el) => {
  if (el.typeOfFood === 0) {
    console.log(`Name of animal: ${el.nameOfAnimal}.
Weight of animal: ${el.weight}.
Weight of eaten food: ${el.weightOfEatenFoodInDay}.
Type of food: ${el.typeOfFood === 0 ? "Meat" : "Grass"}\n`);
  }
});

// Поиск и вывод животного с максимальным количеством съеденной пищи
let maxWeightOfEatenFood = 0;
let animalWithMaxOfEatenFood = {};

myListOfAnimals.forEach((el) => {
  if (el.weightOfEatenFoodInDay / el.weight > maxWeightOfEatenFood) {
    animalWithMaxOfEatenFood = el;
  }
});

console.log(
  `Имя животного с максимальным количеством съеденной пищи: ${animalWithMaxOfEatenFood.nameOfAnimal}`
);

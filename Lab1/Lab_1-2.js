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
const fs = require("fs").promises;

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

const readData = async () =>
  await fs.readFile("Lab1/listOfAnimals.json", "utf8", (err, data) => {
    if (err) {
      console.error(err);
      callback(err, null);
      return;
    }

    try {
      const jsonData = JSON.parse(data);
      return jsonData;
    } catch (parseError) {
      console.error(parseError);
      return parseError;
    }
  });

let listOfAnimalsFromJSON;

readData()
  .then((jsonData) => {
    listOfAnimalsFromJSON = jsonData;
    return;
  })
  .catch((error) => console.error(error));

console.log(listOfAnimalsFromJSON);

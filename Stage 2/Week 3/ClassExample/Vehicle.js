class Vehicle
  {
      constructor(make,model,year){
        this.make = make;
        this.model = model;
        this.year = year;
      }
   
      info() {
        return "My " + this.make + " " + this.model + " is " + this.age() + " years old.";
      }

     age() {
      // date = new Date();  // This will not work
      let date = new Date(); // This will work
      return date.getFullYear() - this.year;
    }
  }
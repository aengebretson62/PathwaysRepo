class Car extends Vehicle
  {
    constructor(type,make,model, year) {
      super(make, model, year);
      this.type = type;
      }

  show() {
    return this.info() + ' It is a ' + this.type;
   }
  }
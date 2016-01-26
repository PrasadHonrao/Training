// Object literal syntax
var customer = {
	firstName: 'Prasad',
	lastName: 'Honrao',
	gender: 'M'
};

console.log(customer.firstName + " " + customer.lastName + " " + customer.gender)

// Object constructor syntax
var employee = new Object();
employee.firstName = 'Prasad';
employee.lastName = 'Honrao';
employee.gender = 'M';

console.log(employee.firstName + " " + employee.lastName + " " + employee.gender)

// Object.create
var dog = Object.create(Object.prototype, {
	name: {value: 'tommy', enumerable: true, writable: true, configurable: true},
	color: {value: 'white', enumerable: true, writable: true, configurable: true}
})

console.log(dog.name + " is a " + dog.color + " dog");

// ES6 classes
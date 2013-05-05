var vehicle = (function () {
    //slide 1 point 1
    function Vehicle(speed, propulsionUnits) {
        this.speed = speed;
        this.propulsionUnits = propulsionUnits;
    }
    Vehicle.prototype.accelerate = function () {
        var length = this.propulsionUnits.length;
        for (var i = 0 ; i < length; i+=1) {
            this.speed += this.propulsionUnits[i].getAcceleration();
        }
    }
    
    //slide 1 point 2 and 3
    function PropulsionUnit() {
    }

    PropulsionUnit.prototype.getAcceleration = function () {
        throw new Error("not implemented finction");
    }
    function Wheel(radius) {
        this.radius = radius;
    }

    Wheel.inherits(PropulsionUnit);

    Wheel.prototype.getAcceleration = function () {
        return parseInt(2 * Math.PI * this.radius);
    }
    
    //slide 2 point 1
    function PropellingNozzle(power, afterburnerState) {
        this.power = power;
        this.afterburnerState = afterburnerState;
    }

    PropellingNozzle.inherits(PropulsionUnit);

    PropellingNozzle.prototype.getAcceleration = function () {
        if (this.afterburnerState === AfterburnerState.ACTIVATED) {
            return 2 * this.power;
        }
        else {
            return this.power;
        }
    }

    //slide 2 point 2
    function Propeller(bladesNumber, rotationDirection) {
        this.bladesNumber = bladesNumber;
        this.rotationDirection = rotationDirection;
    }

    Propeller.inherits(PropulsionUnit);

    Propeller.prototype.getAcceleration = function () {
        if (this.rotationDirection === RotationDirection.CLOCKWISE) {
            return this.bladesNumber;
        }
        else {
            return -this.bladesNumber;
        }
    }

    //slide 3 point 1 and 2
    function Aircraft(speed, propellingNozzles) {
        Vehicle.apply(this, arguments);
    }
    
    Aircraft.inherits(Vehicle);

    Aircraft.prototype.switchAfterburners = function (afterburnerState) {
        for (var i = 0, len = this.propulsionUnits.length; i < len; i++) {
            if (this.propulsionUnits[i] instanceof PropellingNozzle) {
                this.propulsionUnits[i].afterburnerState = afterburnerState;
            }
        }
    }

    //slide 3 point 3
    function Watercraft(speed, propellers) {
        Vehicle.apply(this, arguments);
    }

    Watercraft.inherits(Vehicle);

    Watercraft.prototype.setPropellersRotationDirection = function (rotationDirection) {
        for (var i = 0; i < this.propulsionUnits.length; i++) {
            if (this.propulsionUnits[i] instanceof Propeller) {
                this.propulsionUnits[i].rotationDirection = rotationDirection;
            }
        }
    }

    //slide 4 point 1
    function Amphibian(speed, propellers, wheels, mode) {
        var propulsionUnits = [];
        var propLength = propellers.length;

        for (var i = 0; i < propLength; i += 1) {
            propulsionUnits.push(propellers[i]);
        }

        var wheelsLength = wheels.length;
        for (var j = 0; j < wheelsLength; j += 1) {
            propulsionUnits.push(wheels[i]);
        }

        Vehicle.call(this, speed, propulsionUnits);
        this.mode = mode;
    }

    Amphibian.inherits(Vehicle);
    Amphibian.extends(Watercraft, "setPropellersRotationDirection");

    Amphibian.prototype.accelerate = function () {
        if (this.mode === AmphibianMode.LAND) {
            var propUnitsLength = this.propulsionUnits.length;

            for (var i = 0; i < propUnitsLength ; i += 1) {
                if (this.propulsionUnits[i] instanceof Wheel) {
                    this.speed += this.propulsionUnits[i].getAcceleration();
                }
            }
        }
        else {
            var propUnitsLength = this.propulsionUnits.length;
            
            for (var i = 0; i < propUnitsLength; i += 1) {
                if (this.propulsionUnits[i] instanceof Propeller) {
                    this.speed += this.propulsionUnits[i].getAcceleration();
                }
            }
        }
    }
    
    //inherit + extends 
    Function.prototype.inherits = function (parent) {
        this.prototype = new parent();
        this.prototype.constructor = parent;
    };

    Function.prototype.extends = function (parent) {
        var argsLength = arguments.length;

        for (var i = 1; i < argsLength; i += 1) {
            var name = arguments[i];
            this.prototype[name] = parent.prototype[name];
        }

        return this;
    }
    // enums 
    var AfterburnerState = Object.freeze({
        "ACTIVATED": 1,
        "DEACTIVATED": 2
    });

    var RotationDirection = Object.freeze({
        "CLOCKWISE": 1,
        "COUNTERCLOCKWISE": 2
    });

    var AmphibianMode = Object.freeze({
        "LAND": 1,
        "WATER": 2
    });
    //closure functions
    return {
        AfterburnerState: AfterburnerState,
        RotationDirection: RotationDirection,
        AmphibianMode: AmphibianMode,
        Wheel: Wheel,
        PropellingNozzle: PropellingNozzle,
        Propeller: Propeller,
        LandVehicle: LandVehicle,
        Aircraft: Aircraft,
        Watercraft: Watercraft,
        Amphibian: Amphibian
    };
}
)();
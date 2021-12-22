function run(name, job) {
    const person = {
        name: "",
        job: "",
        printIntroduction: function() {
            console.log(`My name is ${this.name}. My job is ${this.job}`);
        }
    };

    const me = Object.create(person);
    me.name += name;
    me.job += job;
    me.printIntroduction();
}

run("Thon", "QC");
function Company(data) {
    this.id = JSON.parse(data.id);
    this.name = JSON.parse(data.name);
    this.address = JSON.parse(data.address);
    this.industry = JSON.parse(data.industry);
    this.city = JSON.parse(data.city);
    this.contacts = JSON.parse(data.contacts);
}